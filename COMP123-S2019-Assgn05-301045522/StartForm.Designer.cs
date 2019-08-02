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
            this.StartFormLabel = new System.Windows.Forms.Label();
            this.NewOrderLabel = new System.Windows.Forms.Button();
            this.OpenOrderLabel = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Button();
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
            // NewOrderLabel
            // 
            this.NewOrderLabel.Location = new System.Drawing.Point(168, 243);
            this.NewOrderLabel.Name = "NewOrderLabel";
            this.NewOrderLabel.Size = new System.Drawing.Size(288, 39);
            this.NewOrderLabel.TabIndex = 2;
            this.NewOrderLabel.Text = "Start a New Order";
            this.NewOrderLabel.UseVisualStyleBackColor = true;
            // 
            // OpenOrderLabel
            // 
            this.OpenOrderLabel.Location = new System.Drawing.Point(168, 303);
            this.OpenOrderLabel.Name = "OpenOrderLabel";
            this.OpenOrderLabel.Size = new System.Drawing.Size(288, 39);
            this.OpenOrderLabel.TabIndex = 3;
            this.OpenOrderLabel.Text = "Open a Saved Order";
            this.OpenOrderLabel.UseVisualStyleBackColor = true;
            // 
            // ExitLabel
            // 
            this.ExitLabel.Location = new System.Drawing.Point(168, 364);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(288, 39);
            this.ExitLabel.TabIndex = 4;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.OpenOrderLabel);
            this.Controls.Add(this.NewOrderLabel);
            this.Controls.Add(this.StartFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartFormLabel;
        private System.Windows.Forms.Button NewOrderLabel;
        private System.Windows.Forms.Button OpenOrderLabel;
        private System.Windows.Forms.Button ExitLabel;
    }
}