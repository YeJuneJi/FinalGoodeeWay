﻿namespace GoodeeWay.BUS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTotalInvest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalInvest)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalInvest
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalInvest.ChartAreas.Add(chartArea1);
            this.chartTotalInvest.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTotalInvest.Legends.Add(legend1);
            this.chartTotalInvest.Location = new System.Drawing.Point(0, 0);
            this.chartTotalInvest.Name = "chartTotalInvest";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTotalInvest.Series.Add(series1);
            this.chartTotalInvest.Size = new System.Drawing.Size(1784, 561);
            this.chartTotalInvest.TabIndex = 0;
            this.chartTotalInvest.Text = "TotInvestChart";
            this.chartTotalInvest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartTotalInvest_MouseMove);
            // 
            // FrmResourceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 561);
            this.Controls.Add(this.chartTotalInvest);
            this.Name = "FrmResourceChart";
            this.Text = "FrmResourceChart";
            this.Load += new System.EventHandler(this.FrmResourceChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalInvest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalInvest;
    }
}