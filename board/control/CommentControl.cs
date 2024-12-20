﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using board.dto;

namespace board.control
{
    public partial class CommentControl : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        public event EventHandler CommentDelete;

        public CommentControl()
        {
            InitializeComponent();
        }

        // 작성자 ID
        public string userId
        {
            get => lblUserId.Text;
            set => lblUserId.Text = value;
        }

        // 댓글 내용
        public string commentText
        {
            get => tBoxComment.Text;
            set => tBoxComment.Text = value;
        }

        // 작성일자
        public string commentDate
        {
            get => lblCommentDttm.Text;
            set => lblCommentDttm.Text = value;
        }

        public string commentId
        {
            get => lblCommentId.Text;
            set => lblCommentId.Text = value;
        }

        private void tBoxComment_TextChanged(object sender, EventArgs e)
        {
            using (Graphics g = tBoxComment.CreateGraphics())
            {
                // 텍스트 크기 계산
                SizeF size = g.MeasureString(tBoxComment.Text, tBoxComment.Font, tBoxComment.Width);

                // 텍스트 크기에 따라 높이 조정
                int newHeight = (int)size.Height + 10; // 여백 추가
                tBoxComment.Height = Math.Max(newHeight, tBoxComment.MinimumSize.Height);
            }

        }

        private async void btnCommentDelete_Click(object sender, EventArgs e)
        {
            // 댓글 삭제 -> 삭제는 되는데 댓글 목록 갱신X 삭제 메서드를 상세보기 폼에서 구현을 해야하나 아니면... 흠..
            var result = MessageBox.Show("정말로 이 댓글을 삭제하시겠습니까?", "댓글 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                // 이벤트 대리자 호출?
                CommentDelete?.Invoke(this, EventArgs.Empty);
            }

        }
    }
}
