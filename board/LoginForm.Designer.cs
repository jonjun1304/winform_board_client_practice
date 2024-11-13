
namespace board
{
    partial class LoginForm
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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelLoginMsg = new System.Windows.Forms.Label();
            this.btnJoinUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(105, 12);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(156, 21);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID               : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD : ";
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(105, 47);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(156, 21);
            this.UserPassword.TabIndex = 3;
            this.UserPassword.UseSystemPasswordChar = true;
            this.UserPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(267, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 56);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // labelLoginMsg
            // 
            this.labelLoginMsg.AutoSize = true;
            this.labelLoginMsg.Location = new System.Drawing.Point(13, 88);
            this.labelLoginMsg.Name = "labelLoginMsg";
            this.labelLoginMsg.Size = new System.Drawing.Size(121, 12);
            this.labelLoginMsg.TabIndex = 6;
            this.labelLoginMsg.Text = "로그인이 필요합니다.";
            // 
            // btnJoinUser
            // 
            this.btnJoinUser.Location = new System.Drawing.Point(267, 74);
            this.btnJoinUser.Name = "btnJoinUser";
            this.btnJoinUser.Size = new System.Drawing.Size(118, 33);
            this.btnJoinUser.TabIndex = 7;
            this.btnJoinUser.Text = "회원가입";
            this.btnJoinUser.UseVisualStyleBackColor = true;
            this.btnJoinUser.Click += new System.EventHandler(this.btnJoinUser_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 119);
            this.Controls.Add(this.btnJoinUser);
            this.Controls.Add(this.labelLoginMsg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserId);
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserId; // 사용자 아이디
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserPassword; // 사용자 비밀번호
        private System.Windows.Forms.Button btnLogin; // 로그인 실행 버튼
        private System.Windows.Forms.Label labelLoginMsg; // 로그인 안내 메시지
        private System.Windows.Forms.Button btnJoinUser;
    }
}