
namespace board
{
    partial class BoardForm
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
            this.dataGridViewBoard = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBoardNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBoard
            // 
            this.dataGridViewBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoard.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewBoard.Name = "dataGridViewBoard";
            this.dataGridViewBoard.ReadOnly = true;
            this.dataGridViewBoard.RowTemplate.Height = 23;
            this.dataGridViewBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoard.Size = new System.Drawing.Size(776, 370);
            this.dataGridViewBoard.TabIndex = 0;
            this.dataGridViewBoard.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoard_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBoardNew
            // 
            this.btnBoardNew.Location = new System.Drawing.Point(12, 418);
            this.btnBoardNew.Name = "btnBoardNew";
            this.btnBoardNew.Size = new System.Drawing.Size(87, 23);
            this.btnBoardNew.TabIndex = 2;
            this.btnBoardNew.Text = "게시글 작성";
            this.btnBoardNew.UseVisualStyleBackColor = true;
            this.btnBoardNew.Click += new System.EventHandler(this.btnBoardNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "제목";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(48, 10);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(227, 21);
            this.txtTitleSearch.TabIndex = 4;
            this.txtTitleSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitleSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "작성일자";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(341, 10);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(171, 21);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(536, 10);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(171, 21);
            this.dtpEndDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "~";
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoardNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewBoard);
            this.Name = "BoardForm";
            this.Text = "게시판";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBoard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBoardNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
    }
}