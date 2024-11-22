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
    public partial class CommentControl : UserControl
    {
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
    }
}
