namespace GoodeeWay.BUS
{
    partial class Insert_Attendance
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTotalpay = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOvertime = new System.Windows.Forms.DateTimePicker();
            this.dtpTotaltime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(186, 333);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 144;
            this.btnClear.Text = "다시작성";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(267, 333);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 143;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(105, 333);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 40);
            this.btnInsert.TabIndex = 142;
            this.btnInsert.Text = "저장";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(80, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 16);
            this.label14.TabIndex = 139;
            this.label14.Text = "* 표시된 항목은 필수입력란입니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(39, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "*급여";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "초과시간";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(196, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 138;
            this.label13.Text = "*퇴근시간";
            // 
            // dtpIn
            // 
            this.dtpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIn.Location = new System.Drawing.Point(77, 188);
            this.dtpIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(100, 21);
            this.dtpIn.TabIndex = 137;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNote.Location = new System.Drawing.Point(77, 224);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(280, 62);
            this.txtNote.TabIndex = 136;
            // 
            // txtTotalpay
            // 
            this.txtTotalpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalpay.Location = new System.Drawing.Point(77, 109);
            this.txtTotalpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalpay.Name = "txtTotalpay";
            this.txtTotalpay.Size = new System.Drawing.Size(100, 21);
            this.txtTotalpay.TabIndex = 133;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDepartment.Location = new System.Drawing.Point(257, 109);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 21);
            this.txtDepartment.TabIndex = 131;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmpno.Location = new System.Drawing.Point(77, 68);
            this.txtEmpno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(148, 21);
            this.txtEmpno.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(44, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 129;
            this.label10.Text = "비고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(15, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "*출근시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(211, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 125;
            this.label8.Text = "총 시간";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(224, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 124;
            this.label9.Text = "부서";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 123;
            this.label4.Text = "*사원번호";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(77, 30);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 21);
            this.dtpDate.TabIndex = 145;
            // 
            // dtpOut
            // 
            this.dtpOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOut.Location = new System.Drawing.Point(257, 188);
            this.dtpOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(100, 21);
            this.dtpOut.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 147;
            this.label1.Text = "*일자";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(231, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 25);
            this.btnSearch.TabIndex = 148;
            this.btnSearch.Text = "사원번호 검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(183, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 149;
            this.label2.Text = "원";
            // 
            // dtpOvertime
            // 
            this.dtpOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpOvertime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOvertime.Location = new System.Drawing.Point(77, 150);
            this.dtpOvertime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOvertime.Name = "dtpOvertime";
            this.dtpOvertime.Size = new System.Drawing.Size(100, 21);
            this.dtpOvertime.TabIndex = 152;
            // 
            // dtpTotaltime
            // 
            this.dtpTotaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpTotaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotaltime.Location = new System.Drawing.Point(257, 149);
            this.dtpTotaltime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTotaltime.Name = "dtpTotaltime";
            this.dtpTotaltime.Size = new System.Drawing.Size(100, 21);
            this.dtpTotaltime.TabIndex = 153;
            // 
            // Insert_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 384);
            this.Controls.Add(this.dtpTotaltime);
            this.Controls.Add(this.dtpOvertime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtTotalpay);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Name = "Insert_Attendance";
            this.Text = "근태 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTotalpay;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOvertime;
        private System.Windows.Forms.DateTimePicker dtpTotaltime;
    }
}