﻿
namespace board.control
{
    partial class CommentControl
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.lblCommentDttm = new System.Windows.Forms.Label();
            this.btnCommentDelete = new System.Windows.Forms.Button();
            this.lblCommentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(5, 6);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(41, 12);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "작성자";
            // 
            // tBoxComment
            // 
            this.tBoxComment.Enabled = false;
            this.tBoxComment.Location = new System.Drawing.Point(7, 22);
            this.tBoxComment.Multiline = true;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(661, 31);
            this.tBoxComment.TabIndex = 1;
            this.tBoxComment.TextChanged += new System.EventHandler(this.tBoxComment_TextChanged);
            // 
            // lblCommentDttm
            // 
            this.lblCommentDttm.Location = new System.Drawing.Point(489, 7);
            this.lblCommentDttm.Name = "lblCommentDttm";
            this.lblCommentDttm.Size = new System.Drawing.Size(229, 12);
            this.lblCommentDttm.TabIndex = 2;
            this.lblCommentDttm.Text = "작성일자";
            this.lblCommentDttm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCommentDelete
            // 
            this.btnCommentDelete.Location = new System.Drawing.Point(673, 22);
            this.btnCommentDelete.Name = "btnCommentDelete";
            this.btnCommentDelete.Size = new System.Drawing.Size(43, 31);
            this.btnCommentDelete.TabIndex = 3;
            this.btnCommentDelete.Text = "삭제";
            this.btnCommentDelete.UseVisualStyleBackColor = true;
            this.btnCommentDelete.Click += new System.EventHandler(this.btnCommentDelete_Click);
            // 
            // lblCommentId
            // 
            this.lblCommentId.AutoSize = true;
            this.lblCommentId.Location = new System.Drawing.Point(313, 6);
            this.lblCommentId.Name = "lblCommentId";
            this.lblCommentId.Size = new System.Drawing.Size(68, 12);
            this.lblCommentId.TabIndex = 4;
            this.lblCommentId.Text = "commentId";
            this.lblCommentId.Visible = false;
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblCommentId);
            this.Controls.Add(this.btnCommentDelete);
            this.Controls.Add(this.lblCommentDttm);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.lblUserId);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(721, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Label lblCommentDttm;
        private System.Windows.Forms.Button btnCommentDelete;
        private System.Windows.Forms.Label lblCommentId;
    }
}
