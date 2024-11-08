using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board.common
{
    public static class SessionHelper
    {
        public static void EnsureLoggedIn(Form currentForm)
        {
            if (!Session.IsLoggedIn)
            {
                currentForm.Hide(); // 현재 폼을 숨김
                LoginForm loginForm = new LoginForm();

                // 로그인 폼이 닫힐 때 처리할 작업 등록
                loginForm.FormClosed += (s, args) => {
                    if (Session.IsLoggedIn)
                    {
                        currentForm.Show(); // 로그인이 완료되었다면 현재 폼 다시 표시
                    }
                    else
                    {
                        currentForm.Close(); // 로그인하지 않으면 현재 폼을 닫음
                    }
                };

                loginForm.Show(); // 로그인 폼을 표시
            }
        }
    }
}
