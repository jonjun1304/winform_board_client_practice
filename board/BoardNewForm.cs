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
    public partial class BoardNewForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public BoardNewForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var boardDto = new
            {
                boardTitle = txtTitle.Text,
                boardContent = txtContent.Text,
                //boardDttm = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                userId = "admin" // 테스트용 사용자 ID
            };

            string json = JsonConvert.SerializeObject(boardDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"{Config.ServerUrl}/board/new", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("게시글이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("게시글 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
