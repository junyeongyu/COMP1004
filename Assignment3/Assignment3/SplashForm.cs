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
        private SelectionForm _selectionForm; // injected

        public SelectionForm selectionForm { get; set; }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            splashFormTimer.Enabled = false;
            Hide();
            
            // show next form
            selectionForm.Show();
        }
    }
}
