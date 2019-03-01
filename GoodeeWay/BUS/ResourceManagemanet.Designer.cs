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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnInven = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.movePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.sidePanel.Controls.Add(this.pbxImages);
            this.sidePanel.Controls.Add(this.btnEquip);
            this.sidePanel.Controls.Add(this.btnInven);
            this.sidePanel.Controls.Add(this.btnMenu);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 686);
            this.sidePanel.TabIndex = 5;
            // 
            // pbxImages
            // 
            this.pbxImages.BackColor = System.Drawing.Color.Transparent;
            this.pbxImages.Location = new System.Drawing.Point(0, 0);
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.Size = new System.Drawing.Size(200, 50);
            this.pbxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImages.TabIndex = 8;
            this.pbxImages.TabStop = false;
            // 
            // btnEquip
            // 
            this.btnEquip.FlatAppearance.BorderSize = 0;
            this.btnEquip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEquip.ForeColor = System.Drawing.Color.White;
            this.btnEquip.Image = global::GoodeeWay.Properties.Resources.Maintenance_50px;
            this.btnEquip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquip.Location = new System.Drawing.Point(0, 201);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(200, 50);
            this.btnEquip.TabIndex = 7;
            this.btnEquip.Text = "비품별 통계";
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnInven
            // 
            this.btnInven.FlatAppearance.BorderSize = 0;
            this.btnInven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInven.ForeColor = System.Drawing.Color.White;
            this.btnInven.Image = global::GoodeeWay.Properties.Resources.Commodity_50px;
            this.btnInven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInven.Location = new System.Drawing.Point(0, 136);
            this.btnInven.Name = "btnInven";
            this.btnInven.Size = new System.Drawing.Size(200, 50);
            this.btnInven.TabIndex = 6;
            this.btnInven.Text = "재고별 통계";
            this.btnInven.UseVisualStyleBackColor = true;
            this.btnInven.Click += new System.EventHandler(this.btnInven_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::GoodeeWay.Properties.Resources.Restaurant_Menu_50px;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 71);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "메뉴별 통계";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.movePanel.Controls.Add(this.btnClose);
            this.movePanel.Controls.Add(this.btnMinimize);
            this.movePanel.Controls.Add(this.btnMaximize);
            this.movePanel.Controls.Add(this.label1);
            this.movePanel.Controls.Add(this.pictureBox1);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(200, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(957, 50);
            this.movePanel.TabIndex = 6;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "매출 현황";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeWay.Properties.Resources.Total_Sales_50px;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(957, 636);
            this.mainPanel.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GoodeeWay.Properties.Resources.Close_Window_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(916, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::GoodeeWay.Properties.Resources.Minimize_Window_64px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(830, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 36);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = global::GoodeeWay.Properties.Resources.Maximize_Window_64px;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(873, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 36);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // ResourceManagemanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 686);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResourceManagemanet";
            this.Text = "매출관리";
            this.Load += new System.EventHandler(this.ResourceManagemanet_Load);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            this.movePanel.ResumeLayout(false);
            this.movePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pbxImages;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnInven;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}