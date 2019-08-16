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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event handler for NewOrderButton that displays SelectForm and Hides current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// Event handler for OpenOrderButton that hides current form and displays ProductInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            ProductInfoForm.OpenFileDialog1();
        }
    }
}
