/**
 * The App name: Dollor Computers
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: March 7, 2017
 * App Last Modification Date: March 7, 2017
 * App Short Revision History
 *  - 07:40 PM  Mar 07, 2017: Apply for Form Design and follow name convention.
 *  - 00:00 AM, Mar 07, 2017: 
 *  - 00:00 AM, Mar 07, 2017: 
 *  - 00:00 PM, Mar 07, 2017: 
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

            // Inject Objects
            splashScreen.startForm = startForm;

            return splashScreen;
        }
    }
}