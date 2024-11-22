using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
            InitializeUserMenu();
            //btnLogout.Click += BtnLogout_Click; // 로그아웃 버튼 클릭 이벤트 등록
            lblUsername.Click += LblUsername_Click;
        }

        private void InitializeUserMenu()
        {
            // ContextMenuStrip 초기화 및 항목 추가
            //userMenu = new ContextMenuStrip();

            // ContextMenuStrip 초기화 여부 확인
            if (userMenu == null)
            {
                userMenu = new ContextMenuStrip();
            }

            // 로그아웃 메뉴 항목 추가
            ToolStripMenuItem logoutItem = new ToolStripMenuItem("로그아웃");
            logoutItem.Click += BtnLogout_Click;
            userMenu.Items.Add(logoutItem);

            // 추후 다른 항목 추가 가능
            ToolStripMenuItem userUpdateItem = new ToolStripMenuItem("개인정보 수정");
            userUpdateItem.Click += BtnUserUpdate_Click;
            userMenu.Items.Add(userUpdateItem);
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {
            // 사용자명 클릭 시 ContextMenuStrip 열기
            userMenu.Show(lblUsername, new System.Drawing.Point(0, lblUsername.Height));
        }

        // 로그인된 사용자 이름을 설정하는 프로퍼티
        public string Username
        {
            get => lblUsername.Text;
            set => lblUsername.Text = value;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // 로그아웃 로직
            common.Session.UserId = null;
            Form currentForm = this.FindForm();
            if (currentForm != null)
            {
                currentForm.Hide(); // 현재 폼을 숨김
                LoginForm loginForm = new LoginForm();
                // 로그인 폼이 닫힐 때 처리할 작업 등록
                loginForm.FormClosed += (s, args) => {
                    if (common.Session.IsLoggedIn)
                    {
                        currentForm.Show(); // 로그인이 완료되었다면 현재 폼 다시 표시
                    }
                    else
                    {
                        currentForm.Close(); // 로그인하지 않으면 현재 폼을 닫음
                    }
                };
                loginForm.Show(); // 로그인 폼 표시
                
            }
        }

        private void BtnUserUpdate_Click(object sender, EventArgs e)
        {
            // 회원수정 로직
            Form currentForm = this.FindForm();
            if (currentForm != null)
            {
                currentForm.Hide(); // 현재 폼을 숨김
                UserUpdateForm userUpdateForm = new UserUpdateForm();
                // 로그인 폼이 닫힐 때 처리할 작업 등록
                userUpdateForm.FormClosed += (s, args) => {
                    if (common.Session.IsLoggedIn)
                    {
                        currentForm.Show(); // 로그인이 완료되었다면 현재 폼 다시 표시
                    }
                    else
                    {
                        currentForm.Close(); // 로그인하지 않으면 현재 폼을 닫음
                    }
                };
                userUpdateForm.Show(); // 로그인 폼 표시

            }
        }


    }
}
