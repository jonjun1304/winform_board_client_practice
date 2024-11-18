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
        private String userId;
        private HttpClient client = new HttpClient();
        private bool isPasswordCheck = false;

        public UserUpdateForm(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            Load += JoinUserForm_Load;
        }

        private async void JoinUserForm_Load(object sender, EventArgs e)
        {
            formInitializer();

            try
            {
                String url = $"{Config.ServerUrl}/user/check-id";
                //HttpResponseMessage response = await client.GetAsync(url, userId);
            }
            catch(Exception ex)
            {

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

    }
}
