/**
 * The class name: SelectionForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: Feburary 13, 2017
 * Class Last Modification Date: March 5, 2017
 * Class description: Select movie from dropdown box for next step.
 */
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
    public partial class SelectionForm : Form
    {
        private OrderForm _orderForm; // injected - next form

        private Dictionary<string, string> _movieDictionary = new Dictionary<string, string>(); // movie & category mapping
        private Dictionary<string, Bitmap> _movieBitmapDictionary = new Dictionary<string, Bitmap>(); // movie & bitmap mapping
        private Dictionary<string, double> _categoryDictinary = new Dictionary<string, double>(); // category & cost mapping
        private string[] _userSelection = new string[3];

        public OrderForm orderForm { get; set; }
        public string title { get { return _userSelection[0];} }
        public string category { get { return _userSelection[1];} }
        public double cost { get { return double.Parse(_userSelection[2]);} }
        public Bitmap image { get { return _movieBitmapDictionary[title];} }

        /// <summary>
        /// Default constructor for initializing component & data
        /// </summary>
        public SelectionForm()
        {
            InitializeComponent();

            _addInitialData();
        }

        /// <summary>
        /// Add all necessary data
        /// </summary>
        private void _addInitialData()
        {
            // add movies with category
            _movieDictionary.Add("Season of the Witch", "Sci - Fi");
            _movieDictionary.Add("The Green Hornet", "Action");
            _movieDictionary.Add("The Dilemma", "Comedy");
            _movieDictionary.Add("Death Race 2", "Action");
            _movieDictionary.Add("Company Men", "Drama");
            _movieDictionary.Add("No Strings Attached", "Comedy");
            _movieDictionary.Add("The Way Back", "Drama");
            _movieDictionary.Add("The Mechanic", "Action");
            _movieDictionary.Add("The Rite", "Horror");
            _movieDictionary.Add("Sanctum", "Action");
            _movieDictionary.Add("The Other Woman", "Action");
            _movieDictionary.Add("The Roommate", "Thriller");
            _movieDictionary.Add("Waiting for Forever", "Drama");
            _movieDictionary.Add("Cedar Rapids", "Comedy");
            _movieDictionary.Add("Gnomeo and Juliet", "Family");
            _movieDictionary.Add("Just Go With It", "Comedy");
            _movieDictionary.Add("The Eagle", "Action");
            _movieDictionary.Add("I am Number Four", "Sci - Fi");
            _movieDictionary.Add("Footloose", "New Release");
            _movieDictionary.Add("Real Steel", "New Release");

            // add movies with bitmap
            _movieBitmapDictionary.Add("Season of the Witch", Properties.Resources.Season_of_the_Witch);
            _movieBitmapDictionary.Add("The Green Hornet", Properties.Resources.The_Green_Hornet);
            _movieBitmapDictionary.Add("The Dilemma", Properties.Resources.The_Dilemma);
            _movieBitmapDictionary.Add("Death Race 2", Properties.Resources.Death_Race_2);
            _movieBitmapDictionary.Add("Company Men", Properties.Resources.Company_Men);
            _movieBitmapDictionary.Add("No Strings Attached", Properties.Resources.No_Strings_Attached);
            _movieBitmapDictionary.Add("The Way Back", Properties.Resources.The_Way_Back);
            _movieBitmapDictionary.Add("The Mechanic", Properties.Resources.The_Mechanic);
            _movieBitmapDictionary.Add("The Rite", Properties.Resources.The_Rite);
            _movieBitmapDictionary.Add("Sanctum", Properties.Resources.Sanctum);
            _movieBitmapDictionary.Add("The Other Woman", Properties.Resources.The_Other_Woman);
            _movieBitmapDictionary.Add("The Roommate", Properties.Resources.The_Roommate);
            _movieBitmapDictionary.Add("Waiting for Forever", Properties.Resources.Waiting_for_Forever);
            _movieBitmapDictionary.Add("Cedar Rapids", Properties.Resources.Cedar_Rapids);
            _movieBitmapDictionary.Add("Gnomeo and Juliet", Properties.Resources.Gnomeo_and_Juliet);
            _movieBitmapDictionary.Add("Just Go With It", Properties.Resources.Just_Go_With_It);
            _movieBitmapDictionary.Add("The Eagle", Properties.Resources.The_Eagle);
            _movieBitmapDictionary.Add("I am Number Four", Properties.Resources.I_am_Number_Four);
            _movieBitmapDictionary.Add("Footloose", Properties.Resources.Footloose);
            _movieBitmapDictionary.Add("Real Steel", Properties.Resources.Real_Steel);

            // add categories with price
            _categoryDictinary.Add("Comedy", 1.99);
            _categoryDictinary.Add("Drama", 1.99);
            _categoryDictinary.Add("Action", 2.99);
            _categoryDictinary.Add("Sci - Fi", 2.99);
            _categoryDictinary.Add("Horror", 2.99);
            _categoryDictinary.Add("Thriller", 1.99);
            _categoryDictinary.Add("Family", 0.99);
            _categoryDictinary.Add("New Release", 4.99);
        }

        /// <summary>
        /// add all movies into proper component & set default image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            // Add all movies into ListBox
            foreach (string key in _movieDictionary.Keys)
            {
                currentMoviesListBox.Items.Add(key);
            }

            // Set default image
            yourSelectionPictureBox.Image = Properties.Resources.No_Image;
        }

        /// <summary>
        /// Whenever movie is selected, values in textboxes are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox) sender;
            string movieName = listBox.SelectedItem.ToString();
            string category = _movieDictionary[movieName];
            string cost = _categoryDictinary[category].ToString();

            // set data into UI components
            yourSelectionPictureBox.Image = _movieBitmapDictionary[movieName];
            titleTextBox.Text = movieName;
            categoryTextBox.Text = category;
            costTextBox.Text = "$" + cost;
            nextButton.Enabled = true;

            _userSelection[0] = movieName;
            _userSelection[1] = category;
            _userSelection[2] = cost;
        }

        /// <summary>
        /// Move to order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (orderForm.isLoaded) // the reason why isLoaded is checked is load event occurs only one time
            {
                orderForm.refreshData();
            }
            orderForm.Show();
        }
    }
}