
namespace board
{
    partial class BoardDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDttm = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.commentWriteControl = new board.control.CommentWriteControl();
            this.SuspendLayout();
            // 
            // lblDttm
            // 
            this.lblDttm.AutoSize = true;
            this.lblDttm.Location = new System.Drawing.Point(603, 9);
            this.lblDttm.Name = "lblDttm";
            this.lblDttm.Size = new System.Drawing.Size(29, 12);
            this.lblDttm.TabIndex = 2;
            this.lblDttm.Text = "dttm";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(500, 9);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(40, 12);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "userId";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(14, 35);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(774, 380);
            this.txtContent.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 421);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(14, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(462, 21);
            this.txtTitle.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // commentPanel
            // 
            this.commentPanel.AutoSize = true;
            this.commentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commentPanel.Location = new System.Drawing.Point(14, 532);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(0, 0);
            this.commentPanel.TabIndex = 15;
            // 
            // commentWriteControl
            // 
            this.commentWriteControl.AutoSize = true;
            this.commentWriteControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commentWriteControl.CommentText = "";
            this.commentWriteControl.Location = new System.Drawing.Point(14, 450);
            this.commentWriteControl.Name = "commentWriteControl";
            this.commentWriteControl.Size = new System.Drawing.Size(774, 74);
            this.commentWriteControl.TabIndex = 16;
            // 
            // BoardDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(841, 596);
            this.Controls.Add(this.commentWriteControl);
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblDttm);
            this.Name = "BoardDetailForm";
            this.Text = "BoardDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDttm;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel commentPanel;
        private control.CommentWriteControl commentWriteControl;
    }
}