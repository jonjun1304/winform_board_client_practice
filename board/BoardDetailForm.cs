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
    public partial class BoardDetailForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private long boardSeq;
        private bool isEditMode = false; // 수정 모드 상태 관리 변수

        public BoardDetailForm(long boardSeq)
        {
            InitializeComponent();
            this.boardSeq = boardSeq;
            LoadBoardDetails();
        }

        private async void LoadBoardDetails()
        {
            HttpResponseMessage response = await client.GetAsync($"{Config.ServerUrl}/board/{boardSeq}");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var board = JsonConvert.DeserializeObject<BoardDto>(result);

                // 예시로 각 필드의 값을 텍스트박스나 라벨에 설정
                txtTitle.Text = board.boardTitle;
                txtContent.Text = board.boardContent;
                //lblDttm.Text = board.boardDttm;
                // 작성일자 변환

                try
                {
                    // 응답 데이터에서 날짜 부분만 추출 (앞의 14자리)
                    string dateString = board.boardDttm.Substring(0, 14);
                    DateTime parsedDate = DateTime.ParseExact(dateString, "yyyyMMddHHmmss", null);

                    // 원하는 형식으로 표시
                    lblDttm.Text = parsedDate.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
                }
                catch (FormatException)
                {
                    lblDttm.Text = "날짜 형식 오류";
                }
                lblUserId.Text = board.userId;
            }
            else
            {
                MessageBox.Show("게시글을 불러오는 데 실패했습니다.");
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // 수정 취소 기능 수행: 게시글 데이터를 다시 불러옴
                LoadBoardDetails();

                // 수정 모드 종료
                ExitEditMode();
            }
            else
            {
                // 삭제 기능 수행
                DeleteBoard();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                // 수정 모드로 전환
                EnterEditMode();
            }
            else
            {
                // 등록 (수정된 내용 서버로 전송)
                UpdateBoard();
            }
        }

        // 게시글 삭제 요청 메서드
        private async void DeleteBoard()
        {
            var result = MessageBox.Show("정말로 이 게시글을 삭제하시겠습니까?", "게시글 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync($"{Config.ServerUrl}/board/{boardSeq}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("게시글이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // 삭제 후 현재 폼을 닫음
                    }
                    else
                    {
                        MessageBox.Show("게시글 삭제에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"네트워크 오류가 발생했습니다: {ex.Message}", "네트워크 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"예기치 못한 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 게시글 수정 요청 메서드
        private async void UpdateBoard()
        {
            try
            {
                var boardDto = new BoardDto
                {
                    boardTitle = txtTitle.Text,
                    boardContent = txtContent.Text,
                };

                string json = JsonConvert.SerializeObject(boardDto);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"{Config.ServerUrl}/board/{boardSeq}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("게시글이 성공적으로 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 수정 완료 후 다시 읽기 모드로 전환
                    ExitEditMode();
                    LoadBoardDetails(); // 수정 완료 후 최신 데이터를 다시 로드하여 화면 갱신
                }
                else
                {
                    MessageBox.Show("게시글 수정에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"네트워크 오류가 발생했습니다: {ex.Message}", "네트워크 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 수정 모드 진입 메서드
        private void EnterEditMode()
        {
            btnEdit.Text = "등록";
            btnDelete.Text = "취소";
            txtTitle.ReadOnly = false;
            txtContent.ReadOnly = false;
            isEditMode = true;
        }

        // 수정 모드 종료 메서드
        private void ExitEditMode()
        {
            btnEdit.Text = "수정";
            btnDelete.Text = "삭제"; // 취소 버튼을 삭제 버튼으로 전환
            txtTitle.ReadOnly = true;
            txtContent.ReadOnly = true;
            isEditMode = false;
        }


    }
}
