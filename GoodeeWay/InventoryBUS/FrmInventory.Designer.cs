namespace GoodeeWay.InventoryBUS
{
    partial class FrmInventory
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRelease = new System.Windows.Forms.Button();
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveOrderDetails = new System.Windows.Forms.Button();
            this.dgvOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnOrderDisplay = new System.Windows.Forms.Button();
            this.dgvNeedInventoryDetailView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetails)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedInventoryDetailView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 725);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
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
            this.tabPage1.Size = new System.Drawing.Size(1192, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "입고내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReturnAdd
            // 
            this.btnReturnAdd.Location = new System.Drawing.Point(833, 9);
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
            this.dgvReceivingDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetailsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceivingDetailsList.Location = new System.Drawing.Point(12, 35);
            this.dgvReceivingDetailsList.Name = "dgvReceivingDetailsList";
            this.dgvReceivingDetailsList.ReadOnly = true;
            this.dgvReceivingDetailsList.RowTemplate.Height = 23;
            this.dgvReceivingDetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceivingDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetailsList.ShowEditingIcon = false;
            this.dgvReceivingDetailsList.Size = new System.Drawing.Size(125, 543);
            this.dgvReceivingDetailsList.TabIndex = 25;
            this.dgvReceivingDetailsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReceivingDetailsList_CellMouseDoubleClick);
            // 
            // btnLoadingFile
            // 
            this.btnLoadingFile.Location = new System.Drawing.Point(143, 584);
            this.btnLoadingFile.Name = "btnLoadingFile";
            this.btnLoadingFile.Size = new System.Drawing.Size(114, 40);
            this.btnLoadingFile.TabIndex = 24;
            this.btnLoadingFile.Text = "가져오기";
            this.btnLoadingFile.UseVisualStyleBackColor = true;
            this.btnLoadingFile.Click += new System.EventHandler(this.btnLoadingFile_Click);
            // 
            // btnReceivingDetailsSave
            // 
            this.btnReceivingDetailsSave.Location = new System.Drawing.Point(746, 584);
            this.btnReceivingDetailsSave.Name = "btnReceivingDetailsSave";
            this.btnReceivingDetailsSave.Size = new System.Drawing.Size(162, 40);
            this.btnReceivingDetailsSave.TabIndex = 20;
            this.btnReceivingDetailsSave.Text = "입고내역 저장";
            this.btnReceivingDetailsSave.UseVisualStyleBackColor = true;
            this.btnReceivingDetailsSave.Click += new System.EventHandler(this.btnReceivingDetailsSave_Click);
            // 
            // dgvReceivingDetails
            // 
            this.dgvReceivingDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceivingDetails.Location = new System.Drawing.Point(143, 35);
            this.dgvReceivingDetails.MultiSelect = false;
            this.dgvReceivingDetails.Name = "dgvReceivingDetails";
            this.dgvReceivingDetails.ReadOnly = true;
            this.dgvReceivingDetails.RowTemplate.Height = 23;
            this.dgvReceivingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetails.Size = new System.Drawing.Size(765, 543);
            this.dgvReceivingDetails.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRelease);
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
            this.tabPage3.Size = new System.Drawing.Size(1192, 699);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "재고내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(1010, 9);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(98, 23);
            this.btnRelease.TabIndex = 15;
            this.btnRelease.Text = "재고사용내역";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(399, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(263, 9);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(65, 23);
            this.btnNewTable.TabIndex = 13;
            this.btnNewTable.Text = "새로고침";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // btnInventoryTypeAdd
            // 
            this.btnInventoryTypeAdd.Location = new System.Drawing.Point(334, 9);
            this.btnInventoryTypeAdd.Name = "btnInventoryTypeAdd";
            this.btnInventoryTypeAdd.Size = new System.Drawing.Size(59, 23);
            this.btnInventoryTypeAdd.TabIndex = 12;
            this.btnInventoryTypeAdd.Text = "추가";
            this.btnInventoryTypeAdd.UseVisualStyleBackColor = true;
            this.btnInventoryTypeAdd.Click += new System.EventHandler(this.btnInventoryTypeAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(464, 9);
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
            this.label3.Location = new System.Drawing.Point(527, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "재고테이블";
            // 
            // btnInventoryNewTable
            // 
            this.btnInventoryNewTable.Location = new System.Drawing.Point(1114, 9);
            this.btnInventoryNewTable.Name = "btnInventoryNewTable";
            this.btnInventoryNewTable.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryNewTable.TabIndex = 3;
            this.btnInventoryNewTable.Text = "업데이트";
            this.btnInventoryNewTable.UseVisualStyleBackColor = true;
            this.btnInventoryNewTable.Click += new System.EventHandler(this.btnInventoryNewTable_Click);
            // 
            // dgvInventoryTable
            // 
            this.dgvInventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryTable.Location = new System.Drawing.Point(529, 35);
            this.dgvInventoryTable.MultiSelect = false;
            this.dgvInventoryTable.Name = "dgvInventoryTable";
            this.dgvInventoryTable.ReadOnly = true;
            this.dgvInventoryTable.RowTemplate.Height = 23;
            this.dgvInventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryTable.Size = new System.Drawing.Size(660, 543);
            this.dgvInventoryTable.TabIndex = 2;
            this.dgvInventoryTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventoryTable_CellMouseClick);
            this.dgvInventoryTable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvInventoryTable_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고종류";
            // 
            // dgvInventoryType
            // 
            this.dgvInventoryType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryType.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventoryType.Location = new System.Drawing.Point(12, 35);
            this.dgvInventoryType.MultiSelect = false;
            this.dgvInventoryType.Name = "dgvInventoryType";
            this.dgvInventoryType.RowTemplate.Height = 23;
            this.dgvInventoryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryType.Size = new System.Drawing.Size(511, 543);
            this.dgvInventoryType.TabIndex = 0;
            this.dgvInventoryType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryType_CellValueChanged);
            this.dgvInventoryType.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInventoryType_DataError);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddOrder);
            this.tabPage2.Controls.Add(this.btnUpdateOrder);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSaveOrderDetails);
            this.tabPage2.Controls.Add(this.dgvOrderDetailsList);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnExcelExport);
            this.tabPage2.Controls.Add(this.btnOrderDisplay);
            this.tabPage2.Controls.Add(this.dgvNeedInventoryDetailView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "발주내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.Location = new System.Drawing.Point(143, 581);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(112, 23);
            this.btnAddOrder.TabIndex = 19;
            this.btnAddOrder.Text = "발주 추가";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Enabled = false;
            this.btnUpdateOrder.Location = new System.Drawing.Point(143, 607);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateOrder.TabIndex = 18;
            this.btnUpdateOrder.Text = "수정 내용 저장";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "발주내역 DetailView";
            // 
            // btnSaveOrderDetails
            // 
            this.btnSaveOrderDetails.Location = new System.Drawing.Point(576, 581);
            this.btnSaveOrderDetails.Name = "btnSaveOrderDetails";
            this.btnSaveOrderDetails.Size = new System.Drawing.Size(163, 43);
            this.btnSaveOrderDetails.TabIndex = 16;
            this.btnSaveOrderDetails.Text = "발주내역 저장";
            this.btnSaveOrderDetails.UseVisualStyleBackColor = true;
            this.btnSaveOrderDetails.Click += new System.EventHandler(this.btnSaveOrderDetails_Click);
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetailsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(12, 35);
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            this.dgvOrderDetailsList.RowTemplate.Height = 23;
            this.dgvOrderDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(125, 543);
            this.dgvOrderDetailsList.TabIndex = 8;
            this.dgvOrderDetailsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetailsList_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "발주내역List";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(745, 581);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(163, 43);
            this.btnExcelExport.TabIndex = 13;
            this.btnExcelExport.Text = "excel추출";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnOrderDisplay
            // 
            this.btnOrderDisplay.Location = new System.Drawing.Point(796, 9);
            this.btnOrderDisplay.Name = "btnOrderDisplay";
            this.btnOrderDisplay.Size = new System.Drawing.Size(112, 23);
            this.btnOrderDisplay.TabIndex = 12;
            this.btnOrderDisplay.Text = "발주내역 산출";
            this.btnOrderDisplay.UseVisualStyleBackColor = true;
            this.btnOrderDisplay.Click += new System.EventHandler(this.btnOrderDisplay_Click);
            // 
            // dgvNeedInventoryDetailView
            // 
            this.dgvNeedInventoryDetailView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNeedInventoryDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNeedInventoryDetailView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNeedInventoryDetailView.Location = new System.Drawing.Point(143, 35);
            this.dgvNeedInventoryDetailView.MultiSelect = false;
            this.dgvNeedInventoryDetailView.Name = "dgvNeedInventoryDetailView";
            this.dgvNeedInventoryDetailView.RowTemplate.Height = 23;
            this.dgvNeedInventoryDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNeedInventoryDetailView.Size = new System.Drawing.Size(765, 543);
            this.dgvNeedInventoryDetailView.TabIndex = 9;
            this.dgvNeedInventoryDetailView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNeedInventoryDetailView_DataError);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmInventory";
            this.Size = new System.Drawing.Size(1200, 725);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedInventoryDetailView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnReturnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReceivingDetailsList;
        private System.Windows.Forms.Button btnLoadingFile;
        private System.Windows.Forms.Button btnReceivingDetailsSave;
        private System.Windows.Forms.DataGridView dgvReceivingDetails;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnInventoryTypeAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventoryNewTable;
        private System.Windows.Forms.DataGridView dgvInventoryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryType;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveOrderDetails;
        private System.Windows.Forms.DataGridView dgvOrderDetailsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnOrderDisplay;
        private System.Windows.Forms.DataGridView dgvNeedInventoryDetailView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
