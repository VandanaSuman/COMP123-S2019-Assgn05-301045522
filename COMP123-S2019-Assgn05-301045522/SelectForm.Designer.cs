namespace COMP123_S2019_Assgn05_301045522
{
    partial class SelectForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(379, 31);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "DollarComputer Hardware List";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(6, 47);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(770, 310);
            this.ProductDataGridView.TabIndex = 3;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(12, 389);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(190, 31);
            this.SelectionLabel.TabIndex = 4;
            this.SelectionLabel.Text = "Your Selection";
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.Location = new System.Drawing.Point(219, 386);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.Size = new System.Drawing.Size(317, 38);
            this.SelectionTextBox.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(556, 386);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 38);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(675, 386);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(101, 38);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectionTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}