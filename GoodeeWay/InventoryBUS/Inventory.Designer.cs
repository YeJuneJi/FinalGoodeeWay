namespace GoodeeWay
{
    partial class inventory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReturnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReceivingDetailsList = new System.Windows.Forms.DataGridView();
            this.btnLoadingFile = new System.Windows.Forms.Button();
            this.btnReceivingDetailsSave = new System.Windows.Forms.Button();
            this.dgvReceivingDetails = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnInventoryTypeAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInventoryNewTable = new System.Windows.Forms.Button();
            this.dgvInventoryTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventoryType = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetails)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 659);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReturnAdd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvReceivingDetailsList);
            this.tabPage1.Controls.Add(this.btnLoadingFile);
            this.tabPage1.Controls.Add(this.btnReceivingDetailsSave);
            this.tabPage1.Controls.Add(this.dgvReceivingDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "입고내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReturnAdd
            // 
            this.btnReturnAdd.Location = new System.Drawing.Point(821, 9);
            this.btnReturnAdd.Name = "btnReturnAdd";
            this.btnReturnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnReturnAdd.TabIndex = 3;
            this.btnReturnAdd.Text = "반품추가";
            this.btnReturnAdd.UseVisualStyleBackColor = true;
            this.btnReturnAdd.Click += new System.EventHandler(this.btnReturnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "입고내역 DetailView";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "입고내역 List";
            // 
            // dgvReceivingDetailsList
            // 
            this.dgvReceivingDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvReceivingDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivingDetailsList.Location = new System.Drawing.Point(12, 35);
            this.dgvReceivingDetailsList.Name = "dgvReceivingDetailsList";
            this.dgvReceivingDetailsList.RowTemplate.Height = 23;
            this.dgvReceivingDetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceivingDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetailsList.ShowEditingIcon = false;
            this.dgvReceivingDetailsList.Size = new System.Drawing.Size(125, 546);
            this.dgvReceivingDetailsList.TabIndex = 25;
            this.dgvReceivingDetailsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReceivingDetailsList_CellMouseDoubleClick);
            // 
            // btnLoadingFile
            // 
            this.btnLoadingFile.Location = new System.Drawing.Point(143, 587);
            this.btnLoadingFile.Name = "btnLoadingFile";
            this.btnLoadingFile.Size = new System.Drawing.Size(114, 40);
            this.btnLoadingFile.TabIndex = 24;
            this.btnLoadingFile.Text = "가져오기";
            this.btnLoadingFile.UseVisualStyleBackColor = true;
            this.btnLoadingFile.Click += new System.EventHandler(this.btnLoadingFile_Click);
            // 
            // btnReceivingDetailsSave
            // 
            this.btnReceivingDetailsSave.Location = new System.Drawing.Point(734, 587);
            this.btnReceivingDetailsSave.Name = "btnReceivingDetailsSave";
            this.btnReceivingDetailsSave.Size = new System.Drawing.Size(162, 40);
            this.btnReceivingDetailsSave.TabIndex = 20;
            this.btnReceivingDetailsSave.Text = "입고내역 적용";
            this.btnReceivingDetailsSave.UseVisualStyleBackColor = true;
            this.btnReceivingDetailsSave.Click += new System.EventHandler(this.btnReceivingDetailsSave_Click);
            // 
            // dgvReceivingDetails
            // 
            this.dgvReceivingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivingDetails.Location = new System.Drawing.Point(143, 35);
            this.dgvReceivingDetails.MultiSelect = false;
            this.dgvReceivingDetails.Name = "dgvReceivingDetails";
            this.dgvReceivingDetails.RowTemplate.Height = 23;
            this.dgvReceivingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetails.Size = new System.Drawing.Size(753, 546);
            this.dgvReceivingDetails.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.btnNewTable);
            this.tabPage3.Controls.Add(this.btnInventoryTypeAdd);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnInventoryNewTable);
            this.tabPage3.Controls.Add(this.dgvInventoryTable);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dgvInventoryType);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1080, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "재고내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(196, 15);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(65, 23);
            this.btnNewTable.TabIndex = 13;
            this.btnNewTable.Text = "새로고침";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // btnInventoryTypeAdd
            // 
            this.btnInventoryTypeAdd.Location = new System.Drawing.Point(267, 15);
            this.btnInventoryTypeAdd.Name = "btnInventoryTypeAdd";
            this.btnInventoryTypeAdd.Size = new System.Drawing.Size(59, 23);
            this.btnInventoryTypeAdd.TabIndex = 12;
            this.btnInventoryTypeAdd.Text = "추가";
            this.btnInventoryTypeAdd.UseVisualStyleBackColor = true;
            this.btnInventoryTypeAdd.Click += new System.EventHandler(this.btnInventoryTypeAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "제거";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "재고테이블";
            // 
            // btnInventoryNewTable
            // 
            this.btnInventoryNewTable.Location = new System.Drawing.Point(994, 15);
            this.btnInventoryNewTable.Name = "btnInventoryNewTable";
            this.btnInventoryNewTable.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryNewTable.TabIndex = 3;
            this.btnInventoryNewTable.Text = "업데이트";
            this.btnInventoryNewTable.UseVisualStyleBackColor = true;
            this.btnInventoryNewTable.Click += new System.EventHandler(this.btnInventoryNewTable_Click);
            // 
            // dgvInventoryTable
            // 
            this.dgvInventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryTable.Location = new System.Drawing.Point(462, 41);
            this.dgvInventoryTable.MultiSelect = false;
            this.dgvInventoryTable.Name = "dgvInventoryTable";
            this.dgvInventoryTable.RowTemplate.Height = 23;
            this.dgvInventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryTable.Size = new System.Drawing.Size(607, 589);
            this.dgvInventoryTable.TabIndex = 2;
            this.dgvInventoryTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventoryTable_CellMouseClick);
            this.dgvInventoryTable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvInventoryTable_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고종류";
            // 
            // dgvInventoryType
            // 
            this.dgvInventoryType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInventoryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryType.Location = new System.Drawing.Point(13, 41);
            this.dgvInventoryType.Name = "dgvInventoryType";
            this.dgvInventoryType.RowTemplate.Height = 23;
            this.dgvInventoryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryType.Size = new System.Drawing.Size(443, 589);
            this.dgvInventoryType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "발주내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(12, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(364, 575);
            this.tabControl2.TabIndex = 31;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(356, 549);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "현재 필요재고량";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(345, 537);
            this.dataGridView1.TabIndex = 8;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(356, 549);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "반품 및 재 발주내역";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(3, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(350, 537);
            this.dataGridView5.TabIndex = 29;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.Location = new System.Drawing.Point(382, 382);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 60);
            this.button12.TabIndex = 28;
            this.button12.Text = "전체\r\n←";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(380, 170);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 60);
            this.button13.TabIndex = 27;
            this.button13.Text = "전체\r\n→";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "발주내역";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(749, 587);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "excel추출";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "수정내용 적용";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(382, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(382, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(469, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(355, 543);
            this.dataGridView2.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 683);
            this.Controls.Add(this.tabControl1);
            this.Name = "inventory";
            this.Text = "Inventory";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetailsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetails)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLoadingFile;
        private System.Windows.Forms.Button btnReceivingDetailsSave;
        private System.Windows.Forms.DataGridView dgvReceivingDetails;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventoryNewTable;
        private System.Windows.Forms.DataGridView dgvInventoryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryType;
        private System.Windows.Forms.Button btnInventoryTypeAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReceivingDetailsList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnReturnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}