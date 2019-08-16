using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_FORM, new SplashForm());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new AboutForm());
            Application.Run(new SplashForm());
        }
    }
}
