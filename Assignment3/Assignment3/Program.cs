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
            StreamForm streamForm = new StreamForm();

            // Inject Objects
            splashForm.selectionForm = selectionForm; // for continuing next form

            selectionForm.orderForm = orderForm; // for continuing next form

            orderForm.splashForm = splashForm; // for closing form
            orderForm.selectionForm = selectionForm; // for using selected data
            orderForm.streamForm = streamForm; // for next step form

            return splashForm;
        }
    }
}
