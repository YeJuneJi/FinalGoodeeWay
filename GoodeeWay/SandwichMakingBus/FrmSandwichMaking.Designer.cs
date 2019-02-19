namespace GoodeeWay.SandwichMakingBus
{
    partial class FrmSandwichMaking
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewING = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewING)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSB
            // 
            this.dataGridViewSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSB.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewSB.Name = "dataGridViewSB";
            this.dataGridViewSB.RowTemplate.Height = 23;
            this.dataGridViewSB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSB.Size = new System.Drawing.Size(1171, 232);
            this.dataGridViewSB.TabIndex = 0;
            this.dataGridViewSB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "제조현황";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(995, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 12);
            this.lblTime.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewING
            // 
            this.dataGridViewING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewING.Location = new System.Drawing.Point(12, 311);
            this.dataGridViewING.Name = "dataGridViewING";
            this.dataGridViewING.RowTemplate.Height = 23;
            this.dataGridViewING.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewING.Size = new System.Drawing.Size(1171, 233);
            this.dataGridViewING.TabIndex = 4;
            this.dataGridViewING.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewING_CellContentClick);
            // 
            // FrmSandwichMaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 565);
            this.Controls.Add(this.dataGridViewING);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSB);
            this.Name = "FrmSandwichMaking";
            this.Text = "FrmSandwichMaking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSandwichMaking_FormClosed);
            this.Load += new System.EventHandler(this.FrmSandwichMaking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewING)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewING;
    }
}