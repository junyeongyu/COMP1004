/**
 * The App name: Sharp Mail Order – SALES BONUS
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: January 16, 2017
 * App Last Modification Date: January 24, 2017
 * App Short Revision History
 *  - Jan 16, 2017: Apply for Form Design, Develop basic functionality.
 *  - Jan 18, 2017: Add validation for submit
 *  - Jan 23, 2017: Localize using locale properties. Adjust start position of form.
 *  - Jan 24, 2017: Fix size of the application. Add the comments which the professor asked.
 * App description: Calculate Sales Bonus using data of Total Hours Worked and Total Monthly Sales through user interface. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
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
            Application.Run(new MailOrder());
        }
    }
}
