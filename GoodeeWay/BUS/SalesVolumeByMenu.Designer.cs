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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtSalesVolumeByDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtAllMenuPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtTopMenuPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesVolumeByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtAllMenuPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTopMenuPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // crtSalesVolumeByDate
            // 
            chartArea4.Name = "ChartArea1";
            this.crtSalesVolumeByDate.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.crtSalesVolumeByDate.Legends.Add(legend4);
            this.crtSalesVolumeByDate.Location = new System.Drawing.Point(55, 109);
            this.crtSalesVolumeByDate.Name = "crtSalesVolumeByDate";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.crtSalesVolumeByDate.Series.Add(series4);
            this.crtSalesVolumeByDate.Size = new System.Drawing.Size(761, 169);
            this.crtSalesVolumeByDate.TabIndex = 0;
            this.crtSalesVolumeByDate.Text = "chart1";
            // 
            // crtAllMenuPercent
            // 
            chartArea5.Name = "ChartArea1";
            this.crtAllMenuPercent.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.crtAllMenuPercent.Legends.Add(legend5);
            this.crtAllMenuPercent.Location = new System.Drawing.Point(55, 329);
            this.crtAllMenuPercent.Name = "crtAllMenuPercent";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.crtAllMenuPercent.Series.Add(series5);
            this.crtAllMenuPercent.Size = new System.Drawing.Size(253, 231);
            this.crtAllMenuPercent.TabIndex = 1;
            this.crtAllMenuPercent.Text = "chart2";
            // 
            // crtTopMenuPercent
            // 
            chartArea6.Name = "ChartArea1";
            this.crtTopMenuPercent.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.crtTopMenuPercent.Legends.Add(legend6);
            this.crtTopMenuPercent.Location = new System.Drawing.Point(363, 329);
            this.crtTopMenuPercent.Name = "crtTopMenuPercent";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.crtTopMenuPercent.Series.Add(series6);
            this.crtTopMenuPercent.Size = new System.Drawing.Size(253, 231);
            this.crtTopMenuPercent.TabIndex = 2;
            this.crtTopMenuPercent.Text = "chart3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(347, 70);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "~";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(121, 70);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "구매날짜";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "메뉴별 판메량";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(653, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(273, 228);
            this.textBox1.TabIndex = 33;
            // 
            // SalesVolumeByMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crtTopMenuPercent);
            this.Controls.Add(this.crtAllMenuPercent);
            this.Controls.Add(this.crtSalesVolumeByDate);
            this.Name = "SalesVolumeByMenu";
            this.Text = "SalesVolumeByMenu";
            this.Load += new System.EventHandler(this.SalesVolumeByMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesVolumeByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtAllMenuPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTopMenuPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtSalesVolumeByDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtAllMenuPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTopMenuPercent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}