
namespace board
{
    partial class UserUpdateForm
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
            this.txtPasswordCheckMsg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskTxtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxDay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPasswordCheck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordCheckMsg
            // 
            this.txtPasswordCheckMsg.AutoSize = true;
            this.txtPasswordCheckMsg.Font = new System.Drawing.Font("굴림", 16F);
            this.txtPasswordCheckMsg.Location = new System.Drawing.Point(422, 53);
            this.txtPasswordCheckMsg.Name = "txtPasswordCheckMsg";
            this.txtPasswordCheckMsg.Size = new System.Drawing.Size(222, 22);
            this.txtPasswordCheckMsg.TabIndex = 131;
            this.txtPasswordCheckMsg.Text = "비밀번호 확인 메시지";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 16F);
            this.label12.Location = new System.Drawing.Point(328, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 22);
            this.label12.TabIndex = 130;
            this.label12.Text = "숫자만 입력 가능합니다.";
            // 
            // maskTxtPhoneNo
            // 
            this.maskTxtPhoneNo.Font = new System.Drawing.Font("굴림", 16F);
            this.maskTxtPhoneNo.Location = new System.Drawing.Point(140, 90);
            this.maskTxtPhoneNo.Mask = "000-0000-0000";
            this.maskTxtPhoneNo.Name = "maskTxtPhoneNo";
            this.maskTxtPhoneNo.PromptChar = ' ';
            this.maskTxtPhoneNo.Size = new System.Drawing.Size(182, 32);
            this.maskTxtPhoneNo.TabIndex = 126;
            this.maskTxtPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("굴림", 16F);
            this.txtUserPassword.Location = new System.Drawing.Point(182, 12);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '●';
            this.txtUserPassword.Size = new System.Drawing.Size(234, 32);
            this.txtUserPassword.TabIndex = 124;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 16F);
            this.label14.Location = new System.Drawing.Point(159, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 22);
            this.label14.TabIndex = 123;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 16F);
            this.label15.Location = new System.Drawing.Point(14, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 122;
            this.label15.Text = "비밀번호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 16F);
            this.label11.Location = new System.Drawing.Point(66, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 22);
            this.label11.TabIndex = 121;
            this.label11.Text = ":";
            // 
            // cBoxDay
            // 
            this.cBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDay.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxDay.FormattingEnabled = true;
            this.cBoxDay.Location = new System.Drawing.Point(317, 128);
            this.cBoxDay.Name = "cBoxDay";
            this.cBoxDay.Size = new System.Drawing.Size(50, 29);
            this.cBoxDay.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 16F);
            this.label10.Location = new System.Drawing.Point(365, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 120;
            this.label10.Text = "일";
            // 
            // cBoxMonth
            // 
            this.cBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMonth.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxMonth.FormattingEnabled = true;
            this.cBoxMonth.Location = new System.Drawing.Point(223, 128);
            this.cBoxMonth.Name = "cBoxMonth";
            this.cBoxMonth.Size = new System.Drawing.Size(49, 29);
            this.cBoxMonth.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 16F);
            this.label9.Location = new System.Drawing.Point(270, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 22);
            this.label9.TabIndex = 119;
            this.label9.Text = "월";
            // 
            // cBoxYear
            // 
            this.cBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxYear.Font = new System.Drawing.Font("굴림", 16F);
            this.cBoxYear.FormattingEnabled = true;
            this.cBoxYear.Location = new System.Drawing.Point(88, 128);
            this.cBoxYear.Name = "cBoxYear";
            this.cBoxYear.Size = new System.Drawing.Size(99, 29);
            this.cBoxYear.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16F);
            this.label7.Location = new System.Drawing.Point(185, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 118;
            this.label7.Text = "년";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 16F);
            this.label8.Location = new System.Drawing.Point(14, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 117;
            this.label8.Text = "출생";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16F);
            this.label5.Location = new System.Drawing.Point(118, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 116;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 16F);
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Phone No.";
            // 
            // txtUserPasswordCheck
            // 
            this.txtUserPasswordCheck.Font = new System.Drawing.Font("굴림", 16F);
            this.txtUserPasswordCheck.Location = new System.Drawing.Point(182, 50);
            this.txtUserPasswordCheck.Name = "txtUserPasswordCheck";
            this.txtUserPasswordCheck.PasswordChar = '●';
            this.txtUserPasswordCheck.Size = new System.Drawing.Size(234, 32);
            this.txtUserPasswordCheck.TabIndex = 125;
            this.txtUserPasswordCheck.TextChanged += new System.EventHandler(this.txtUserPasswordCheck_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 16F);
            this.label4.Location = new System.Drawing.Point(159, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 22);
            this.label4.TabIndex = 114;
            this.label4.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 113;
            this.label2.Text = "비밀번호 확인";
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(18, 169);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(94, 33);
            this.btnUserUpdate.TabIndex = 132;
            this.btnUserUpdate.Text = "수정하기";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 213);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.txtPasswordCheckMsg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskTxtPhoneNo);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "UserUpdateForm";
            this.Text = "회원 정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPasswordCheckMsg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskTxtPhoneNo;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBoxMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserPasswordCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUserUpdate;
    }
}