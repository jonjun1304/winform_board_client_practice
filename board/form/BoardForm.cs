﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using board.common;

namespace board
{
    public partial class BoardForm : Form
    {
        public BoardForm()
        {
            InitializeComponent();
            
            Load += BoardForm_Load; // 폼 로드 이벤트 등록
            Enter += BoardForm_Activated; // 폼 활성화 이벤트 등록
            
        }

        private async void BoardForm_Load(object sender, EventArgs e)
        {
            // DateTimePicker 초기값 설정 (처음 폼을 로드할 때만 설정)
            dtpStartDate.Value = DateTime.Today.AddMonths(-1); // 한 달 전
            dtpEndDate.Value = DateTime.Today; // 오늘

            // 로그인 상태라면 게시글 목록을 불러옴
            if (common.Session.IsLoggedIn)
            {
                await LoadBoardList();
            }
        }

        private async void BoardForm_Activated(object sender, EventArgs e)
        {
            // 로그인 상태라면 게시글 목록을 불러옴
            if (common.Session.IsLoggedIn)
            {
                await LoadBoardList();
            }
        }

        // 게시글 조회
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadBoardList();
        }

        // 게시글 목록 조회
        private async Task LoadBoardList()
        {
            Console.WriteLine("게시글 조회");
            string title = txtTitleSearch.Text;

            // DateTimePicker에서 사용자가 선택한 날짜 가져오기
            DateTime? fromDate = dtpStartDate.Value;
            DateTime? toDate = dtpEndDate.Value;

            // 날짜 선택 유효성 검사 (끝일이 시작일보다 빠른 경우 방지)
            if (fromDate > toDate)
            {
                MessageBox.Show("시작일은 끝일보다 이전이어야 합니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = "board";

            // 검색 조건 처리
            var queryParams = new List<string>();
            if (!string.IsNullOrEmpty(title))
            {
                queryParams.Add($"title={title}");
            }

            if (fromDate.HasValue && toDate.HasValue)
            {
                queryParams.Add($"fromDate={fromDate.Value:yyyyMMdd}");
                queryParams.Add($"toDate={toDate.Value:yyyyMMdd}");
            }

            if (queryParams.Any())
            {
                url += "?" + string.Join("&", queryParams);
            }

            //HttpResponseMessage response = await client.GetAsync(url);
            HttpResponseMessage response = await HttpClientManager.GetClient().GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var boards = JsonConvert.DeserializeObject<List<BoardDto>>(result);

                // DataGridView에 데이터 바인딩
                dataGridViewBoard.DataSource = boards;

                // 컬럼 헤더명 설정
                dataGridViewBoard.Columns["boardSeq"].HeaderText = "No.";
                dataGridViewBoard.Columns["boardTitle"].HeaderText = "제목";
                dataGridViewBoard.Columns["boardContent"].HeaderText = "내용";
                dataGridViewBoard.Columns["boardDttm"].HeaderText = "작성 날짜";
                dataGridViewBoard.Columns["userId"].HeaderText = "사용자 ID";
            }
            else
            {
                MessageBox.Show("게시글 목록을 불러오는 데 실패했습니다.");
            }
        }

        // BoardForm.cs (게시글 보기 폼)
        private async void dataGridViewBoard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 선택한 게시글의 ID 가져오기
                long boardSeq = (long)dataGridViewBoard.Rows[e.RowIndex].Cells["boardSeq"].Value;

                // 현재 폼을 숨기고 상세보기 폼을 모달로 열기
                //this.Hide();

                var detailForm = new BoardDetailForm(boardSeq);
                detailForm.ShowDialog(); // 모달로 폼을 열어 닫힐 때까지 대기

                // 상세보기 폼이 닫히면 목록을 새로 고침하고, 현재 폼을 다시 표시
                await LoadBoardList();
                //this.Show();
            }
        }

        private async void btnBoardNew_Click(object sender, EventArgs e)
        {
            //this.Hide(); // 현재 폼을 숨김

            var boardNewForm = new BoardNewForm();
            boardNewForm.ShowDialog(); // 모달로 폼을 보여줌, 닫힐 때까지 대기

            await LoadBoardList(); // 폼이 닫힌 후에 게시글 목록 새로 고침
            //this.Show(); // 목록 폼을 다시 나타냄
        }

        private async void txtTitleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoadBoardList();
                e.SuppressKeyPress = true; // Enter 키 입력이 다른 컨트롤에 전파되지 않도록 방지
            }
        }
    }


}
