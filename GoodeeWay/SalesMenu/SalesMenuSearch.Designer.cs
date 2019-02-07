namespace GoodeeWay.SalesMenu
{
    partial class SalesMenuSearch
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.rdoMenuCode = new System.Windows.Forms.RadioButton();
            this.rdoMenuName = new System.Windows.Forms.RadioButton();
            this.rdoAdditional = new System.Windows.Forms.RadioButton();
            this.menuSearchGView = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDivision = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuSearchGView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 63);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(605, 21);
            this.tbxSearch.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(631, 61);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "검색";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // rdoMenuCode
            // 
            this.rdoMenuCode.AutoSize = true;
            this.rdoMenuCode.Checked = true;
            this.rdoMenuCode.Location = new System.Drawing.Point(32, 26);
            this.rdoMenuCode.Name = "rdoMenuCode";
            this.rdoMenuCode.Size = new System.Drawing.Size(71, 16);
            this.rdoMenuCode.TabIndex = 2;
            this.rdoMenuCode.TabStop = true;
            this.rdoMenuCode.Text = "메뉴코드";
            this.rdoMenuCode.UseVisualStyleBackColor = true;
            // 
            // rdoMenuName
            // 
            this.rdoMenuName.AutoSize = true;
            this.rdoMenuName.Location = new System.Drawing.Point(130, 26);
            this.rdoMenuName.Name = "rdoMenuName";
            this.rdoMenuName.Size = new System.Drawing.Size(59, 16);
            this.rdoMenuName.TabIndex = 3;
            this.rdoMenuName.Text = "메뉴명";
            this.rdoMenuName.UseVisualStyleBackColor = true;
            // 
            // rdoAdditional
            // 
            this.rdoAdditional.AutoSize = true;
            this.rdoAdditional.Location = new System.Drawing.Point(217, 26);
            this.rdoAdditional.Name = "rdoAdditional";
            this.rdoAdditional.Size = new System.Drawing.Size(71, 16);
            this.rdoAdditional.TabIndex = 4;
            this.rdoAdditional.Text = "부가설명";
            this.rdoAdditional.UseVisualStyleBackColor = true;
            // 
            // menuSearchGView
            // 
            this.menuSearchGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuSearchGView.Location = new System.Drawing.Point(12, 122);
            this.menuSearchGView.Name = "menuSearchGView";
            this.menuSearchGView.ReadOnly = true;
            this.menuSearchGView.RowTemplate.Height = 23;
            this.menuSearchGView.Size = new System.Drawing.Size(691, 327);
            this.menuSearchGView.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 12);
            this.lblTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "구분 : ";
            // 
            // cbxDivision
            // 
            this.cbxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDivision.FormattingEnabled = true;
            this.cbxDivision.Location = new System.Drawing.Point(367, 24);
            this.cbxDivision.Name = "cbxDivision";
            this.cbxDivision.Size = new System.Drawing.Size(121, 20);
            this.cbxDivision.TabIndex = 8;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(542, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "엑셀 저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // SalesMenuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 461);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbxDivision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.menuSearchGView);
            this.Controls.Add(this.rdoAdditional);
            this.Controls.Add(this.rdoMenuName);
            this.Controls.Add(this.rdoMenuCode);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbxSearch);
            this.Name = "SalesMenuSearch";
            this.Text = "메뉴 검색";
            this.Load += new System.EventHandler(this.SalesMenuSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuSearchGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RadioButton rdoMenuCode;
        private System.Windows.Forms.RadioButton rdoMenuName;
        private System.Windows.Forms.RadioButton rdoAdditional;
        private System.Windows.Forms.DataGridView menuSearchGView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDivision;
        private System.Windows.Forms.Button btnExcel;
    }
}