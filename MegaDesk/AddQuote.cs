using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        /****************************
        * Variable Declaration      * 
        ****************************/
        const int MAX_WIDTH = 48;
        const int MIN_WIDTH = 0;
        const int MAX_DEPTH = 48;
        const int MIN_DEPTH = 0;

        /********************
        * 1. KeyUp          * 
        ********************/
        // Check to see if the value just intered is an integer
        private void CheckIfChar(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Label errorLabel = findCorrectLabel(tb.Name.Replace("tb", ""));
            try
            {
                Convert.ToInt32(tb.Text);
                if (errorLabel.Text != string.Empty)
                {
                    errorLabel.Text = string.Empty;
                }
            }
            catch
            {
                errorLabel.Text = "Please enter valid whole numbers.";
                if (tb.Text.Length >= 1)
                {
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1, 1);
                }
                else
                {
                    tb.Text = string.Empty;
                }
            }
        }

        /********************
        * 2. OnLeave        * 
        ********************/
        // Check to see if the entered number is smaller than the minimum value or larger than the maximum value
        private void checkIfTooBigOrSmall(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Label errorLabel = findCorrectLabel(tb.Name.Replace("tb", ""));
            try
            {
                Convert.ToInt32(tb.Text);

                if (Convert.ToInt32(tb.Text) < MIN_WIDTH || Convert.ToInt32(tb.Text) < MIN_DEPTH)
                {
                    errorLabel.Text = "Value cannot be less than " + MIN_WIDTH.ToString();
                }
                else if (Convert.ToInt32(tb.Text) > MAX_WIDTH || Convert.ToInt32(tb.Text) > MAX_DEPTH)
                {
                    errorLabel.Text = "Value cannot be greater than " + MAX_WIDTH.ToString();
                }
            }
            catch
            {
                errorLabel.Text = "Please enter a valid whole number";
                tb.Focus();
            }
        }

        // Get the correct error label for the corresponding textbox
        private Label findCorrectLabel(string senderName)
        {
            Label errorLabel = new Label();
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (c.Name == "lbl" + senderName + "Error")
                    {
                        errorLabel = (Label)c;
                    }
                }
            }
            return errorLabel;
        }

        /********************
        * 3. btnSubmit      * 
        ********************/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TextBox[] textboxes = { tbWidth, tbDepth };
            Label[] errorLabels = { lblWidthError, lblDepthError };

            foreach (Label lbl in errorLabels)
            {
                lbl.Text = string.Empty;
            }

            int validNumbers = 0;

            for (int i = 0; i < textboxes.Length; i++)
            {
                if (checkIfNumber(textboxes[i], errorLabels[i]) == true)
                {
                    validNumbers++;
                }
            }

            if (validNumbers == textboxes.Length)
            {

            }
            else
            {
                lblSubmitError.Text = "Not all values entered are valid whole number.";
            }
        }

        // Check to see if the values in the TextBoxes are numbers or not
        private bool checkIfNumber(TextBox tb, Label lbl)
        {
            bool isANumber = false;
            try
            {
                Convert.ToInt32(tb.Text);
                isANumber = true;
            }
            catch
            {
                lbl.Text = "Please enter a valid whole number.";
            }
            return isANumber;
        }

        /********************
        * 4. btnCancel      * 
        ********************/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
