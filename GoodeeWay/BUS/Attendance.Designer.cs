namespace GoodeeWay.BUS
{
    partial class Attendance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(972, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(266, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 21);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 21);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "~";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "신규";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalCount.Location = new System.Drawing.Point(898, 299);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(86, 15);
            this.lblTotalCount.TabIndex = 101;
            this.lblTotalCount.Text = "현재 인원 : 0명";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 107;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(174, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 108;
            this.button4.Text = "새로고침";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Attendance_Load);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(488, 304);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(14, 15);
            this.lblFirst.TabIndex = 115;
            this.lblFirst.Text = "1";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(521, 304);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(14, 15);
            this.lblLast.TabIndex = 114;
            this.lblLast.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 113;
            this.label2.Text = "/";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(544, 299);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 23);
            this.btnNext.TabIndex = 112;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(583, 299);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(33, 23);
            this.btnLast.TabIndex = 111;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(410, 299);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(33, 23);
            this.btnFirst.TabIndex = 110;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(449, 299);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(33, 23);
            this.btnPrev.TabIndex = 109;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(444, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 116;
            this.label3.Text = "근태기록";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcel.Location = new System.Drawing.Point(901, 48);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 117;
            this.btnExcel.Text = "엑셀로 저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 341);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Attendance";
            this.Text = "근태기록";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcel;
    }
}