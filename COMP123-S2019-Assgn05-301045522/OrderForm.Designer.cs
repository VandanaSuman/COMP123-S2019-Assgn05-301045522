namespace COMP123_S2019_Assgn05_301045522
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.ComponentsTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.YourPriceTextBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewCancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.YourPriceTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(804, 24);
            this.OrderFormMenuStrip.TabIndex = 1;
            this.OrderFormMenuStrip.Text = "OrderFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.ComponentsTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(12, 41);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(460, 498);
            this.SystemComponentsGroupBox.TabIndex = 2;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // ComponentsTextBox
            // 
            this.ComponentsTextBox.Location = new System.Drawing.Point(115, 133);
            this.ComponentsTextBox.Multiline = true;
            this.ComponentsTextBox.Name = "ComponentsTextBox";
            this.ComponentsTextBox.Size = new System.Drawing.Size(297, 328);
            this.ComponentsTextBox.TabIndex = 2;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(312, 29);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlatformTextBox.TabIndex = 1;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(230, 35);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(312, 71);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 26);
            this.ModelTextBox.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(230, 77);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(115, 71);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 26);
            this.ManufacturerTextBox.TabIndex = 1;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(6, 441);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "OS";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(6, 404);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(75, 20);
            this.WebCamLabel.TabIndex = 0;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(6, 371);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeLabel.TabIndex = 0;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(6, 336);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(6, 306);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedLabel.TabIndex = 0;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(6, 275);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.CPUNumberLabel.TabIndex = 0;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(6, 238);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeLabel.TabIndex = 0;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 201);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 0;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(6, 170);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(6, 134);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDSizeLabel.TabIndex = 0;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 77);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(115, 29);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 26);
            this.ConditionTextBox.TabIndex = 1;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(6, 35);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // YourPriceTextBox
            // 
            this.YourPriceTextBox.Controls.Add(this.TotalTextBox);
            this.YourPriceTextBox.Controls.Add(this.SalesTaxTextBox);
            this.YourPriceTextBox.Controls.Add(this.PriceTextBox);
            this.YourPriceTextBox.Controls.Add(this.TotalLabel);
            this.YourPriceTextBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceTextBox.Controls.Add(this.PriceLabel);
            this.YourPriceTextBox.Location = new System.Drawing.Point(490, 190);
            this.YourPriceTextBox.Name = "YourPriceTextBox";
            this.YourPriceTextBox.Size = new System.Drawing.Size(302, 177);
            this.YourPriceTextBox.TabIndex = 3;
            this.YourPriceTextBox.TabStop = false;
            this.YourPriceTextBox.Text = "YourPrice";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(189, 119);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.TotalTextBox.TabIndex = 1;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(189, 68);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 26);
            this.SalesTaxTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(189, 36);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.PriceTextBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(16, 122);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(16, 71);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax (18%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(16, 42);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(490, 439);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewCancelButton
            // 
            this.NewCancelButton.Location = new System.Drawing.Point(599, 439);
            this.NewCancelButton.Name = "NewCancelButton";
            this.NewCancelButton.Size = new System.Drawing.Size(75, 32);
            this.NewCancelButton.TabIndex = 5;
            this.NewCancelButton.Text = "Cancel";
            this.NewCancelButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(717, 439);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 32);
            this.FinishButton.TabIndex = 6;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 551);
            this.ControlBox = false;
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.NewCancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourPriceTextBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.YourPriceTextBox.ResumeLayout(false);
            this.YourPriceTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TextBox ComponentsTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox YourPriceTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NewCancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}