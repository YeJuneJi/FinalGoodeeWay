namespace GoodeeWay.BUS
{
    partial class SalesVolumeByMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtSalesVolumeByDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtAllMenuPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSoda = new System.Windows.Forms.RadioButton();
            this.rbSide = new System.Windows.Forms.RadioButton();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbSandwich = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesVolumeByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtAllMenuPercent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // crtSalesVolumeByDate
            // 
            chartArea3.Name = "ChartArea1";
            this.crtSalesVolumeByDate.ChartAreas.Add(chartArea3);
            this.crtSalesVolumeByDate.Location = new System.Drawing.Point(55, 130);
            this.crtSalesVolumeByDate.Name = "crtSalesVolumeByDate";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.crtSalesVolumeByDate.Series.Add(series3);
            this.crtSalesVolumeByDate.Size = new System.Drawing.Size(840, 151);
            this.crtSalesVolumeByDate.TabIndex = 0;
            this.crtSalesVolumeByDate.Text = "chart1";
            // 
            // crtAllMenuPercent
            // 
            chartArea4.Name = "ChartArea1";
            this.crtAllMenuPercent.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.crtAllMenuPercent.Legends.Add(legend2);
            this.crtAllMenuPercent.Location = new System.Drawing.Point(55, 323);
            this.crtAllMenuPercent.Name = "crtAllMenuPercent";
            series4.ChartArea = "ChartArea1";
            series4.LabelFormat = "00%";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.crtAllMenuPercent.Series.Add(series4);
            this.crtAllMenuPercent.Size = new System.Drawing.Size(460, 260);
            this.crtAllMenuPercent.TabIndex = 1;
            this.crtAllMenuPercent.Text = "chart2";
            this.crtAllMenuPercent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crtAllMenuPercent_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼매직체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "메뉴별 판매량";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(55, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(91, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "기간별 메뉴 판매량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(91, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "메뉴별 판매순위(TOP 5)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(55, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbSoda);
            this.groupBox1.Controls.Add(this.rbSide);
            this.groupBox1.Controls.Add(this.rbSalad);
            this.groupBox1.Controls.Add(this.rbSandwich);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(55, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 55);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "종류 :";
            // 
            // rbSoda
            // 
            this.rbSoda.AutoSize = true;
            this.rbSoda.Location = new System.Drawing.Point(270, 11);
            this.rbSoda.Name = "rbSoda";
            this.rbSoda.Size = new System.Drawing.Size(47, 16);
            this.rbSoda.TabIndex = 52;
            this.rbSoda.Text = "음료";
            this.rbSoda.UseVisualStyleBackColor = true;
            // 
            // rbSide
            // 
            this.rbSide.AutoSize = true;
            this.rbSide.Location = new System.Drawing.Point(205, 11);
            this.rbSide.Name = "rbSide";
            this.rbSide.Size = new System.Drawing.Size(59, 16);
            this.rbSide.TabIndex = 51;
            this.rbSide.Text = "사이드";
            this.rbSide.UseVisualStyleBackColor = true;
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(128, 11);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(71, 16);
            this.rbSalad.TabIndex = 50;
            this.rbSalad.Text = "찹샐러드";
            this.rbSalad.UseVisualStyleBackColor = true;
            // 
            // rbSandwich
            // 
            this.rbSandwich.AutoSize = true;
            this.rbSandwich.Checked = true;
            this.rbSandwich.Location = new System.Drawing.Point(51, 12);
            this.rbSandwich.Name = "rbSandwich";
            this.rbSandwich.Size = new System.Drawing.Size(71, 16);
            this.rbSandwich.TabIndex = 49;
            this.rbSandwich.TabStop = true;
            this.rbSandwich.Text = "샌드위치";
            this.rbSandwich.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(483, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(277, 33);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "~";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(51, 33);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "기간 : ";
            // 
            // dgvRank
            // 
            this.dgvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRank.Location = new System.Drawing.Point(557, 323);
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.ReadOnly = true;
            this.dgvRank.RowTemplate.Height = 23;
            this.dgvRank.Size = new System.Drawing.Size(338, 251);
            this.dgvRank.TabIndex = 45;
            // 
            // SalesVolumeByMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(955, 586);
            this.Controls.Add(this.dgvRank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtAllMenuPercent);
            this.Controls.Add(this.crtSalesVolumeByDate);
            this.Name = "SalesVolumeByMenu";
            this.Text = "SalesVolumeByMenu";
            this.Load += new System.EventHandler(this.SalesVolumeByMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesVolumeByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtAllMenuPercent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtSalesVolumeByDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtAllMenuPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSoda;
        private System.Windows.Forms.RadioButton rbSide;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbSandwich;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRank;
    }
}