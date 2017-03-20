namespace Assignment4
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.selectFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.upTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.productInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.techSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.techSpecsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.downTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clickNextToConfirmLabel = new System.Windows.Forms.Label();
            this.selectAnotherProductButton = new System.Windows.Forms.Button();
            this.productOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.productSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.selectFormMenuStrip.SuspendLayout();
            this.parentTableLayoutPanel.SuspendLayout();
            this.upTableLayoutPanel.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.productInfoTableLayoutPanel.SuspendLayout();
            this.techSpecsGroupBox.SuspendLayout();
            this.techSpecsTableLayoutPanel.SuspendLayout();
            this.downTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFormMenuStrip
            // 
            this.selectFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.selectFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.selectFormMenuStrip.Name = "selectFormMenuStrip";
            this.selectFormMenuStrip.Size = new System.Drawing.Size(619, 24);
            this.selectFormMenuStrip.TabIndex = 1;
            this.selectFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // parentTableLayoutPanel
            // 
            this.parentTableLayoutPanel.ColumnCount = 1;
            this.parentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parentTableLayoutPanel.Controls.Add(this.upTableLayoutPanel, 0, 0);
            this.parentTableLayoutPanel.Controls.Add(this.productInfoGroupBox, 0, 1);
            this.parentTableLayoutPanel.Controls.Add(this.techSpecsGroupBox, 0, 2);
            this.parentTableLayoutPanel.Controls.Add(this.downTableLayoutPanel, 0, 3);
            this.parentTableLayoutPanel.Location = new System.Drawing.Point(13, 39);
            this.parentTableLayoutPanel.Name = "parentTableLayoutPanel";
            this.parentTableLayoutPanel.RowCount = 4;
            this.parentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.parentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.parentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.parentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.parentTableLayoutPanel.Size = new System.Drawing.Size(594, 282);
            this.parentTableLayoutPanel.TabIndex = 2;
            // 
            // upTableLayoutPanel
            // 
            this.upTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upTableLayoutPanel.ColumnCount = 6;
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.upTableLayoutPanel.Controls.Add(this.costTextBox, 5, 0);
            this.upTableLayoutPanel.Controls.Add(this.conditionTextBox, 3, 0);
            this.upTableLayoutPanel.Controls.Add(this.conditionLabel, 2, 0);
            this.upTableLayoutPanel.Controls.Add(this.productIdLabel, 0, 0);
            this.upTableLayoutPanel.Controls.Add(this.costLabel, 4, 0);
            this.upTableLayoutPanel.Controls.Add(this.productIdTextBox, 1, 0);
            this.upTableLayoutPanel.Location = new System.Drawing.Point(8, 3);
            this.upTableLayoutPanel.Name = "upTableLayoutPanel";
            this.upTableLayoutPanel.RowCount = 1;
            this.upTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.upTableLayoutPanel.Size = new System.Drawing.Size(578, 25);
            this.upTableLayoutPanel.TabIndex = 0;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.costTextBox.Location = new System.Drawing.Point(483, 3);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(90, 20);
            this.costTextBox.TabIndex = 7;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.conditionTextBox.Location = new System.Drawing.Point(291, 3);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.ReadOnly = true;
            this.conditionTextBox.Size = new System.Drawing.Size(90, 20);
            this.conditionTextBox.TabIndex = 6;
            // 
            // conditionLabel
            // 
            this.conditionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(226, 5);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(59, 15);
            this.conditionLabel.TabIndex = 3;
            this.conditionLabel.Text = "Condition";
            // 
            // productIdLabel
            // 
            this.productIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.Location = new System.Drawing.Point(29, 5);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(64, 15);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "Product ID";
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(446, 5);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 15);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdTextBox.Location = new System.Drawing.Point(99, 3);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(90, 20);
            this.productIdTextBox.TabIndex = 5;
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.productInfoTableLayoutPanel);
            this.productInfoGroupBox.Location = new System.Drawing.Point(3, 34);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Size = new System.Drawing.Size(588, 87);
            this.productInfoGroupBox.TabIndex = 3;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Product Info";
            // 
            // productInfoTableLayoutPanel
            // 
            this.productInfoTableLayoutPanel.ColumnCount = 4;
            this.productInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.productInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.productInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.productInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99F));
            this.productInfoTableLayoutPanel.Controls.Add(this.modelTextBox, 3, 1);
            this.productInfoTableLayoutPanel.Controls.Add(this.manufacturerTextBox, 1, 1);
            this.productInfoTableLayoutPanel.Controls.Add(this.osTextBox, 3, 0);
            this.productInfoTableLayoutPanel.Controls.Add(this.platformTextBox, 1, 0);
            this.productInfoTableLayoutPanel.Controls.Add(this.modelLabel, 2, 1);
            this.productInfoTableLayoutPanel.Controls.Add(this.platformLabel, 0, 0);
            this.productInfoTableLayoutPanel.Controls.Add(this.osLabel, 2, 0);
            this.productInfoTableLayoutPanel.Controls.Add(this.manufacturerLabel, 0, 1);
            this.productInfoTableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.productInfoTableLayoutPanel.Name = "productInfoTableLayoutPanel";
            this.productInfoTableLayoutPanel.RowCount = 2;
            this.productInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.productInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.productInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.productInfoTableLayoutPanel.Size = new System.Drawing.Size(576, 62);
            this.productInfoTableLayoutPanel.TabIndex = 1;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modelTextBox.Location = new System.Drawing.Point(291, 36);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(281, 20);
            this.modelTextBox.TabIndex = 10;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manufacturerTextBox.Location = new System.Drawing.Point(99, 36);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(90, 20);
            this.manufacturerTextBox.TabIndex = 9;
            // 
            // osTextBox
            // 
            this.osTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osTextBox.Location = new System.Drawing.Point(291, 5);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.ReadOnly = true;
            this.osTextBox.Size = new System.Drawing.Size(281, 20);
            this.osTextBox.TabIndex = 8;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.platformTextBox.Location = new System.Drawing.Point(99, 5);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.ReadOnly = true;
            this.platformTextBox.Size = new System.Drawing.Size(90, 20);
            this.platformTextBox.TabIndex = 7;
            // 
            // modelLabel
            // 
            this.modelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(243, 39);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(42, 15);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model";
            // 
            // platformLabel
            // 
            this.platformLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(40, 8);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(53, 15);
            this.platformLabel.TabIndex = 1;
            this.platformLabel.Text = "Platform";
            // 
            // osLabel
            // 
            this.osLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.osLabel.AutoSize = true;
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(261, 8);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(24, 15);
            this.osLabel.TabIndex = 2;
            this.osLabel.Text = "OS";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(13, 39);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(80, 15);
            this.manufacturerLabel.TabIndex = 6;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // techSpecsGroupBox
            // 
            this.techSpecsGroupBox.Controls.Add(this.techSpecsTableLayoutPanel);
            this.techSpecsGroupBox.Location = new System.Drawing.Point(3, 128);
            this.techSpecsGroupBox.Name = "techSpecsGroupBox";
            this.techSpecsGroupBox.Size = new System.Drawing.Size(588, 119);
            this.techSpecsGroupBox.TabIndex = 4;
            this.techSpecsGroupBox.TabStop = false;
            this.techSpecsGroupBox.Text = "Tech Specs";
            // 
            // techSpecsTableLayoutPanel
            // 
            this.techSpecsTableLayoutPanel.ColumnCount = 6;
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.techSpecsTableLayoutPanel.Controls.Add(this.webCamTextBox, 5, 2);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuSpeedTextBox, 3, 2);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuTypeTextBox, 1, 2);
            this.techSpecsTableLayoutPanel.Controls.Add(this.gpuTypeTextBox, 5, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuNumberTextBox, 3, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuBrandTextBox, 1, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.hddTextBox, 5, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.lcdSizeTextBox, 3, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.memoryTextBox, 1, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.memoryLabel, 0, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuBrandLabel, 0, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuTypeLabel, 0, 2);
            this.techSpecsTableLayoutPanel.Controls.Add(this.lcdSizeLabel, 2, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuNumberLabel, 2, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.cpuSpeedLabel, 2, 2);
            this.techSpecsTableLayoutPanel.Controls.Add(this.hddLabel, 4, 0);
            this.techSpecsTableLayoutPanel.Controls.Add(this.gpuTypeLabel, 4, 1);
            this.techSpecsTableLayoutPanel.Controls.Add(this.webCamLabel, 4, 2);
            this.techSpecsTableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.techSpecsTableLayoutPanel.Name = "techSpecsTableLayoutPanel";
            this.techSpecsTableLayoutPanel.RowCount = 3;
            this.techSpecsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.techSpecsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.techSpecsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.techSpecsTableLayoutPanel.Size = new System.Drawing.Size(576, 94);
            this.techSpecsTableLayoutPanel.TabIndex = 2;
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.webCamTextBox.Location = new System.Drawing.Point(478, 68);
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.ReadOnly = true;
            this.webCamTextBox.Size = new System.Drawing.Size(90, 20);
            this.webCamTextBox.TabIndex = 24;
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(288, 68);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.ReadOnly = true;
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(89, 20);
            this.cpuSpeedTextBox.TabIndex = 23;
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuTypeTextBox.Location = new System.Drawing.Point(98, 68);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.ReadOnly = true;
            this.cpuTypeTextBox.Size = new System.Drawing.Size(89, 20);
            this.cpuTypeTextBox.TabIndex = 22;
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuTypeTextBox.Location = new System.Drawing.Point(478, 36);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.ReadOnly = true;
            this.gpuTypeTextBox.Size = new System.Drawing.Size(90, 20);
            this.gpuTypeTextBox.TabIndex = 21;
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuNumberTextBox.Location = new System.Drawing.Point(288, 36);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.ReadOnly = true;
            this.cpuNumberTextBox.Size = new System.Drawing.Size(89, 20);
            this.cpuNumberTextBox.TabIndex = 20;
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuBrandTextBox.Location = new System.Drawing.Point(98, 36);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.ReadOnly = true;
            this.cpuBrandTextBox.Size = new System.Drawing.Size(89, 20);
            this.cpuBrandTextBox.TabIndex = 19;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hddTextBox.Location = new System.Drawing.Point(478, 5);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.ReadOnly = true;
            this.hddTextBox.Size = new System.Drawing.Size(90, 20);
            this.hddTextBox.TabIndex = 18;
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lcdSizeTextBox.Location = new System.Drawing.Point(288, 5);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.ReadOnly = true;
            this.lcdSizeTextBox.Size = new System.Drawing.Size(89, 20);
            this.lcdSizeTextBox.TabIndex = 17;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryTextBox.Location = new System.Drawing.Point(98, 5);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.ReadOnly = true;
            this.memoryTextBox.Size = new System.Drawing.Size(89, 20);
            this.memoryTextBox.TabIndex = 16;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(40, 8);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(52, 15);
            this.memoryLabel.TabIndex = 7;
            this.memoryLabel.Text = "Memory";
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(24, 39);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(68, 15);
            this.cpuBrandLabel.TabIndex = 8;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeLabel.Location = new System.Drawing.Point(31, 70);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(61, 15);
            this.cpuTypeLabel.TabIndex = 9;
            this.cpuTypeLabel.Text = "CPU Type";
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lcdSizeLabel.AutoSize = true;
            this.lcdSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeLabel.Location = new System.Drawing.Point(224, 8);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(58, 15);
            this.lcdSizeLabel.TabIndex = 10;
            this.lcdSizeLabel.Text = "LCD Size";
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(202, 39);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(80, 15);
            this.cpuNumberLabel.TabIndex = 11;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(211, 70);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(71, 15);
            this.cpuSpeedLabel.TabIndex = 12;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // hddLabel
            // 
            this.hddLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hddLabel.AutoSize = true;
            this.hddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddLabel.Location = new System.Drawing.Point(438, 8);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(34, 15);
            this.hddLabel.TabIndex = 13;
            this.hddLabel.Text = "HDD";
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeLabel.Location = new System.Drawing.Point(410, 39);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(62, 15);
            this.gpuTypeLabel.TabIndex = 14;
            this.gpuTypeLabel.Text = "GPU Type";
            // 
            // webCamLabel
            // 
            this.webCamLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.webCamLabel.AutoSize = true;
            this.webCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webCamLabel.Location = new System.Drawing.Point(414, 70);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(58, 15);
            this.webCamLabel.TabIndex = 15;
            this.webCamLabel.Text = "WebCam";
            // 
            // downTableLayoutPanel
            // 
            this.downTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downTableLayoutPanel.ColumnCount = 4;
            this.downTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.downTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.downTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.downTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.downTableLayoutPanel.Controls.Add(this.nextButton, 3, 0);
            this.downTableLayoutPanel.Controls.Add(this.cancelButton, 2, 0);
            this.downTableLayoutPanel.Controls.Add(this.clickNextToConfirmLabel, 0, 0);
            this.downTableLayoutPanel.Controls.Add(this.selectAnotherProductButton, 1, 0);
            this.downTableLayoutPanel.Location = new System.Drawing.Point(8, 253);
            this.downTableLayoutPanel.Name = "downTableLayoutPanel";
            this.downTableLayoutPanel.RowCount = 1;
            this.downTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.downTableLayoutPanel.Size = new System.Drawing.Size(577, 26);
            this.downTableLayoutPanel.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(507, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(67, 20);
            this.nextButton.TabIndex = 19;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(435, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 20);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clickNextToConfirmLabel
            // 
            this.clickNextToConfirmLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clickNextToConfirmLabel.AutoSize = true;
            this.clickNextToConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickNextToConfirmLabel.Location = new System.Drawing.Point(3, 5);
            this.clickNextToConfirmLabel.Name = "clickNextToConfirmLabel";
            this.clickNextToConfirmLabel.Size = new System.Drawing.Size(202, 15);
            this.clickNextToConfirmLabel.TabIndex = 16;
            this.clickNextToConfirmLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // selectAnotherProductButton
            // 
            this.selectAnotherProductButton.Location = new System.Drawing.Point(291, 3);
            this.selectAnotherProductButton.Name = "selectAnotherProductButton";
            this.selectAnotherProductButton.Size = new System.Drawing.Size(138, 20);
            this.selectAnotherProductButton.TabIndex = 17;
            this.selectAnotherProductButton.Text = "Select Another Product";
            this.selectAnotherProductButton.UseVisualStyleBackColor = true;
            this.selectAnotherProductButton.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // productOpenFileDialog
            // 
            this.productOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 333);
            this.ControlBox = false;
            this.Controls.Add(this.parentTableLayoutPanel);
            this.Controls.Add(this.selectFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.selectFormMenuStrip;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.selectFormMenuStrip.ResumeLayout(false);
            this.selectFormMenuStrip.PerformLayout();
            this.parentTableLayoutPanel.ResumeLayout(false);
            this.upTableLayoutPanel.ResumeLayout(false);
            this.upTableLayoutPanel.PerformLayout();
            this.productInfoGroupBox.ResumeLayout(false);
            this.productInfoTableLayoutPanel.ResumeLayout(false);
            this.productInfoTableLayoutPanel.PerformLayout();
            this.techSpecsGroupBox.ResumeLayout(false);
            this.techSpecsTableLayoutPanel.ResumeLayout(false);
            this.techSpecsTableLayoutPanel.PerformLayout();
            this.downTableLayoutPanel.ResumeLayout(false);
            this.downTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip selectFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel parentTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel techSpecsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel productInfoTableLayoutPanel;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.GroupBox techSpecsGroupBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label webCamLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.TableLayoutPanel downTableLayoutPanel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.TextBox webCamTextBox;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.Label clickNextToConfirmLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectAnotherProductButton;
        private System.Windows.Forms.OpenFileDialog productOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog productSaveFileDialog;
    }
}