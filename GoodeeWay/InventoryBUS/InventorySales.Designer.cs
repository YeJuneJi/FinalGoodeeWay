namespace GoodeeWay.InventoryBUS
{
    partial class InventorySales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InventorySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoInventoryType = new System.Windows.Forms.RadioButton();
            this.rdoInventory = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Year = new System.Windows.Forms.Button();
            this.btn3Week = new System.Windows.Forms.Button();
            this.btn2Week = new System.Windows.Forms.Button();
            this.btn1Week = new System.Windows.Forms.Button();
            this.btn3Year = new System.Windows.Forms.Button();
            this.btn2Year = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventorySalesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.InventorySalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InventorySalesChart.Legends.Add(legend1);
            this.InventorySalesChart.Location = new System.Drawing.Point(23, 37);
            this.InventorySalesChart.Name = "InventorySalesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.InventorySalesChart.Series.Add(series1);
            this.InventorySalesChart.Size = new System.Drawing.Size(846, 499);
            this.InventorySalesChart.TabIndex = 0;
            this.InventorySalesChart.Text = "chart1";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Bread",
            "Cheese",
            "Vegetable",
            "Sauce",
            "Additional",
            "Topping",
            "Side"});
            this.cmbType.Location = new System.Drawing.Point(914, 314);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(96, 20);
            this.cmbType.TabIndex = 12;
            this.cmbType.Text = "Bread";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "종류 :";
            // 
            // rdoInventoryType
            // 
            this.rdoInventoryType.AutoSize = true;
            this.rdoInventoryType.Checked = true;
            this.rdoInventoryType.Location = new System.Drawing.Point(1014, 317);
            this.rdoInventoryType.Name = "rdoInventoryType";
            this.rdoInventoryType.Size = new System.Drawing.Size(71, 16);
            this.rdoInventoryType.TabIndex = 19;
            this.rdoInventoryType.TabStop = true;
            this.rdoInventoryType.Text = "종류기준";
            this.rdoInventoryType.UseVisualStyleBackColor = true;
            // 
            // rdoInventory
            // 
            this.rdoInventory.AutoSize = true;
            this.rdoInventory.Location = new System.Drawing.Point(1089, 317);
            this.rdoInventory.Name = "rdoInventory";
            this.rdoInventory.Size = new System.Drawing.Size(71, 16);
            this.rdoInventory.TabIndex = 20;
            this.rdoInventory.Text = "재고기준";
            this.rdoInventory.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "기간 : ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(420, 14);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(57, 12);
            this.lblStartDate.TabIndex = 22;
            this.lblStartDate.Text = "시작 날짜";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "~";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(531, 14);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 12);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "종료 날짜";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1082, 339);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 201);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(877, 37);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(280, 268);
            this.dgvData.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn1Year);
            this.groupBox1.Controls.Add(this.btn3Week);
            this.groupBox1.Controls.Add(this.btn2Week);
            this.groupBox1.Controls.Add(this.btn1Week);
            this.groupBox1.Controls.Add(this.btn3Year);
            this.groupBox1.Controls.Add(this.btn2Year);
            this.groupBox1.Location = new System.Drawing.Point(879, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 143);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "최근기간으로 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "*종료 기준";
            // 
            // btn1Year
            // 
            this.btn1Year.Location = new System.Drawing.Point(15, 78);
            this.btn1Year.Name = "btn1Year";
            this.btn1Year.Size = new System.Drawing.Size(50, 23);
            this.btn1Year.TabIndex = 2;
            this.btn1Year.Text = "1년";
            this.btn1Year.UseVisualStyleBackColor = true;
            this.btn1Year.Click += new System.EventHandler(this.btn1Year_Click);
            // 
            // btn3Week
            // 
            this.btn3Week.Location = new System.Drawing.Point(123, 20);
            this.btn3Week.Name = "btn3Week";
            this.btn3Week.Size = new System.Drawing.Size(50, 23);
            this.btn3Week.TabIndex = 15;
            this.btn3Week.Text = "3주";
            this.btn3Week.UseVisualStyleBackColor = true;
            this.btn3Week.Click += new System.EventHandler(this.btn3Week_Click);
            // 
            // btn2Week
            // 
            this.btn2Week.Location = new System.Drawing.Point(69, 20);
            this.btn2Week.Name = "btn2Week";
            this.btn2Week.Size = new System.Drawing.Size(50, 23);
            this.btn2Week.TabIndex = 14;
            this.btn2Week.Text = "2주";
            this.btn2Week.UseVisualStyleBackColor = true;
            this.btn2Week.Click += new System.EventHandler(this.btn2Week_Click);
            // 
            // btn1Week
            // 
            this.btn1Week.Location = new System.Drawing.Point(15, 20);
            this.btn1Week.Name = "btn1Week";
            this.btn1Week.Size = new System.Drawing.Size(50, 23);
            this.btn1Week.TabIndex = 13;
            this.btn1Week.Text = "1주";
            this.btn1Week.UseVisualStyleBackColor = true;
            this.btn1Week.Click += new System.EventHandler(this.btn1Week_Click);
            // 
            // btn3Year
            // 
            this.btn3Year.Location = new System.Drawing.Point(123, 78);
            this.btn3Year.Name = "btn3Year";
            this.btn3Year.Size = new System.Drawing.Size(50, 23);
            this.btn3Year.TabIndex = 10;
            this.btn3Year.Text = "3년";
            this.btn3Year.UseVisualStyleBackColor = true;
            this.btn3Year.Click += new System.EventHandler(this.btn3Year_Click);
            // 
            // btn2Year
            // 
            this.btn2Year.Location = new System.Drawing.Point(69, 78);
            this.btn2Year.Name = "btn2Year";
            this.btn2Year.Size = new System.Drawing.Size(50, 23);
            this.btn2Year.TabIndex = 9;
            this.btn2Year.Text = "2년";
            this.btn2Year.UseVisualStyleBackColor = true;
            this.btn2Year.Click += new System.EventHandler(this.btn2Year_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "시작";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(910, 340);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 21);
            this.dtpStartDate.TabIndex = 30;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(910, 367);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 21);
            this.dtpEndDate.TabIndex = 31;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "종료";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "3달";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "2달";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "1달";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InventorySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoInventory);
            this.Controls.Add(this.rdoInventoryType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.InventorySalesChart);
            this.Name = "InventorySales";
            this.Text = "InventorySales";
            ((System.ComponentModel.ISupportInitialize)(this.InventorySalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart InventorySalesChart;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoInventoryType;
        private System.Windows.Forms.RadioButton rdoInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1Year;
        private System.Windows.Forms.Button btn3Week;
        private System.Windows.Forms.Button btn2Week;
        private System.Windows.Forms.Button btn1Week;
        private System.Windows.Forms.Button btn3Year;
        private System.Windows.Forms.Button btn2Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}