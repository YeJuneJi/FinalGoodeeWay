namespace GoodeeWay.BUS
{
    partial class ResourceManagemanet
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
            this.btnInventorySales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventorySales
            // 
            this.btnInventorySales.Location = new System.Drawing.Point(60, 304);
            this.btnInventorySales.Name = "btnInventorySales";
            this.btnInventorySales.Size = new System.Drawing.Size(75, 23);
            this.btnInventorySales.TabIndex = 0;
            this.btnInventorySales.Text = "재고별판매량";
            this.btnInventorySales.UseVisualStyleBackColor = true;
            this.btnInventorySales.Click += new System.EventHandler(this.btnInventorySales_Click);
            // 
            // ResourceManagemanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInventorySales);
            this.Name = "ResourceManagemanet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventorySales;
    }
}