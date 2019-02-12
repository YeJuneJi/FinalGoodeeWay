namespace GoodeeWay.InventoryBUS
{
    partial class ReceivingDetailsReturn
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoReturn = new System.Windows.Forms.RadioButton();
            this.rdoExchange = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 128);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(96, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "입고명";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(94, 11);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(38, 12);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "반품수량";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(94, 44);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(52, 21);
            this.txtItemQuantity.TabIndex = 6;
            this.txtItemQuantity.TextChanged += new System.EventHandler(this.txtItemQuantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "반품종류";
            // 
            // rdoReturn
            // 
            this.rdoReturn.AutoSize = true;
            this.rdoReturn.Checked = true;
            this.rdoReturn.Location = new System.Drawing.Point(94, 84);
            this.rdoReturn.Name = "rdoReturn";
            this.rdoReturn.Size = new System.Drawing.Size(47, 16);
            this.rdoReturn.TabIndex = 8;
            this.rdoReturn.TabStop = true;
            this.rdoReturn.Text = "반품";
            this.rdoReturn.UseVisualStyleBackColor = true;
            // 
            // rdoExchange
            // 
            this.rdoExchange.AutoSize = true;
            this.rdoExchange.Location = new System.Drawing.Point(94, 106);
            this.rdoExchange.Name = "rdoExchange";
            this.rdoExchange.Size = new System.Drawing.Size(47, 16);
            this.rdoExchange.TabIndex = 9;
            this.rdoExchange.Text = "교환";
            this.rdoExchange.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(85, 69);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 12);
            this.lbl.TabIndex = 10;
            // 
            // ReceivingDetailsReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 163);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.rdoExchange);
            this.Controls.Add(this.rdoReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Name = "ReceivingDetailsReturn";
            this.Text = "ReceivingDetailsReturn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoReturn;
        private System.Windows.Forms.RadioButton rdoExchange;
        private System.Windows.Forms.Label lbl;
    }
}