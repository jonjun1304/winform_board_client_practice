using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace board
{
    public partial class UserUpdateForm : Form
    {
        private HttpClient client = new HttpClient();
        private bool isPasswordCheck = false;

        public UserUpdateForm()
        {
            InitializeComponent();
            Load += JoinUserForm_Load;
        }

        private async void JoinUserForm_Load(object sender, EventArgs e)
        {
            formInitializer();

            String url = $"{Config.ServerUrl}/user/{common.Session.UserId}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var userDto = JsonConvert.DeserializeObject<UserDto>(result);

                    txtUserPassword.Text = userDto.userPassword;
                    txtUserPasswordCheck.Text = userDto.userPassword;
                    if (!String.IsNullOrWhiteSpace(userDto.phoneNo))
                    {
                        maskTxtPhoneNo.Text = userDto.phoneNo;
                    }
                    if (!String.IsNullOrWhiteSpace(userDto.birthday))
                    {
                        cBoxYear.Text = userDto.birthday.Substring(0, 4);
                        cBoxMonth.Text = userDto.birthday.Substring(4, 2);
                        cBoxDay.Text = userDto.birthday.Substring(6, 2);
                    }

                }
                else
                {
                    MessageBox.Show("회원 정보를 불러오는 데 실패했습니다.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"회원정보 요청 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void formInitializer()
        {
            // 메시지 초기화
            txtPasswordCheckMsg.Text = "";
            // 전화번호 Mask 세팅
            maskTxtPhoneNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 콤보박스 세팅
            int currentYear = DateTime.Today.Year;
            for (int i = 1; i <= 100; i++)
            {
                if (i >= 12) { cBoxYear.Items.Add(currentYear - i); }       // 연
                if (i <= 12) { cBoxMonth.Items.Add(i.ToString("D2")); }     // 월
                if (i <= 31) { cBoxDay.Items.Add(i.ToString("D2")); }       // 일
            }
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        private void txtUserPasswordCheck_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        private void passwordCheck()
        {
            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                isPasswordCheck = false;
                txtPasswordCheckMsg.Text = "비밀번호를 입력해주세요";
                txtPasswordCheckMsg.ForeColor = Color.Red;
                return;
            }

            string password1 = txtUserPassword.Text;
            string password2 = txtUserPasswordCheck.Text;
            if (password1 == password2)
            {
                isPasswordCheck = true;
                txtPasswordCheckMsg.Text = "비밀번호가 일치합니다.";
                txtPasswordCheckMsg.ForeColor = Color.Green;
            }
            else
            {
                isPasswordCheck = false;
                txtPasswordCheckMsg.Text = "비밀번호가 불일치합니다.";
                txtPasswordCheckMsg.ForeColor = Color.Red;
            }
        }

        private async void btnUserUpdate_Click(object sender, EventArgs e)
        {
            String url = $"{Config.ServerUrl}/user/{common.Session.UserId}";

            // 회원가입 데이터 준비
            var userDto = new UserDto
            {
                userPassword = txtUserPassword.Text,
                birthday = $"{cBoxYear.Text}{cBoxMonth.Text}{cBoxDay.Text}",
                phoneNo = maskTxtPhoneNo.Text,
            };

            // JSON 직렬화
            string json = JsonConvert.SerializeObject(userDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    // 회원수정 성공 메시지
                    string resultMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"회원정보 수정이 완료되었습니다! \n{resultMsg}", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원 정보를 불러오는 데 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"회원정보 수정 요청 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
