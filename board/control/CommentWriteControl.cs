using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board.control
{
    public partial class CommentWriteControl : UserControl
    {
        // 댓글 저장 이벤트 선언
        public event EventHandler CommentSaved;

        public CommentWriteControl()
        {
            InitializeComponent();
        }

        private void btnCommentSave_Click(object sender, EventArgs e)
        {
            string commentText = tBoxComment.Text.Trim();

            if (string.IsNullOrWhiteSpace(commentText))
            {
                MessageBox.Show("댓글을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 댓글 저장 이벤트 호출
            CommentSaved?.Invoke(this, EventArgs.Empty);

            // 입력 필드 초기화
            tBoxComment.Text = string.Empty;
        }

        // 댓글 텍스트 프로퍼티
        public string CommentText
        {
            get => tBoxComment.Text.Trim();
            set => tBoxComment.Text = value;
        }
    }
}
