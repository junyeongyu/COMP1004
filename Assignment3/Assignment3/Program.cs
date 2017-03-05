using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(getInitialForm());
        }

        static Form getInitialForm()
        {
            // Initialize Objects
            SplashForm splashForm = new SplashForm();
            SelectionForm selectionForm = new SelectionForm();
            OrderForm orderForm = new OrderForm();

            // Inject Objects
            splashForm.selectionForm = selectionForm;
            selectionForm.orderForm = orderForm;

            return splashForm;
        }
    }
}
