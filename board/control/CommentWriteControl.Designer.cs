
namespace board.control
{
    partial class CommentWriteControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnCommentSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxComment
            // 
            this.tBoxComment.Location = new System.Drawing.Point(6, 21);
            this.tBoxComment.Multiline = true;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(684, 50);
            this.tBoxComment.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(4, 5);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(57, 12);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "댓글 작성";
            // 
            // btnCommentSave
            // 
            this.btnCommentSave.Location = new System.Drawing.Point(696, 21);
            this.btnCommentSave.Name = "btnCommentSave";
            this.btnCommentSave.Size = new System.Drawing.Size(75, 50);
            this.btnCommentSave.TabIndex = 5;
            this.btnCommentSave.Text = "등록";
            this.btnCommentSave.UseVisualStyleBackColor = true;
            this.btnCommentSave.Click += new System.EventHandler(this.btnCommentSave_Click);
            // 
            // CommentWriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnCommentSave);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.lblUserId);
            this.Name = "CommentWriteControl";
            this.Size = new System.Drawing.Size(774, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnCommentSave;
    }
}
