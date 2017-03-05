/**
 * The App name: Movie Bonanza
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: Feburary 13, 2017
 * App Last Modification Date: March 5, 2017
 * App Short Revision History
 *  -           Feb 13, 2017: Apply for Form Design and follow name convention.
 *  - 02:00 AM, Mar 05, 2017: Add new forms & change component names properly.
 *  - 04:00 AM, Mar 05, 2017: Apply for all images & finish SelectionForm.
 *  - 04:30 PM, Mar 05, 2017: Finish about form and order form functionalities.
 *  - 05:00 PM, Mar 05, 2017: Finish StreamForm functionalities.
 *  - 05:40 PM, Mar 05, 2017: Test application & add all necessary comments.
 * App description: Create a multi-form project that allows the user to select a Movie
 *                  to view from an online video streaming service called “Movie Bonanza”
 */
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

        /// <summary>
        /// Provide initial form in order for application to load it
        /// </summary>
        /// <returns></returns>
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

            streamForm.splashForm = splashForm; // for closing form
            streamForm.orderForm = orderForm; // previous form

            return splashForm;
        }
    }
}