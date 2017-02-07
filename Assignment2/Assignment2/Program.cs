/**
 * The App name: Sharp Auto Center
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: January 30, 2017
 * App Last Modification Date: February 7, 2017
 * App Short Revision History
 *  - Jan 30, 2017: Apply for Form Design except Menu, Follow name convention.
 *  - Feb  6, 2017: Design Menu, Develop major functions such as calucalation, validation, and shortcut.
 *  - Feb  7, 2017: Fix minor bugs, Add new layout because previous layout can not cover font changes.
 * App description: Calculate the Total Amount Due using data of Base Price, Trade-in Allowance and Additional Options by user interaction. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
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
            Application.Run(new SharpAutoForm());
        }
    }
}
