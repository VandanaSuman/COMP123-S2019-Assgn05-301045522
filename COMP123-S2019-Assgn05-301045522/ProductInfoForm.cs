using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();
        }

        private void ProductInfoFormCancelLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
