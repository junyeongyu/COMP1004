using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class StartForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private SelectForm _selectForm; // injected - next form
        
        public SplashScreen splashScreen { get; set; }
        public SelectForm selectForm { get; set; }
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void startNewOrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            selectForm.Show();
        }

        private void openSavedOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }
    }
}
