
using Assignment4.Models;
/**
* The App name: Dollor Computers
* Author's name: Junyeong Yu (200328206)
* App Creation Date: March 7, 2017
* App Last Modification Date: March 7, 2017
* App Short Revision History
*  - 07:40 PM  Mar 07, 2017: Apply for Form Design and follow name convention.
*  - 09:00 PM, Mar 07, 2017: Implement minor functions of StartForm and SelectForm.
*  - 00:40 AM, Mar 14, 2017: Finish All functions of SelectForm.
*  - 00:40 AM, Mar 15, 2017: Finish All functions of ProductInfoForm except of file process. AboutForm in OrderForm is made.
*  - 00:00 PM, Mar 07, 2017: 
*  - 00:00 PM, Mar 07, 2017: 
* App description: Create a multi-form project that simulates a computer purchase. 
*                  Give the user an option to “start a new order” or “load a saved order”
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
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
            SplashScreen splashScreen = new SplashScreen();
            StartForm startForm = new StartForm();
            SelectForm selectForm = new SelectForm();
            ProductContext productContext = new ProductContext();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            OrderForm orderForm = new OrderForm();

            // Inject Objects
            splashScreen.startForm = startForm; // to move to start form after 3 seconds

            startForm.splashScreen = splashScreen; // for closing form
            startForm.selectForm = selectForm; // for next step

            selectForm.splashScreen = splashScreen; // for closing form
            selectForm.productInfoForm = productInfoForm; // for next step
            selectForm.productContext = productContext; // for loading data from db

            productInfoForm.splashScreen = splashScreen; // for closing form
            productInfoForm.selectForm = selectForm; // to move to select form
            productInfoForm.orderForm = orderForm; // to move to order form

            return splashScreen;
        }
    }
}