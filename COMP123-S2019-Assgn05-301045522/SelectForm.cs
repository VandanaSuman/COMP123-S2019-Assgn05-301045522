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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event of NextButton transfers user's selection to ProductInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.ProductIDTextBox.Text = ProductDataGridView.CurrentRow.Cells[0].Value.ToString();
            productInfoForm.ConditionTextBox.Text = ProductDataGridView.CurrentRow.Cells[14].Value.ToString();
            productInfoForm.CostTextBox.Text = ProductDataGridView.CurrentRow.Cells[1].Value.ToString();
            productInfoForm.PlatformTextBox.Text = ProductDataGridView.CurrentRow.Cells[16].Value.ToString();
            productInfoForm.OSTextBox.Text = ProductDataGridView.CurrentRow.Cells[15].Value.ToString();
            productInfoForm.ManufacturerTextBox.Text = ProductDataGridView.CurrentRow.Cells[2].Value.ToString();
            productInfoForm.ModelTextBox.Text = ProductDataGridView.CurrentRow.Cells[3].Value.ToString();
            productInfoForm.MemoryTextBox.Text = ProductDataGridView.CurrentRow.Cells[5].Value.ToString();
            productInfoForm.LCDTextBox.Text = ProductDataGridView.CurrentRow.Cells[7].Value.ToString();
            productInfoForm.HDDTextBox.Text = ProductDataGridView.CurrentRow.Cells[17].Value.ToString();
            productInfoForm.CPUBrandTextBox.Text = ProductDataGridView.CurrentRow.Cells[10].Value.ToString();
            productInfoForm.CPUNumTextBox.Text = ProductDataGridView.CurrentRow.Cells[13].Value.ToString();
            productInfoForm.GPUTextBox.Text = ProductDataGridView.CurrentRow.Cells[19].Value.ToString();
            productInfoForm.TypeTextBox.Text = ProductDataGridView.CurrentRow.Cells[11].Value.ToString();
            productInfoForm.SpeedTextBox.Text = ProductDataGridView.CurrentRow.Cells[12].Value.ToString();
            productInfoForm.WebcamTextBox.Text = ProductDataGridView.CurrentRow.Cells[30].Value.ToString();
            productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Click event of Cancel Button exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Load event of Select form Loads the datagrid view with data from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            //// TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }
        /// <summary>
        /// CellClick event of ProductDatGridView Selects full row and displays user's selection in SelectionTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ProductDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ProductDataGridView.CurrentRow.Selected = true;
                SelectionTextBox.Text = "Model: " + ProductDataGridView.Rows[e.RowIndex].Cells["modelDataGridViewTextBoxColumn"].FormattedValue.ToString()+ ", " +"Manufacturer: "+ProductDataGridView.Rows[e.RowIndex].Cells["manufacturerDataGridViewTextBoxColumn"].FormattedValue.ToString()+", "+ "Cost: "+ProductDataGridView.Rows[e.RowIndex].Cells["costDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }
        }


    }
}
