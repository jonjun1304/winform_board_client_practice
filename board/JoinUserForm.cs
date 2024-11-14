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
    public partial class JoinUserForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private bool isUserIdCheck = false;
        private bool isPasswordCheck = false;

        public JoinUserForm()
        {
            InitializeComponent();

            Load += JoinUserForm_Load;
        }

        private void JoinUserForm_Load(object sender, EventArgs e)
        {
            // 메시지 초기화
            txtDuplicateCheckMsg.Text = "";
            txtPasswordCheckMsg.Text = "";
            // 전화번호 Mask 세팅
            maskTxtPhoneNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 콤보박스 세팅
            int currentYear = DateTime.Today.Year;
            for(int i = 1; i <= 100; i++)
            {
                if (i >= 12) { cBoxYear.Items.Add(currentYear - i); }       // 연
                if (i <= 12) { cBoxMonth.Items.Add(i.ToString("D2")); }     // 월
                if (i <= 31) { cBoxDay.Items.Add(i.ToString("D2")); }       // 일
            }
        }

        private async void btnUserIdCheck_Click(object sender, EventArgs e)
        {
            isUserIdCheck = false; // 아이디 중복체크 초기화

            if (string.IsNullOrWhiteSpace(txtUserId.Text)) 
            {
                txtDuplicateCheckMsg.Text = "ID를 입력해주세요.";
                txtDuplicateCheckMsg.ForeColor = Color.Red;
                return; 
            }

            var userDto = new UserDto{ userId = txtUserId.Text };
            string json = JsonConvert.SerializeObject(userDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                btnUserIdCheck.Enabled = false;
                txtDuplicateCheckMsg.Text = "중복 체크 중...";
                txtDuplicateCheckMsg.ForeColor = Color.Black;

                String url = $"{Config.ServerUrl}/user/check-id";
                HttpResponseMessage response = await client.PostAsync(url, content);

                string responseMessage = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    if (responseMessage == "AVAILABLE")
                    {
                        txtDuplicateCheckMsg.Text = "사용 가능한 아이디 입니다.";
                        txtDuplicateCheckMsg.ForeColor = Color.Green;
                        isUserIdCheck = true;
                    }
                    else
                    {
                        txtDuplicateCheckMsg.Text = "이미 존재하는 아이디 입니다.";
                        txtDuplicateCheckMsg.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtDuplicateCheckMsg.Text = "중복 체크 실패. 다시 시도해주세요.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"중복체크 요청 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnUserIdCheck.Enabled = true;
            }
        }

        private async void btnJoinUser_Click(object sender, EventArgs e)
        {
            // 필수값 체크
            if (!isUserIdCheck) { MessageBox.Show("아이디 중복체크를 진행해 주세요."); return; }
            if (!isPasswordCheck) { MessageBox.Show("비밀번호를 확인해주세요."); return; }

            // 회원가입 데이터 준비
            var userDto = new UserDto
            {
                userId = txtUserId.Text,
                userPassword = txtUserPassword.Text,
                //joinDttm = DateTime.Now.ToString("yyyyMMddHHmmssSSS"),
                birthday = $"{cBoxYear.Text}{cBoxMonth.Text}{cBoxDay.Text}",
                phoneNo = maskTxtPhoneNo.Text,
                //authorityType = "common"
            };

            // JSON 직렬화
            string json = JsonConvert.SerializeObject(userDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // 서버 URL 설정
                string url = $"{Config.ServerUrl}/user/register";

                // 회원가입 요청 보내기
                HttpResponseMessage response = await client.PostAsync(url, content);

                // 응답 처리
                if (response.IsSuccessStatusCode)
                {
                    // 회원가입 성공 메시지
                    MessageBox.Show("회원가입이 완료되었습니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 폼 초기화 또는 다른 작업 수행
                    this.Close();
                }
                else
                {
                    // 회원가입 실패 시 서버에서 보낸 메시지 표시
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"회원가입 실패: {errorMessage}", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // 예외 발생 시 오류 메시지 표시
                MessageBox.Show($"회원가입 요청 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void txtUserPasswordCheck_TextChanged(object sender, EventArgs e)
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
            if(password1 == password2)
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

    }
}
