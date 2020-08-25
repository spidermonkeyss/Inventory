namespace ProductInventoryProject
{
    partial class Form1
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
            this.addItemBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showInventoryBtn = new System.Windows.Forms.Button();
            this.addItemPanel = new System.Windows.Forms.Panel();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.showInventoryPanel = new System.Windows.Forms.Panel();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.totalValueText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editItembtn = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.editItemPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.editBackBtn = new System.Windows.Forms.Button();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.editPriceTextBox = new System.Windows.Forms.TextBox();
            this.editQuantityTextBox = new System.Windows.Forms.TextBox();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editPriceLabel = new System.Windows.Forms.Label();
            this.editQuantityLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameInvalid = new System.Windows.Forms.TextBox();
            this.priceInvalid = new System.Windows.Forms.TextBox();
            this.quantityInvalid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInventoryPanel = new System.Windows.Forms.Panel();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.addItemPanel.SuspendLayout();
            this.showInventoryPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.editItemPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(518, 87);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "Add item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showInventoryBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 1;
            // 
            // showInventoryBtn
            // 
            this.showInventoryBtn.Location = new System.Drawing.Point(155, 90);
            this.showInventoryBtn.Name = "showInventoryBtn";
            this.showInventoryBtn.Size = new System.Drawing.Size(132, 23);
            this.showInventoryBtn.TabIndex = 1;
            this.showInventoryBtn.Text = "Show Inventory";
            this.showInventoryBtn.UseVisualStyleBackColor = true;
            this.showInventoryBtn.Click += new System.EventHandler(this.showInventoryBtn_Click);
            // 
            // addItemPanel
            // 
            this.addItemPanel.Controls.Add(this.nameLabel);
            this.addItemPanel.Controls.Add(this.nameTextBox);
            this.addItemPanel.Controls.Add(this.priceLabel);
            this.addItemPanel.Controls.Add(this.priceTextBox);
            this.addItemPanel.Controls.Add(this.quantityLabel);
            this.addItemPanel.Controls.Add(this.quantityTextBox);
            this.addItemPanel.Controls.Add(this.backBtn2);
            this.addItemPanel.Controls.Add(this.submitBtn);
            this.addItemPanel.Controls.Add(this.nameInvalid);
            this.addItemPanel.Controls.Add(this.priceInvalid);
            this.addItemPanel.Controls.Add(this.quantityInvalid);
            this.addItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemPanel.Location = new System.Drawing.Point(0, 28);
            this.addItemPanel.Name = "addItemPanel";
            this.addItemPanel.Size = new System.Drawing.Size(800, 422);
            this.addItemPanel.TabIndex = 1;
            this.addItemPanel.Visible = false;
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(713, 386);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(75, 23);
            this.backBtn2.TabIndex = 7;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backToPanel1Btn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(60, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(60, 150);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(60, 170);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(170, 22);
            this.priceTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(60, 210);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(60, 230);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(170, 22);
            this.quantityTextBox.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(63, 280);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // showInventoryPanel
            // 
            this.showInventoryPanel.Controls.Add(this.backBtn1);
            this.showInventoryPanel.Controls.Add(this.infoGroupBox);
            this.showInventoryPanel.Controls.Add(this.inventoryListBox);
            this.showInventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showInventoryPanel.Location = new System.Drawing.Point(0, 28);
            this.showInventoryPanel.Name = "showInventoryPanel";
            this.showInventoryPanel.Size = new System.Drawing.Size(800, 422);
            this.showInventoryPanel.TabIndex = 1;
            this.showInventoryPanel.Visible = false;
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(713, 386);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 6;
            this.backBtn1.Text = "Back";
            this.backBtn1.UseVisualStyleBackColor = true;
            this.backBtn1.Click += new System.EventHandler(this.backToPanel1Btn_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.nameText);
            this.infoGroupBox.Controls.Add(this.priceText);
            this.infoGroupBox.Controls.Add(this.quantityText);
            this.infoGroupBox.Controls.Add(this.totalValueText);
            this.infoGroupBox.Controls.Add(this.label1);
            this.infoGroupBox.Controls.Add(this.label2);
            this.infoGroupBox.Controls.Add(this.label3);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.editItembtn);
            this.infoGroupBox.Location = new System.Drawing.Point(402, 8);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(386, 184);
            this.infoGroupBox.TabIndex = 5;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Item Information";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(91, 21);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(100, 22);
            this.nameText.TabIndex = 2;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(91, 51);
            this.priceText.Name = "priceText";
            this.priceText.ReadOnly = true;
            this.priceText.Size = new System.Drawing.Size(100, 22);
            this.priceText.TabIndex = 3;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(91, 81);
            this.quantityText.Name = "quantityText";
            this.quantityText.ReadOnly = true;
            this.quantityText.Size = new System.Drawing.Size(100, 22);
            this.quantityText.TabIndex = 4;
            // 
            // totalValueText
            // 
            this.totalValueText.Location = new System.Drawing.Point(91, 111);
            this.totalValueText.Name = "totalValueText";
            this.totalValueText.ReadOnly = true;
            this.totalValueText.Size = new System.Drawing.Size(100, 22);
            this.totalValueText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editItembtn
            // 
            this.editItembtn.Enabled = false;
            this.editItembtn.Location = new System.Drawing.Point(9, 142);
            this.editItembtn.Name = "editItembtn";
            this.editItembtn.Size = new System.Drawing.Size(109, 23);
            this.editItembtn.TabIndex = 10;
            this.editItembtn.Text = "Edit Item";
            this.editItembtn.UseVisualStyleBackColor = true;
            this.editItembtn.Click += new System.EventHandler(this.editItem_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 8);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(384, 212);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // editItemPanel
            // 
            this.editItemPanel.Controls.Add(this.groupBox1);
            this.editItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editItemPanel.Location = new System.Drawing.Point(0, 28);
            this.editItemPanel.Name = "editItemPanel";
            this.editItemPanel.Size = new System.Drawing.Size(800, 422);
            this.editItemPanel.TabIndex = 7;
            this.editItemPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteItemBtn);
            this.groupBox1.Controls.Add(this.editBackBtn);
            this.groupBox1.Controls.Add(this.editNameTextBox);
            this.groupBox1.Controls.Add(this.editPriceTextBox);
            this.groupBox1.Controls.Add(this.editQuantityTextBox);
            this.groupBox1.Controls.Add(this.editNameLabel);
            this.groupBox1.Controls.Add(this.editPriceLabel);
            this.groupBox1.Controls.Add(this.editQuantityLabel);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(143, 202);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteItemBtn.TabIndex = 8;
            this.deleteItemBtn.Text = "Delete";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // editBackBtn
            // 
            this.editBackBtn.Location = new System.Drawing.Point(48, 24);
            this.editBackBtn.Name = "editBackBtn";
            this.editBackBtn.Size = new System.Drawing.Size(75, 23);
            this.editBackBtn.TabIndex = 7;
            this.editBackBtn.Text = "Back";
            this.editBackBtn.UseVisualStyleBackColor = true;
            this.editBackBtn.Click += new System.EventHandler(this.editBackBtn_Click);
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.Location = new System.Drawing.Point(118, 70);
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.editNameTextBox.TabIndex = 4;
            // 
            // editPriceTextBox
            // 
            this.editPriceTextBox.Location = new System.Drawing.Point(118, 100);
            this.editPriceTextBox.Name = "editPriceTextBox";
            this.editPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.editPriceTextBox.TabIndex = 5;
            // 
            // editQuantityTextBox
            // 
            this.editQuantityTextBox.Location = new System.Drawing.Point(118, 130);
            this.editQuantityTextBox.Name = "editQuantityTextBox";
            this.editQuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.editQuantityTextBox.TabIndex = 6;
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Location = new System.Drawing.Point(48, 70);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(45, 17);
            this.editNameLabel.TabIndex = 1;
            this.editNameLabel.Text = "Name";
            // 
            // editPriceLabel
            // 
            this.editPriceLabel.AutoSize = true;
            this.editPriceLabel.Location = new System.Drawing.Point(48, 100);
            this.editPriceLabel.Name = "editPriceLabel";
            this.editPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.editPriceLabel.TabIndex = 2;
            this.editPriceLabel.Text = "Price";
            // 
            // editQuantityLabel
            // 
            this.editQuantityLabel.AutoSize = true;
            this.editQuantityLabel.Location = new System.Drawing.Point(48, 130);
            this.editQuantityLabel.Name = "editQuantityLabel";
            this.editQuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.editQuantityLabel.TabIndex = 3;
            this.editQuantityLabel.Text = "Quantity";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(51, 202);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // nameInvalid
            // 
            this.nameInvalid.BackColor = System.Drawing.SystemColors.Menu;
            this.nameInvalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInvalid.ForeColor = System.Drawing.Color.Red;
            this.nameInvalid.Location = new System.Drawing.Point(246, 113);
            this.nameInvalid.Name = "nameInvalid";
            this.nameInvalid.ReadOnly = true;
            this.nameInvalid.Size = new System.Drawing.Size(100, 15);
            this.nameInvalid.TabIndex = 8;
            this.nameInvalid.Text = "Invalid";
            this.nameInvalid.Visible = false;
            // 
            // priceInvalid
            // 
            this.priceInvalid.BackColor = System.Drawing.SystemColors.Menu;
            this.priceInvalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceInvalid.ForeColor = System.Drawing.Color.Red;
            this.priceInvalid.Location = new System.Drawing.Point(246, 177);
            this.priceInvalid.Name = "priceInvalid";
            this.priceInvalid.ReadOnly = true;
            this.priceInvalid.Size = new System.Drawing.Size(100, 15);
            this.priceInvalid.TabIndex = 9;
            this.priceInvalid.Text = "Invalid";
            this.priceInvalid.Visible = false;
            // 
            // quantityInvalid
            // 
            this.quantityInvalid.BackColor = System.Drawing.SystemColors.Menu;
            this.quantityInvalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityInvalid.ForeColor = System.Drawing.Color.Red;
            this.quantityInvalid.Location = new System.Drawing.Point(246, 237);
            this.quantityInvalid.Name = "quantityInvalid";
            this.quantityInvalid.ReadOnly = true;
            this.quantityInvalid.Size = new System.Drawing.Size(100, 15);
            this.quantityInvalid.TabIndex = 10;
            this.quantityInvalid.Text = "Invalid";
            this.quantityInvalid.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectInventoryPanel
            // 
            this.selectInventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectInventoryPanel.Location = new System.Drawing.Point(0, 28);
            this.selectInventoryPanel.Name = "selectInventoryPanel";
            this.selectInventoryPanel.Size = new System.Drawing.Size(800, 422);
            this.selectInventoryPanel.TabIndex = 2;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectInventoryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addItemPanel);
            this.Controls.Add(this.editItemPanel);
            this.Controls.Add(this.showInventoryPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.addItemPanel.ResumeLayout(false);
            this.addItemPanel.PerformLayout();
            this.showInventoryPanel.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.editItemPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel addItemPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel showInventoryPanel;
        private System.Windows.Forms.Button showInventoryBtn;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalValueText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Button editItembtn;
        private System.Windows.Forms.Panel editItemPanel;
        private System.Windows.Forms.TextBox editQuantityTextBox;
        private System.Windows.Forms.TextBox editPriceTextBox;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.Label editQuantityLabel;
        private System.Windows.Forms.Label editPriceLabel;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editBackBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.TextBox nameInvalid;
        private System.Windows.Forms.TextBox priceInvalid;
        private System.Windows.Forms.TextBox quantityInvalid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel selectInventoryPanel;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

