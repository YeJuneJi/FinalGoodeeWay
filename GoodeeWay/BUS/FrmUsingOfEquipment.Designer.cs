namespace GoodeeWay.BUS
{
    partial class FrmUsingOfEquipment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crtEquipment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxDate = new System.Windows.Forms.Label();
            this.lblTotalExpenditure = new System.Windows.Forms.Label();
            this.lblMaxMonth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxYear = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtotalList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crtEquipment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalList)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // crtEquipment
            // 
            this.crtEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.crtEquipment.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtEquipment.Legends.Add(legend1);
            this.crtEquipment.Location = new System.Drawing.Point(10, 100);
            this.crtEquipment.Name = "crtEquipment";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            series1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtEquipment.Series.Add(series1);
            this.crtEquipment.Size = new System.Drawing.Size(803, 188);
            this.crtEquipment.TabIndex = 0;
            this.crtEquipment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crtEquipment_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(347, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "비품 구매 통계";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(406, 52);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "~";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(180, 52);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::GoodeeWay.Properties.Resources.Search_52px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(623, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 26;
            this.button1.Text = "            검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "지출 합계(일) :";
            // 
            // lblMaxDate
            // 
            this.lblMaxDate.AutoSize = true;
            this.lblMaxDate.Location = new System.Drawing.Point(142, 28);
            this.lblMaxDate.Name = "lblMaxDate";
            this.lblMaxDate.Size = new System.Drawing.Size(0, 17);
            this.lblMaxDate.TabIndex = 28;
            // 
            // lblTotalExpenditure
            // 
            this.lblTotalExpenditure.AutoSize = true;
            this.lblTotalExpenditure.Location = new System.Drawing.Point(568, 28);
            this.lblTotalExpenditure.Name = "lblTotalExpenditure";
            this.lblTotalExpenditure.Size = new System.Drawing.Size(0, 17);
            this.lblTotalExpenditure.TabIndex = 29;
            // 
            // lblMaxMonth
            // 
            this.lblMaxMonth.AutoSize = true;
            this.lblMaxMonth.Location = new System.Drawing.Point(142, 45);
            this.lblMaxMonth.Name = "lblMaxMonth";
            this.lblMaxMonth.Size = new System.Drawing.Size(0, 17);
            this.lblMaxMonth.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "총 지출액 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "(월) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "(년) :";
            // 
            // lblMaxYear
            // 
            this.lblMaxYear.AutoSize = true;
            this.lblMaxYear.Location = new System.Drawing.Point(142, 65);
            this.lblMaxYear.Name = "lblMaxYear";
            this.lblMaxYear.Size = new System.Drawing.Size(0, 17);
            this.lblMaxYear.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxYear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTotalExpenditure);
            this.groupBox1.Controls.Add(this.lblMaxMonth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMaxDate);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 88);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기간별 최대지출";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvtotalList
            // 
            this.dgvtotalList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtotalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtotalList.BackgroundColor = System.Drawing.Color.White;
            this.dgvtotalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtotalList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtotalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtotalList.ColumnHeadersHeight = 20;
            this.dgvtotalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtotalList.EnableHeadersVisualStyles = false;
            this.dgvtotalList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvtotalList.Location = new System.Drawing.Point(12, 403);
            this.dgvtotalList.Name = "dgvtotalList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtotalList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtotalList.RowHeadersVisible = false;
            this.dgvtotalList.RowHeadersWidth = 21;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvtotalList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtotalList.RowTemplate.Height = 23;
            this.dgvtotalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtotalList.Size = new System.Drawing.Size(801, 150);
            this.dgvtotalList.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(803, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.panel.Controls.Add(this.panelImage);
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(834, 36);
            this.panel.TabIndex = 37;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panelImage
            // 
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(154, 36);
            this.panelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelImage.TabIndex = 2;
            this.panelImage.TabStop = false;
            // 
            // FrmUsingOfEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(834, 554);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvtotalList);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.crtEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsingOfEquipment";
            this.Text = "FrmUsingOfEquipment";
            this.Load += new System.EventHandler(this.FrmUsingOfEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtEquipment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalList)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxDate;
        private System.Windows.Forms.Label lblTotalExpenditure;
        private System.Windows.Forms.Label lblMaxMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtotalList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox panelImage;
    }
}