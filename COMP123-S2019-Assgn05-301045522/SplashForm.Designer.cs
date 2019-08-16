namespace COMP123_S2019_Assgn05_301045522
{
    partial class SplashForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SplashLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.dollarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dollarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(131, 57);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(374, 31);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to Dollar Computers";
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.Location = new System.Drawing.Point(211, 125);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(197, 31);
            this.SplashLabel.TabIndex = 2;
            this.SplashLabel.Text = "We sell for less";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // dollarPictureBox
            // 
            this.dollarPictureBox.Image = global::COMP123_S2019_Assgn05_301045522.Properties.Resources.dollar;
            this.dollarPictureBox.Location = new System.Drawing.Point(137, 186);
            this.dollarPictureBox.Name = "dollarPictureBox";
            this.dollarPictureBox.Size = new System.Drawing.Size(368, 205);
            this.dollarPictureBox.TabIndex = 3;
            this.dollarPictureBox.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.dollarPictureBox);
            this.Controls.Add(this.SplashLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashForm_FormClosing);
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dollarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox dollarPictureBox;
    }
}

