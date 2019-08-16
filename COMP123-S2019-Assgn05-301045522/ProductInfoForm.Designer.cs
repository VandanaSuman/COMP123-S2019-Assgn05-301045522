namespace COMP123_S2019_Assgn05_301045522
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
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.Label();
            this.CPUNumTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.AnotherProductLabel = new System.Windows.Forms.Button();
            this.ProductInfoFormCancelLabel = new System.Windows.Forms.Button();
            this.ProductInfoFormNextLabel = new System.Windows.Forms.Button();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(804, 25);
            this.ProductInfoMenuStrip.TabIndex = 1;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.AcceptsReturn = true;
            this.ProductIDTextBox.Location = new System.Drawing.Point(114, 35);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.ProductIDTextBox.TabIndex = 4;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(12, 41);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(85, 20);
            this.ProductIDLabel.TabIndex = 3;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(365, 35);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 26);
            this.ConditionTextBox.TabIndex = 6;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(268, 41);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 5;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(604, 35);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 26);
            this.CostTextBox.TabIndex = 8;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(543, 41);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "Cost";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(16, 105);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(748, 152);
            this.ProductInfoGroupBox.TabIndex = 9;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(398, 74);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(344, 26);
            this.ModelTextBox.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(317, 80);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(398, 20);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(344, 26);
            this.OSTextBox.TabIndex = 1;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(317, 26);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "OS";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(131, 74);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 26);
            this.ManufacturerTextBox.TabIndex = 1;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(17, 80);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(131, 20);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlatformTextBox.TabIndex = 1;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(17, 26);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.TypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.SpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(16, 280);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(748, 172);
            this.TechSpecsGroupBox.TabIndex = 10;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(131, 114);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.TypeTextBox.TabIndex = 1;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.AutoSize = true;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(21, 115);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeTextBox.TabIndex = 0;
            this.CPUTypeTextBox.Text = "CPU Type";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(131, 77);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUBrandTextBox.TabIndex = 1;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(21, 77);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 0;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(357, 115);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(100, 26);
            this.SpeedTextBox.TabIndex = 1;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.AutoSize = true;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(247, 116);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedTextBox.TabIndex = 0;
            this.CPUSpeedTextBox.Text = "CPU Speed";
            // 
            // CPUNumTextBox
            // 
            this.CPUNumTextBox.Location = new System.Drawing.Point(357, 74);
            this.CPUNumTextBox.Name = "CPUNumTextBox";
            this.CPUNumTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUNumTextBox.TabIndex = 1;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(247, 80);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.CPUNumberLabel.TabIndex = 0;
            this.CPUNumberLabel.Text = "CPU Number\r\n";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.Location = new System.Drawing.Point(552, 116);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.Size = new System.Drawing.Size(190, 26);
            this.WebcamTextBox.TabIndex = 1;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(463, 117);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(72, 20);
            this.WebcamLabel.TabIndex = 0;
            this.WebcamLabel.Text = "Webcam\r\n";
            // 
            // GPUTextBox
            // 
            this.GPUTextBox.Location = new System.Drawing.Point(552, 77);
            this.GPUTextBox.Name = "GPUTextBox";
            this.GPUTextBox.Size = new System.Drawing.Size(190, 26);
            this.GPUTextBox.TabIndex = 1;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.AutoSize = true;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(463, 80);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeTextBox.TabIndex = 0;
            this.GPUTypeTextBox.Text = "GPU Type\r\n";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(552, 40);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(190, 26);
            this.HDDTextBox.TabIndex = 1;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(463, 40);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "HDD";
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Location = new System.Drawing.Point(357, 39);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.Size = new System.Drawing.Size(100, 26);
            this.LCDTextBox.TabIndex = 1;
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Location = new System.Drawing.Point(247, 40);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDLabel.TabIndex = 0;
            this.LCDLabel.Text = "LCD Size";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(131, 38);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 26);
            this.MemoryTextBox.TabIndex = 1;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(21, 39);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(12, 476);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(259, 20);
            this.ConfirmLabel.TabIndex = 11;
            this.ConfirmLabel.Text = "Click Next to Confirm your Selection";
            // 
            // AnotherProductLabel
            // 
            this.AnotherProductLabel.Location = new System.Drawing.Point(303, 476);
            this.AnotherProductLabel.Name = "AnotherProductLabel";
            this.AnotherProductLabel.Size = new System.Drawing.Size(184, 24);
            this.AnotherProductLabel.TabIndex = 12;
            this.AnotherProductLabel.Text = "Select Another Product";
            this.AnotherProductLabel.UseVisualStyleBackColor = true;
            this.AnotherProductLabel.Click += new System.EventHandler(this.AnotherProductLabel_Click);
            // 
            // ProductInfoFormCancelLabel
            // 
            this.ProductInfoFormCancelLabel.Location = new System.Drawing.Point(524, 476);
            this.ProductInfoFormCancelLabel.Name = "ProductInfoFormCancelLabel";
            this.ProductInfoFormCancelLabel.Size = new System.Drawing.Size(75, 24);
            this.ProductInfoFormCancelLabel.TabIndex = 13;
            this.ProductInfoFormCancelLabel.Text = "Cancel";
            this.ProductInfoFormCancelLabel.UseVisualStyleBackColor = true;
            this.ProductInfoFormCancelLabel.Click += new System.EventHandler(this.ProductInfoFormCancelLabel_Click);
            // 
            // ProductInfoFormNextLabel
            // 
            this.ProductInfoFormNextLabel.Location = new System.Drawing.Point(629, 474);
            this.ProductInfoFormNextLabel.Name = "ProductInfoFormNextLabel";
            this.ProductInfoFormNextLabel.Size = new System.Drawing.Size(75, 24);
            this.ProductInfoFormNextLabel.TabIndex = 14;
            this.ProductInfoFormNextLabel.Text = "Next";
            this.ProductInfoFormNextLabel.UseVisualStyleBackColor = true;
            this.ProductInfoFormNextLabel.Click += new System.EventHandler(this.ProductInfoFormNextLabel_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 551);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoFormNextLabel);
            this.Controls.Add(this.ProductInfoFormCancelLabel);
            this.Controls.Add(this.AnotherProductLabel);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label CPUTypeTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUSpeedTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button AnotherProductLabel;
        private System.Windows.Forms.Button ProductInfoFormCancelLabel;
        private System.Windows.Forms.Button ProductInfoFormNextLabel;
        public System.Windows.Forms.TextBox ProductIDTextBox;
        public System.Windows.Forms.TextBox ConditionTextBox;
        public System.Windows.Forms.TextBox CostTextBox;
        public System.Windows.Forms.TextBox ModelTextBox;
        public System.Windows.Forms.TextBox OSTextBox;
        public System.Windows.Forms.TextBox ManufacturerTextBox;
        public System.Windows.Forms.TextBox PlatformTextBox;
        public System.Windows.Forms.TextBox TypeTextBox;
        public System.Windows.Forms.TextBox CPUBrandTextBox;
        public System.Windows.Forms.TextBox SpeedTextBox;
        public System.Windows.Forms.TextBox CPUNumTextBox;
        public System.Windows.Forms.TextBox WebcamTextBox;
        public System.Windows.Forms.TextBox GPUTextBox;
        public System.Windows.Forms.TextBox HDDTextBox;
        public System.Windows.Forms.TextBox LCDTextBox;
        public System.Windows.Forms.TextBox MemoryTextBox;
    }
}