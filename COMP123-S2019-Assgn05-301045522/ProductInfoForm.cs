using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assgn05_301045522
{

    public partial class ProductInfoForm : Form
    {
        
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoFormNextLabel_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.NewConditionTextBox.Text = ConditionTextBox.Text;
            orderForm.NewPlatformTextBox.Text = PlatformTextBox.Text;
            orderForm.NewManufacturerTextBox.Text = ManufacturerTextBox.Text;
            orderForm.NewModelTextBox.Text = ModelTextBox.Text;
            orderForm.ComponentsTextBox.Text = LCDTextBox.Text + "\r\n"+ "\r\n" + MemoryTextBox.Text + "\r\n" + "\r\n" + CPUBrandTextBox.Text + "\r\n" + "\r\n" + TypeTextBox.Text + "\r\n" + "\r\n" + CPUNumTextBox.Text + "\r\n" + "\r\n" + SpeedTextBox.Text + "\r\n" + "\r\n" + HDDTextBox.Text + "\r\n" + "\r\n" + GPUTextBox.Text + "\r\n" + "\r\n" + WebcamTextBox.Text + "\r\n" + "\r\n" + OSTextBox.Text;
            orderForm.PriceTextBox.Text = CostTextBox.Text;
            double tax = 0.18 * Convert.ToDouble(CostTextBox.Text);
            double cost = Convert.ToDouble(CostTextBox.Text);
            double total = tax + cost;
            orderForm.SalesTaxTextBox.Text = tax.ToString();
            orderForm.TotalTextBox.Text = total.ToString();

            orderForm.Show();
            this.Hide();
        }


        private void ProductInfoFormCancelLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Program.Forms[FormNames.ABOUT_FORM].Show();
            this.Hide();
        }
        //Resource: https://www.youtube.com/watch?v=FJ5rNOMTZ9w
        public static void OpenFileDialog1()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string file = openFileDialog1.FileName;
                //MessageBox.Show(file);
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
           
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm.OpenFileDialog1();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Product.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());


                writer.Dispose();

                writer.Close();

            }
        }

        private void AnotherProductLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.SELECT_FORM].Show();
        }
    }
}
