namespace GoodeeWay.Sales
{
    partial class FrmSalesMenuSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ExcelSaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.movePanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuSearchGView)).BeginInit();
            this.movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxSearch.Location = new System.Drawing.Point(12, 92);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(605, 26);
            this.tbxSearch.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.BackgroundImage = global::GoodeeWay.Properties.Resources.Search_Black;
            this.btnResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResult.Location = new System.Drawing.Point(630, 83);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(45, 45);
            this.btnResult.TabIndex = 1;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // rdoMenuCode
            // 
            this.rdoMenuCode.AutoSize = true;
            this.rdoMenuCode.Checked = true;
            this.rdoMenuCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoMenuCode.Location = new System.Drawing.Point(27, 60);
            this.rdoMenuCode.Name = "rdoMenuCode";
            this.rdoMenuCode.Size = new System.Drawing.Size(75, 24);
            this.rdoMenuCode.TabIndex = 2;
            this.rdoMenuCode.TabStop = true;
            this.rdoMenuCode.Text = "메뉴코드";
            this.rdoMenuCode.UseVisualStyleBackColor = true;
            // 
            // rdoMenuName
            // 
            this.rdoMenuName.AutoSize = true;
            this.rdoMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoMenuName.Location = new System.Drawing.Point(125, 60);
            this.rdoMenuName.Name = "rdoMenuName";
            this.rdoMenuName.Size = new System.Drawing.Size(63, 24);
            this.rdoMenuName.TabIndex = 3;
            this.rdoMenuName.Text = "메뉴명";
            this.rdoMenuName.UseVisualStyleBackColor = true;
            // 
            // rdoAdditional
            // 
            this.rdoAdditional.AutoSize = true;
            this.rdoAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoAdditional.Location = new System.Drawing.Point(212, 60);
            this.rdoAdditional.Name = "rdoAdditional";
            this.rdoAdditional.Size = new System.Drawing.Size(75, 24);
            this.rdoAdditional.TabIndex = 4;
            this.rdoAdditional.Text = "부가설명";
            this.rdoAdditional.UseVisualStyleBackColor = true;
            // 
            // menuSearchGView
            // 
            this.menuSearchGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuSearchGView.BackgroundColor = System.Drawing.Color.White;
            this.menuSearchGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.menuSearchGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuSearchGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuSearchGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuSearchGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.menuSearchGView.EnableHeadersVisualStyles = false;
            this.menuSearchGView.Location = new System.Drawing.Point(14, 158);
            this.menuSearchGView.Name = "menuSearchGView";
            this.menuSearchGView.ReadOnly = true;
            this.menuSearchGView.RowHeadersVisible = false;
            this.menuSearchGView.RowTemplate.Height = 23;
            this.menuSearchGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuSearchGView.Size = new System.Drawing.Size(712, 327);
            this.menuSearchGView.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 12);
            this.lblTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(320, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "구분 : ";
            // 
            // cbxDivision
            // 
            this.cbxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxDivision.FormattingEnabled = true;
            this.cbxDivision.Location = new System.Drawing.Point(362, 58);
            this.cbxDivision.Name = "cbxDivision";
            this.cbxDivision.Size = new System.Drawing.Size(121, 28);
            this.cbxDivision.TabIndex = 8;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackgroundImage = global::GoodeeWay.Properties.Resources.Excel_Black_64px;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcel.Location = new System.Drawing.Point(681, 83);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(45, 45);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // ExcelSaveFileDlg
            // 
            this.ExcelSaveFileDlg.Filter = "xls 파일|*.xls";
            this.ExcelSaveFileDlg.OverwritePrompt = false;
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.movePanel.Controls.Add(this.btnClose);
            this.movePanel.Controls.Add(this.pbxImages);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(733, 52);
            this.movePanel.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(691, 7);
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
            // FrmSalesMenuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 512);
            this.Controls.Add(this.movePanel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalesMenuSearch";
            this.Text = "메뉴 검색";
            this.Load += new System.EventHandler(this.SalesMenuSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuSearchGView)).EndInit();
            this.movePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
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
        private System.Windows.Forms.SaveFileDialog ExcelSaveFileDlg;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.PictureBox pbxImages;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}