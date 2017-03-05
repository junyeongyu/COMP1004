using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            this.splashFormTimer.Enabled = false;
            this.Hide();

            // One. Instantiate the next form
            SelectionForm selectionForm = new SelectionForm();
            
            // Two. show next form
            selectionForm.Show();
        }
    }
}
