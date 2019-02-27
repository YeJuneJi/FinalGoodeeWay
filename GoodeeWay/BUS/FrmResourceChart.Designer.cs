namespace GoodeeWay.BUS
{
    partial class FrmResourceChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTotalInvest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.movePanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalInvest)).BeginInit();
            this.movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalInvest
            // 
            this.chartTotalInvest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartTotalInvest.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalInvest.Legends.Add(legend2);
            this.chartTotalInvest.Location = new System.Drawing.Point(0, 51);
            this.chartTotalInvest.Name = "chartTotalInvest";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTotalInvest.Series.Add(series2);
            this.chartTotalInvest.Size = new System.Drawing.Size(742, 510);
            this.chartTotalInvest.TabIndex = 0;
            this.chartTotalInvest.Text = "TotInvestChart";
            this.chartTotalInvest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartTotalInvest_MouseMove);
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.movePanel.Controls.Add(this.btnClose);
            this.movePanel.Controls.Add(this.pbxImages);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(742, 52);
            this.movePanel.TabIndex = 18;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GoodeeWay.Properties.Resources.Cancel_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(700, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 91;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxImages
            // 
            this.pbxImages.BackColor = System.Drawing.Color.Transparent;
            this.pbxImages.Location = new System.Drawing.Point(0, 0);
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.Size = new System.Drawing.Size(176, 52);
            this.pbxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImages.TabIndex = 8;
            this.pbxImages.TabStop = false;
            // 
            // FrmResourceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 561);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.chartTotalInvest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResourceChart";
            this.Text = "FrmResourceChart";
            this.Load += new System.EventHandler(this.FrmResourceChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalInvest)).EndInit();
            this.movePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalInvest;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxImages;
    }
}