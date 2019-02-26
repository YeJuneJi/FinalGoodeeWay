namespace GoodeeWay.BUS
{
    partial class Update_Attendance
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
            this.dtpTotaltime = new System.Windows.Forms.DateTimePicker();
            this.dtpOvertime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTotalpay = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpTotaltime
            // 
            this.dtpTotaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpTotaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotaltime.Location = new System.Drawing.Point(256, 135);
            this.dtpTotaltime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTotaltime.Name = "dtpTotaltime";
            this.dtpTotaltime.Size = new System.Drawing.Size(100, 21);
            this.dtpTotaltime.TabIndex = 175;
            // 
            // dtpOvertime
            // 
            this.dtpOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpOvertime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOvertime.Location = new System.Drawing.Point(76, 136);
            this.dtpOvertime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOvertime.Name = "dtpOvertime";
            this.dtpOvertime.Size = new System.Drawing.Size(100, 21);
            this.dtpOvertime.TabIndex = 174;
            this.dtpOvertime.Value = new System.DateTime(2019, 2, 19, 16, 26, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(338, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 173;
            this.label2.Text = "원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(217, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 171;
            this.label1.Text = "*일자";
            // 
            // dtpOut
            // 
            this.dtpOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOut.Location = new System.Drawing.Point(256, 174);
            this.dtpOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(100, 21);
            this.dtpOut.TabIndex = 170;
            this.dtpOut.Value = new System.DateTime(2019, 2, 19, 4, 26, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(256, 54);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 21);
            this.dtpDate.TabIndex = 169;
            this.dtpDate.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(223, 317);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 167;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(115, 317);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 40);
            this.btnInsert.TabIndex = 166;
            this.btnInsert.Text = "수정";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(79, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 16);
            this.label14.TabIndex = 165;
            this.label14.Text = "* 표시된 항목은 필수입력란입니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(193, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 155;
            this.label5.Text = "*급여";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 154;
            this.label3.Text = "초과시간";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(195, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 164;
            this.label13.Text = "*퇴근시간";
            // 
            // dtpIn
            // 
            this.dtpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIn.Location = new System.Drawing.Point(76, 174);
            this.dtpIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(100, 21);
            this.dtpIn.TabIndex = 163;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNote.Location = new System.Drawing.Point(76, 210);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(280, 62);
            this.txtNote.TabIndex = 162;
            // 
            // txtTotalpay
            // 
            this.txtTotalpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalpay.Location = new System.Drawing.Point(232, 93);
            this.txtTotalpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalpay.Name = "txtTotalpay";
            this.txtTotalpay.Size = new System.Drawing.Size(100, 21);
            this.txtTotalpay.TabIndex = 161;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmpno.Location = new System.Drawing.Point(76, 54);
            this.txtEmpno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.ReadOnly = true;
            this.txtEmpno.Size = new System.Drawing.Size(114, 21);
            this.txtEmpno.TabIndex = 160;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(43, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 159;
            this.label10.Text = "비고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 158;
            this.label7.Text = "*출근시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(210, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 157;
            this.label8.Text = "총 시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 156;
            this.label4.Text = "*사원번호";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtName.Location = new System.Drawing.Point(76, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 177;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(38, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 176;
            this.label6.Text = "*이름";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNo.Location = new System.Drawing.Point(76, 15);
            this.txtNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(111, 21);
            this.txtNo.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(14, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 178;
            this.label9.Text = "*일련번호";
            // 
            // Update_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 371);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTotaltime);
            this.Controls.Add(this.dtpOvertime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtTotalpay);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Name = "Update_Attendance";
            this.Text = "근태 수정";
            this.Load += new System.EventHandler(this.Update_Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTotaltime;
        private System.Windows.Forms.DateTimePicker dtpOvertime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTotalpay;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label9;
    }
}