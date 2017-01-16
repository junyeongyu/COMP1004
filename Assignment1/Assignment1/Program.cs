﻿/**
 * 
 * The App name: Sharp Mail Order – SALES BONUS
 * Author's name: Junyeong Yu
 * App Creation Date: January 16, 2017
 * App description: Entrance point to load MailOrder Form.
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