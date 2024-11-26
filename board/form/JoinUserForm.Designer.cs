
namespace board
{
    partial class JoinUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPasswordCheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxYear = new System.Windows.Forms.ComboBox();
            this.cBoxMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxDay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUserIdCheck = new System.Windows.Forms.Button();
            this.txtDuplicateCheckMsg = new System.Windows.Forms.Label();
            this.maskTxtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPasswordCheckMsg = new System.Windows.Forms.Label();
            this.btnJoinUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 확인";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 16F);
            this.label3.Location = new System.Drawing.Point(84, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 16F);
            this.label4.Location = new System.Drawing.Point(158, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("굴림", 16F);
            this.txtUserId.Location = new System.Drawing.Point(107, 13);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(234, 32);
            this.txtUserId.TabIndex = 101;
            // 
            // txtUserPasswordCheck
            // 
            this.txtUserPasswordCheck.Font = new System.Drawing.Font("굴림", 16F);
            this.txtUserPasswordCheck.Location = new System.Drawing.Point(181, 89);
            this.txtUserPasswordCheck.Name = "txtUserPasswordCheck";
            this.txtUserPasswordCheck.PasswordChar = '●';
            this.txtUserPasswordCheck.Size = new System.Drawing.Size(234, 32);
            this.txtUserPasswordCheck.TabIndex = 103;
            this.txtUserPasswordCheck.TextChanged += new System.EventHandler(this.txtUserPasswordCheck_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16F);
            this.label5.Location = new System.Drawing.Point(117, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 16F);
            this.label6.Location = new System.Drawing.Point(13, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16F);
            this.label7.Location = new System.Drawing.Point(184, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "년";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 16F);
            this.label8.Location = new System.Drawing.Point(13, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "출생";
            // 
            // cBoxYear
            // 
            this.cBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxYear.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxYear.FormattingEnabled = true;
            this.cBoxYear.Location = new System.Drawing.Point(87, 167);
            this.cBoxYear.Name = "cBoxYear";
            this.cBoxYear.Size = new System.Drawing.Size(99, 29);
            this.cBoxYear.TabIndex = 107;
            // 
            // cBoxMonth
            // 
            this.cBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMonth.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxMonth.FormattingEnabled = true;
            this.cBoxMonth.Location = new System.Drawing.Point(222, 167);
            this.cBoxMonth.Name = "cBoxMonth";
            this.cBoxMonth.Size = new System.Drawing.Size(49, 29);
            this.cBoxMonth.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 16F);
            this.label9.Location = new System.Drawing.Point(269, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "월";
            // 
            // cBoxDay
            // 
            this.cBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDay.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxDay.FormattingEnabled = true;
            this.cBoxDay.Location = new System.Drawing.Point(316, 167);
            this.cBoxDay.Name = "cBoxDay";
            this.cBoxDay.Size = new System.Drawing.Size(50, 29);
            this.cBoxDay.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 16F);
            this.label10.Location = new System.Drawing.Point(364, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "일";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 16F);
            this.label11.Location = new System.Drawing.Point(65, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("굴림", 16F);
            this.txtUserPassword.Location = new System.Drawing.Point(181, 51);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '●';
            this.txtUserPassword.Size = new System.Drawing.Size(234, 32);
            this.txtUserPassword.TabIndex = 102;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 16F);
            this.label14.Location = new System.Drawing.Point(158, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 16F);
            this.label15.Location = new System.Drawing.Point(13, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 22;
            this.label15.Text = "비밀번호";
            // 
            // btnUserIdCheck
            // 
            this.btnUserIdCheck.Location = new System.Drawing.Point(347, 13);
            this.btnUserIdCheck.Name = "btnUserIdCheck";
            this.btnUserIdCheck.Size = new System.Drawing.Size(75, 32);
            this.btnUserIdCheck.TabIndex = 25;
            this.btnUserIdCheck.Text = "중복체크";
            this.btnUserIdCheck.UseVisualStyleBackColor = true;
            this.btnUserIdCheck.Click += new System.EventHandler(this.btnUserIdCheck_Click);
            // 
            // txtDuplicateCheckMsg
            // 
            this.txtDuplicateCheckMsg.AutoSize = true;
            this.txtDuplicateCheckMsg.Font = new System.Drawing.Font("굴림", 16F);
            this.txtDuplicateCheckMsg.Location = new System.Drawing.Point(428, 19);
            this.txtDuplicateCheckMsg.Name = "txtDuplicateCheckMsg";
            this.txtDuplicateCheckMsg.Size = new System.Drawing.Size(171, 22);
            this.txtDuplicateCheckMsg.TabIndex = 110;
            this.txtDuplicateCheckMsg.Text = "중복체크 메시지";
            // 
            // maskTxtPhoneNo
            // 
            this.maskTxtPhoneNo.Font = new System.Drawing.Font("굴림", 16F);
            this.maskTxtPhoneNo.Location = new System.Drawing.Point(139, 129);
            this.maskTxtPhoneNo.Mask = "000-0000-0000";
            this.maskTxtPhoneNo.Name = "maskTxtPhoneNo";
            this.maskTxtPhoneNo.PromptChar = ' ';
            this.maskTxtPhoneNo.Size = new System.Drawing.Size(182, 32);
            this.maskTxtPhoneNo.TabIndex = 104;
            this.maskTxtPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 16F);
            this.label12.Location = new System.Drawing.Point(327, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "숫자만 입력 가능합니다.";
            // 
            // txtPasswordCheckMsg
            // 
            this.txtPasswordCheckMsg.AutoSize = true;
            this.txtPasswordCheckMsg.Font = new System.Drawing.Font("굴림", 16F);
            this.txtPasswordCheckMsg.Location = new System.Drawing.Point(421, 92);
            this.txtPasswordCheckMsg.Name = "txtPasswordCheckMsg";
            this.txtPasswordCheckMsg.Size = new System.Drawing.Size(222, 22);
            this.txtPasswordCheckMsg.TabIndex = 112;
            this.txtPasswordCheckMsg.Text = "비밀번호 확인 메시지";
            // 
            // btnJoinUser
            // 
            this.btnJoinUser.Location = new System.Drawing.Point(17, 212);
            this.btnJoinUser.Name = "btnJoinUser";
            this.btnJoinUser.Size = new System.Drawing.Size(137, 31);
            this.btnJoinUser.TabIndex = 113;
            this.btnJoinUser.Text = "회원가입";
            this.btnJoinUser.UseVisualStyleBackColor = true;
            this.btnJoinUser.Click += new System.EventHandler(this.btnJoinUser_Click);
            // 
            // JoinUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 253);
            this.Controls.Add(this.btnJoinUser);
            this.Controls.Add(this.txtPasswordCheckMsg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskTxtPhoneNo);
            this.Controls.Add(this.txtDuplicateCheckMsg);
            this.Controls.Add(this.btnUserIdCheck);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBoxDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBoxMonth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserPasswordCheck);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JoinUserForm";
            this.Text = "JoinUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserPasswordCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxYear;
        private System.Windows.Forms.ComboBox cBoxMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUserIdCheck;
        private System.Windows.Forms.Label txtDuplicateCheckMsg;
        private System.Windows.Forms.MaskedTextBox maskTxtPhoneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtPasswordCheckMsg;
        private System.Windows.Forms.Button btnJoinUser;
    }
}