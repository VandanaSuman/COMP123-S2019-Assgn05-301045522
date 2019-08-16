namespace COMP123_S2019_Assgn05_301045522
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartFormLabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.OpenOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartFormpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartFormLabel
            // 
            this.StartFormLabel.AutoSize = true;
            this.StartFormLabel.Location = new System.Drawing.Point(144, 49);
            this.StartFormLabel.Name = "StartFormLabel";
            this.StartFormLabel.Size = new System.Drawing.Size(364, 31);
            this.StartFormLabel.TabIndex = 1;
            this.StartFormLabel.Text = "Order Your Computer Today!";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(168, 274);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(288, 39);
            this.NewOrderButton.TabIndex = 2;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // OpenOrderButton
            // 
            this.OpenOrderButton.Location = new System.Drawing.Point(168, 319);
            this.OpenOrderButton.Name = "OpenOrderButton";
            this.OpenOrderButton.Size = new System.Drawing.Size(288, 39);
            this.OpenOrderButton.TabIndex = 3;
            this.OpenOrderButton.Text = "Open a Saved Order";
            this.OpenOrderButton.UseVisualStyleBackColor = true;
            this.OpenOrderButton.Click += new System.EventHandler(this.OpenOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(168, 364);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(288, 39);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartFormpictureBox
            // 
            this.StartFormpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StartFormpictureBox.Image")));
            this.StartFormpictureBox.Location = new System.Drawing.Point(168, 101);
            this.StartFormpictureBox.Name = "StartFormpictureBox";
            this.StartFormpictureBox.Size = new System.Drawing.Size(288, 136);
            this.StartFormpictureBox.TabIndex = 5;
            this.StartFormpictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormpictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.StartFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartFormLabel;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button OpenOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox StartFormpictureBox;
    }
}