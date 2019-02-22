namespace GoodeeWay.InventoryBUS
{
    partial class InventoryTypeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.txtReceivingQuantity = new System.Windows.Forms.TextBox();
            this.cmbClassification = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtInventoryTypeCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "재고명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입고정량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "재료구분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "재고종류코드";
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Location = new System.Drawing.Point(105, 14);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.Size = new System.Drawing.Size(100, 21);
            this.txtInventoryName.TabIndex = 1;
            // 
            // txtReceivingQuantity
            // 
            this.txtReceivingQuantity.Location = new System.Drawing.Point(105, 38);
            this.txtReceivingQuantity.Name = "txtReceivingQuantity";
            this.txtReceivingQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtReceivingQuantity.TabIndex = 2;
            this.txtReceivingQuantity.TextChanged += new System.EventHandler(this.txtReceivingQuantity_TextChanged);
            // 
            // cmbClassification
            // 
            this.cmbClassification.FormattingEnabled = true;
            this.cmbClassification.Items.AddRange(new object[] {
            "Bread",
            "Cheese",
            "Vegetable",
            "Sauce",
            "Additional",
            "Topping",
            "Side"});
            this.cmbClassification.Location = new System.Drawing.Point(105, 62);
            this.cmbClassification.Name = "cmbClassification";
            this.cmbClassification.Size = new System.Drawing.Size(100, 20);
            this.cmbClassification.TabIndex = 3;
            this.cmbClassification.Text = "Bread";
            this.cmbClassification.TextChanged += new System.EventHandler(this.cmbClassification_TextChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(24, 122);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "추가";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInventoryTypeCode
            // 
            this.txtInventoryTypeCode.Location = new System.Drawing.Point(105, 86);
            this.txtInventoryTypeCode.Name = "txtInventoryTypeCode";
            this.txtInventoryTypeCode.Size = new System.Drawing.Size(100, 21);
            this.txtInventoryTypeCode.TabIndex = 4;
            this.txtInventoryTypeCode.TextChanged += new System.EventHandler(this.txtInventoryTypeCode_TextChanged);
            // 
            // InventoryTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 158);
            this.Controls.Add(this.txtInventoryTypeCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.cmbClassification);
            this.Controls.Add(this.txtReceivingQuantity);
            this.Controls.Add(this.txtInventoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryTypeAdd";
            this.Text = "InventoryTypeAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.TextBox txtReceivingQuantity;
        private System.Windows.Forms.ComboBox cmbClassification;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInventoryTypeCode;
    }
}