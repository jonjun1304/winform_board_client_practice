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
using board.dto;
using board.control;
using board.common;

namespace board
{
    public partial class BoardDetailForm : Form
    {
        
        private long boardSeq;
        private bool isEditMode = false; // 수정 모드 상태 관리 변수

        public BoardDetailForm(long boardSeq)
        {
            InitializeComponent();
            this.boardSeq = boardSeq;
            Load += BoardDetailForm_Load;
            //LoadBoardDetails();
        }

        private void BoardDetailForm_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            // 게시글 상세 정보 로드
            LoadBoardDetails();

            // 댓글 작성 컨트롤 추가
            AddCommentWriteControl();

            // 댓글 리스트 로드
            LoadComments();
        }

        private async void LoadBoardDetails()
        {

            HttpResponseMessage response = await HttpClientManager.GetClient().GetAsync($"board/{boardSeq}");

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

                // 작성자
                lblUserId.Text = board.userId;

                // 수정 삭제 버튼 권한 체크
                if (common.Session.AuthorityType == "admin" || common.Session.UserId == board.userId)
                {
                    btnEdit.Visible = true;
                    btnDelete.Visible = true;
                }
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
                    HttpResponseMessage response = await HttpClientManager.GetClient().DeleteAsync($"board/{boardSeq}");

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

                HttpResponseMessage response = await HttpClientManager.GetClient().PutAsync($"board/{boardSeq}", content);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadComments()
        {
            commentPanel.Controls.Clear(); // 기존 댓글 제거

            try
            {
                HttpResponseMessage response = await HttpClientManager.GetClient().GetAsync($"comment/{boardSeq}");

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var comments = JsonConvert.DeserializeObject<List<CommentDto>>(result);

                    int yOffset = 0; // 댓글 컨트롤의 Y 위치 조정
                    foreach (var comment in comments)
                    {
                        // 응답 데이터에서 날짜 부분만 추출 (앞의 14자리)
                        string dateString = comment.commentDttm.Substring(0, 14);
                        DateTime parsedDate = DateTime.ParseExact(dateString, "yyyyMMddHHmmss", null);

                        var commentControl = new CommentControl
                        {
                            //Dock = DockStyle.Top,
                            // 댓글 데이터를 CommentControl에 전달
                            commentId = comment.commentId,
                            userId = comment.userId,
                            commentText = comment.commentContent,
                            commentDate = parsedDate.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초")
                    };

                        commentControl.Location = new Point(0, yOffset);
                        commentPanel.Controls.Add(commentControl);
                        yOffset += commentControl.Height + 5; // 다음 댓글 위치

                        commentControl.CommentDelete += async (s, e) =>
                        {
                            // 여기에 댓글 삭제시 로직 작성하면 될 듯?
                            if(Session.UserId == comment.userId || Session.AuthorityType == "admin")
                            {
                                await DeleteComment(comment.commentId);
                            }
                            else
                            {
                                MessageBox.Show("댓글 작성자만 삭제가 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        };
                    }
                }
                else
                {
                    MessageBox.Show("댓글 데이터를 불러오는 데 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"댓글 로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCommentWriteControl()
        {
            /*var commentWriteControl = new CommentWriteControl
            {
                Dock = DockStyle.Top
            };*/

            // 댓글 작성 이벤트 처리
            commentWriteControl.CommentSaved += async (s, e) =>
            {
                await SaveComment(commentWriteControl.CommentText);
                commentWriteControl.CommentText = string.Empty; // 입력 필드 초기화
                LoadComments(); // 댓글 리스트 새로고침
            };

            //this.Controls.Add(commentWriteControl);
        }

        private async Task SaveComment(string content)
        {
            try
            {
                var commentDto = new CommentDto
                {
                    boardSeq = this.boardSeq,
                    userId = common.Session.UserId,
                    commentContent = content
                };

                string json = JsonConvert.SerializeObject(commentDto);
                StringContent HttpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClientManager.GetClient().PostAsync("comment", HttpContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("댓글이 성공적으로 추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("댓글 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"댓글 저장 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteComment(string commentId)
        {
            try
            {
                HttpResponseMessage response = await HttpClientManager.GetClient().DeleteAsync($"comment/{commentId}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("댓글이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComments(); // 삭제 성공시 댓글 목록 다시 조회
                }
                else
                {
                    MessageBox.Show("댓글 삭제에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
