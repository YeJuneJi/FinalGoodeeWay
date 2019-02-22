namespace GoodeeWay.InventoryBUS
{
    partial class InventoryUseDetails
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
            this.dgvInventoryUseDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRealUseQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInventoryName = new System.Windows.Forms.Label();
            this.lblUseQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisposal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryUseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventoryUseDetails
            // 
            this.dgvInventoryUseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryUseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryUseDetails.Location = new System.Drawing.Point(12, 64);
            this.dgvInventoryUseDetails.Name = "dgvInventoryUseDetails";
            this.dgvInventoryUseDetails.RowTemplate.Height = 23;
            this.dgvInventoryUseDetails.Size = new System.Drawing.Size(393, 213);
            this.dgvInventoryUseDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "사용량";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRealUseQuantity
            // 
            this.txtRealUseQuantity.Location = new System.Drawing.Point(57, 37);
            this.txtRealUseQuantity.Name = "txtRealUseQuantity";
            this.txtRealUseQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtRealUseQuantity.TabIndex = 4;
            this.txtRealUseQuantity.Text = "0";
            this.txtRealUseQuantity.TextChanged += new System.EventHandler(this.txtInventoryQuantity_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "재고명";
            // 
            // lblInventoryName
            // 
            this.lblInventoryName.AutoSize = true;
            this.lblInventoryName.Location = new System.Drawing.Point(55, 9);
            this.lblInventoryName.Name = "lblInventoryName";
            this.lblInventoryName.Size = new System.Drawing.Size(17, 12);
            this.lblInventoryName.TabIndex = 7;
            this.lblInventoryName.Text = "명";
            // 
            // lblUseQuantity
            // 
            this.lblUseQuantity.AutoSize = true;
            this.lblUseQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblUseQuantity.Location = new System.Drawing.Point(319, 9);
            this.lblUseQuantity.Name = "lblUseQuantity";
            this.lblUseQuantity.Size = new System.Drawing.Size(0, 12);
            this.lblUseQuantity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "사용가능:";
            // 
            // btnDisposal
            // 
            this.btnDisposal.Location = new System.Drawing.Point(215, 36);
            this.btnDisposal.Name = "btnDisposal";
            this.btnDisposal.Size = new System.Drawing.Size(50, 23);
            this.btnDisposal.TabIndex = 10;
            this.btnDisposal.Text = "폐기";
            this.btnDisposal.UseVisualStyleBackColor = true;
            this.btnDisposal.Click += new System.EventHandler(this.btnDisposal_Click);
            // 
            // InventoryUseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 289);
            this.Controls.Add(this.btnDisposal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUseQuantity);
            this.Controls.Add(this.lblInventoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRealUseQuantity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventoryUseDetails);
            this.Name = "InventoryUseDetails";
            this.Text = "InventoryUseDetails";
            this.Load += new System.EventHandler(this.InventoryUseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryUseDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventoryUseDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRealUseQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInventoryName;
        private System.Windows.Forms.Label lblUseQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisposal;
    }
}