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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InventorySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gbLastestDate = new System.Windows.Forms.GroupBox();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.rdoInventory = new System.Windows.Forms.RadioButton();
            this.rdoInventoryType = new System.Windows.Forms.RadioButton();
            this.panelImage = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbLastestDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImage)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventorySalesChart
            // 
            this.InventorySalesChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.Name = "ChartArea1";
            this.InventorySalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InventorySalesChart.Legends.Add(legend1);
            this.InventorySalesChart.Location = new System.Drawing.Point(23, 87);
            this.InventorySalesChart.Name = "InventorySalesChart";
            this.InventorySalesChart.Size = new System.Drawing.Size(846, 499);
            this.InventorySalesChart.TabIndex = 0;
            this.InventorySalesChart.Text = "chart1";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(914, 361);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(153, 23);
            this.cmbType.TabIndex = 12;
            this.cmbType.Text = "Bread";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(875, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "종류 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(356, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "기간 : ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblStartDate.Location = new System.Drawing.Point(407, 56);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 24);
            this.lblStartDate.TabIndex = 22;
            this.lblStartDate.Text = "시작 날짜";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(532, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "~";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblEndDate.Location = new System.Drawing.Point(568, 56);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(76, 24);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "종료 날짜";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1082, 414);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 169);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(877, 84);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(280, 268);
            this.dgvData.TabIndex = 29;
            // 
            // gbLastestDate
            // 
            this.gbLastestDate.Controls.Add(this.rdoYear);
            this.gbLastestDate.Controls.Add(this.rdoMonth);
            this.gbLastestDate.Controls.Add(this.button1);
            this.gbLastestDate.Controls.Add(this.button2);
            this.gbLastestDate.Controls.Add(this.button3);
            this.gbLastestDate.Controls.Add(this.label1);
            this.gbLastestDate.Controls.Add(this.btn1Year);
            this.gbLastestDate.Controls.Add(this.btn3Week);
            this.gbLastestDate.Controls.Add(this.btn2Week);
            this.gbLastestDate.Controls.Add(this.btn1Week);
            this.gbLastestDate.Controls.Add(this.btn3Year);
            this.gbLastestDate.Controls.Add(this.btn2Year);
            this.gbLastestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLastestDate.Location = new System.Drawing.Point(879, 441);
            this.gbLastestDate.Name = "gbLastestDate";
            this.gbLastestDate.Size = new System.Drawing.Size(188, 142);
            this.gbLastestDate.TabIndex = 34;
            this.gbLastestDate.TabStop = false;
            this.gbLastestDate.Text = "최근기간으로 설정";
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.ForeColor = System.Drawing.Color.DimGray;
            this.rdoYear.Location = new System.Drawing.Point(80, 115);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(61, 19);
            this.rdoYear.TabIndex = 36;
            this.rdoYear.Text = "연단위";
            this.rdoYear.UseVisualStyleBackColor = true;
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.BackColor = System.Drawing.Color.White;
            this.rdoMonth.Checked = true;
            this.rdoMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rdoMonth.ForeColor = System.Drawing.Color.DimGray;
            this.rdoMonth.ImageKey = "(없음)";
            this.rdoMonth.Location = new System.Drawing.Point(15, 115);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(61, 19);
            this.rdoMonth.TabIndex = 35;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "월단위";
            this.rdoMonth.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "3달";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "2달";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "1달";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "*종료 기준";
            // 
            // btn1Year
            // 
            this.btn1Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn1Year.FlatAppearance.BorderSize = 0;
            this.btn1Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Year.ForeColor = System.Drawing.Color.White;
            this.btn1Year.Location = new System.Drawing.Point(15, 71);
            this.btn1Year.Name = "btn1Year";
            this.btn1Year.Size = new System.Drawing.Size(50, 23);
            this.btn1Year.TabIndex = 2;
            this.btn1Year.Text = "1년";
            this.btn1Year.UseVisualStyleBackColor = false;
            this.btn1Year.Click += new System.EventHandler(this.btn1Year_Click);
            // 
            // btn3Week
            // 
            this.btn3Week.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn3Week.FlatAppearance.BorderSize = 0;
            this.btn3Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Week.ForeColor = System.Drawing.Color.White;
            this.btn3Week.Location = new System.Drawing.Point(123, 17);
            this.btn3Week.Name = "btn3Week";
            this.btn3Week.Size = new System.Drawing.Size(50, 23);
            this.btn3Week.TabIndex = 15;
            this.btn3Week.Text = "3주";
            this.btn3Week.UseVisualStyleBackColor = false;
            this.btn3Week.Click += new System.EventHandler(this.btn3Week_Click);
            // 
            // btn2Week
            // 
            this.btn2Week.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn2Week.FlatAppearance.BorderSize = 0;
            this.btn2Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Week.ForeColor = System.Drawing.Color.White;
            this.btn2Week.Location = new System.Drawing.Point(69, 17);
            this.btn2Week.Name = "btn2Week";
            this.btn2Week.Size = new System.Drawing.Size(50, 23);
            this.btn2Week.TabIndex = 14;
            this.btn2Week.Text = "2주";
            this.btn2Week.UseVisualStyleBackColor = false;
            this.btn2Week.Click += new System.EventHandler(this.btn2Week_Click);
            // 
            // btn1Week
            // 
            this.btn1Week.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn1Week.FlatAppearance.BorderSize = 0;
            this.btn1Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Week.ForeColor = System.Drawing.Color.White;
            this.btn1Week.Location = new System.Drawing.Point(15, 17);
            this.btn1Week.Name = "btn1Week";
            this.btn1Week.Size = new System.Drawing.Size(50, 23);
            this.btn1Week.TabIndex = 13;
            this.btn1Week.Text = "1주";
            this.btn1Week.UseVisualStyleBackColor = false;
            this.btn1Week.Click += new System.EventHandler(this.btn1Week_Click);
            // 
            // btn3Year
            // 
            this.btn3Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn3Year.FlatAppearance.BorderSize = 0;
            this.btn3Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Year.ForeColor = System.Drawing.Color.White;
            this.btn3Year.Location = new System.Drawing.Point(123, 71);
            this.btn3Year.Name = "btn3Year";
            this.btn3Year.Size = new System.Drawing.Size(50, 23);
            this.btn3Year.TabIndex = 10;
            this.btn3Year.Text = "3년";
            this.btn3Year.UseVisualStyleBackColor = false;
            this.btn3Year.Click += new System.EventHandler(this.btn3Year_Click);
            // 
            // btn2Year
            // 
            this.btn2Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn2Year.FlatAppearance.BorderSize = 0;
            this.btn2Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Year.ForeColor = System.Drawing.Color.White;
            this.btn2Year.Location = new System.Drawing.Point(69, 71);
            this.btn2Year.Name = "btn2Year";
            this.btn2Year.Size = new System.Drawing.Size(50, 23);
            this.btn2Year.TabIndex = 9;
            this.btn2Year.Text = "2년";
            this.btn2Year.UseVisualStyleBackColor = false;
            this.btn2Year.Click += new System.EventHandler(this.btn2Year_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(875, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "시작 :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(914, 387);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(153, 21);
            this.dtpStartDate.TabIndex = 30;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(914, 414);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(153, 21);
            this.dtpEndDate.TabIndex = 31;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(875, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "종료 :";
            // 
            // rdoInventory
            // 
            this.rdoInventory.AutoSize = true;
            this.rdoInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInventory.ForeColor = System.Drawing.Color.DimGray;
            this.rdoInventory.Location = new System.Drawing.Point(1082, 390);
            this.rdoInventory.Name = "rdoInventory";
            this.rdoInventory.Size = new System.Drawing.Size(73, 19);
            this.rdoInventory.TabIndex = 20;
            this.rdoInventory.Text = "재고기준";
            this.rdoInventory.UseVisualStyleBackColor = true;
            this.rdoInventory.CheckedChanged += new System.EventHandler(this.rdoInventory_CheckedChanged);
            // 
            // rdoInventoryType
            // 
            this.rdoInventoryType.AutoSize = true;
            this.rdoInventoryType.Checked = true;
            this.rdoInventoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInventoryType.ForeColor = System.Drawing.Color.DimGray;
            this.rdoInventoryType.Location = new System.Drawing.Point(1082, 364);
            this.rdoInventoryType.Name = "rdoInventoryType";
            this.rdoInventoryType.Size = new System.Drawing.Size(73, 19);
            this.rdoInventoryType.TabIndex = 19;
            this.rdoInventoryType.TabStop = true;
            this.rdoInventoryType.Text = "종류기준";
            this.rdoInventoryType.UseVisualStyleBackColor = true;
            this.rdoInventoryType.CheckedChanged += new System.EventHandler(this.rdoInventoryType_CheckedChanged);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.Image = global::GoodeeWay.Properties.Resources.GWMain2;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(232, 50);
            this.panelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelImage.TabIndex = 35;
            this.panelImage.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuPanel.Controls.Add(this.button4);
            this.MenuPanel.Controls.Add(this.panelImage);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1174, 50);
            this.MenuPanel.TabIndex = 36;
            this.MenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::GoodeeWay.Properties.Resources.Close_Window_64px1;
            this.button4.Location = new System.Drawing.Point(1127, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 50);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InventorySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 600);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.gbLastestDate);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventorySales";
            this.Text = "재고별 통계";
            ((System.ComponentModel.ISupportInitialize)(this.InventorySalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbLastestDate.ResumeLayout(false);
            this.gbLastestDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImage)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart InventorySalesChart;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox gbLastestDate;
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
        private System.Windows.Forms.RadioButton rdoInventory;
        private System.Windows.Forms.RadioButton rdoInventoryType;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.PictureBox panelImage;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button button4;
    }
}