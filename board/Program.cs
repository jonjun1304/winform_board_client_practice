using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BoardForm());
            // 로그인 폼을 먼저 표시
            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // 로그인 성공 후 BoardForm을 실행
                    Application.Run(new BoardForm());
                }
            }
        }
    }
}
