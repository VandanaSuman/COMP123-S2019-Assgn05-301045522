using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * App Name: Dollar Computers
 * Author Name: Vandana
 * Student ID : 301045522
 * App Creation Date: 08/16/2019
 * App Description: This app allows users to select a computer, display information about it and calculate the total price of the selection.
 * */
namespace COMP123_S2019_Assgn05_301045522
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event of Finish button that shows a MessageDialogBox with a Message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your OrderWill be Processed in 7-10 Business days.", "Finish", MessageBoxButtons.OK);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Click event of BackButton that hides current form and displays ProductInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// Click event of aboutToolStripMenuItem that displays AboutForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].Show();
            this.Hide();
        }
      
        /// <summary>
        /// Click event of NewCancel button that exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Click event of exitToolStripMenuItem that exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Click event of printToolStripMenuItem that shows a message dialog with "Printing in Progress" Message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing in Progress","Print");
        }
    }
}
