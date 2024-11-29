using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board.mdi
{
    public partial class TabControlForm : Form
    {
        public TabControlForm()
        {
            InitializeComponent();

            Activated += Form_Activated;

            // 디자이너에서 생성된 tabControl 설정 및 이벤트 추가
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.SizeMode = TabSizeMode.Fixed; // 탭 크기를 텍스트 길이에 맞게 설정
            tabControl.ItemSize = new Size(120, 25); // 탭 크기 조정

            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            // 기본 탭 및 + 탭 추가
            AddNewTab();
            AddPlusTab();

        }

        private void Form_Activated(object sender, EventArgs e)
        {
            // 로그인 상태 확인 (공통 메서드 사용)
            Console.WriteLine("check");
            common.SessionHelper.EnsureLoggedIn(this);
        }


        private void AddNewTab()
        {
            // BoardForm 인스턴스 생성
            var childForm = new BoardForm
            {
                TopLevel = false, // 컨트롤처럼 동작하도록 설정
                Dock = DockStyle.Fill, // 탭 페이지에 맞게 채움
                FormBorderStyle = FormBorderStyle.None, // 테두리 제거
            };

            var tabPage = new TabPage(childForm.Text)
            {
                Name = Guid.NewGuid().ToString(), // 고유 이름
            };

            // TabPage에 ChildForm 추가
            tabPage.Controls.Add(childForm);
            childForm.Show();

            // + 버튼 탭이 있는 경우 + 버튼 앞에 삽입
            if (tabControl.TabPages.Count > 0 && tabControl.TabPages[tabControl.TabPages.Count - 1].Name == "PlusTab")
            {
                tabControl.TabPages.Insert(tabControl.TabPages.Count - 1, tabPage);
            }
            else
            {
                // + 버튼이 없거나 탭이 비어 있는 경우
                tabControl.TabPages.Add(tabPage);
            }

            tabControl.SelectedTab = tabPage; // 새 탭으로 이동
        }



        private void AddPlusTab()
        {
            var plusTab = new TabPage("+")
            {
                Name = "PlusTab",
            };
            tabControl.TabPages.Add(plusTab);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // e.Index 값이 TabPages 범위 내에 있는지 확인
            if (e.Index >= tabControl.TabPages.Count || e.Index < 0)
            {
                return; // 잘못된 인덱스는 무시
            }

            var tabPage = tabControl.TabPages[e.Index];
            var tabRect = tabControl.GetTabRect(e.Index);

            // + 탭 커스터마이징
            if (tabPage.Name == "PlusTab")
            {
                e.Graphics.FillRectangle(Brushes.LightGray, tabRect); // 배경
                e.Graphics.DrawString("새 탭 추가 +", Font, Brushes.Black, tabRect.X + tabRect.Width / 2 - 45, tabRect.Y + 5);
            }
            else
            {
                // 일반 탭
                e.Graphics.FillRectangle(Brushes.White, tabRect);
                e.Graphics.DrawString(tabPage.Text, Font, Brushes.Black, tabRect.X + 5, tabRect.Y + 5);
                e.Graphics.DrawString("X", Font, Brushes.Red, tabRect.Right - 15, tabRect.Y + 5);
            }
        }




        private void TabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                var tabRect = tabControl.GetTabRect(i);

                // 닫기 버튼 위치 확인
                var closeButton = new Rectangle(tabRect.Right - 20, tabRect.Top + 5, 15, 15);
                if (closeButton.Contains(e.Location) && tabControl.TabPages[i].Name != "PlusTab")
                {
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }

                // + 탭 클릭 시 새 탭 추가
                if (tabControl.TabPages[i].Name == "PlusTab" && tabRect.Contains(e.Location))
                {
                    AddNewTab();
                    break;
                }
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // + 탭 선택 시 바로 새 탭 추가
            if (tabControl.SelectedTab?.Name == "PlusTab")
            {
                AddNewTab();
            }
        }




    }
}
