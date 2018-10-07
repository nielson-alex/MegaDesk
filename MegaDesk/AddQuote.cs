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

        /********************
        * 1. KeyUp          * 
        ********************/
        // Check to see if the value just intered is an integer
        private void CheckIfChar(object sender, KeyEventArgs e)
        {
            int minValue = 0;
            int maxValue = 0;
            TextBox tb = (TextBox)sender;
            Label errorLabel = findCorrectLabel(tb.Name.Replace("tb", ""));

            switch (tb.Name)
            {
                case "tbWidth":
                    minValue = Desk.MIN_WIDTH;
                    maxValue = Desk.MAX_WIDTH;
                    break;
                case "tbDepth":
                    minValue = Desk.MIN_DEPTH;
                    maxValue = Desk.MAX_DEPTH;
                    break;
                default:
                    break;
            }

            try
            {
                Convert.ToInt32(tb.Text);
                if (errorLabel.Text != string.Empty)
                {
                    errorLabel.Text = string.Empty;
                }

                if (Convert.ToInt32(tb.Text) < minValue)
                {
                    errorLabel.Text = "Value cannot be less than " + minValue.ToString();
                }
                else if (Convert.ToInt32(tb.Text) > maxValue)
                {
                    errorLabel.Text = "Value cannot be greater than " + maxValue.ToString();
                }
            }
            catch
            {
                errorLabel.Text = "Textbox cannot be empty.";
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
            if (ValidateRequirements() == true)
            {
                Desk desk = createDesk();
                DeskQuote deskQuote = createDeskQuote(desk);
                MessageBox.Show("Base Price: $" + DeskQuote.BASE_PRICE + "\n" +
                                "Surface Area Price: $" + deskQuote.SurfaceAreaPrice.ToString() + "\n" +
                                "Drawer Price: $" + deskQuote.DrawerPrice.ToString() + "\n" +
                                "Surface Material Price: $" + deskQuote.SurfaceMaterialPrice.ToString() + "\n" +
                                "Rush Order Price: $" + deskQuote.RushOrderPrice.ToString() + "\n" +
                                "Total Price: $" + deskQuote.GetTotalPrice(DeskQuote.BASE_PRICE,
                                                                            deskQuote.SurfaceAreaPrice,
                                                                            deskQuote.DrawerPrice,
                                                                            deskQuote.SurfaceMaterialPrice,
                                                                            deskQuote.RushOrderPrice)
                );
            }
            else
            {
                MessageBox.Show("There was an error configuring your quote", "Error");
            }

        }

        public bool ValidateRequirements()
        {
            bool allRequirementsFulfilled = false;
            bool tbWidthFulfilled = false;
            bool tbDepthFufilled = false;
            int noOfDrawersChecked = 0;
            int surfaceMaterialsChecked = 0;
            int rushOrderDaysChecked = 0;

            if (tbWidth.Text != string.Empty && tbWidth.Text != null)
            {
                tbWidthFulfilled = true;
            }

            if (tbDepth.Text != string.Empty && tbDepth.Text != null)
            {
                tbDepthFufilled = true;
            }

            foreach (Control c in pnlNoOfDrawers.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        noOfDrawersChecked++;
                    }
                }
            }

            foreach (Control c in pnlMaterialOptions.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        surfaceMaterialsChecked++;
                    }
                }
            }

            foreach (Control c in pnlRushOrderOptions.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        rushOrderDaysChecked++;
                    }
                }
            }

            if (tbWidthFulfilled == true &&
                tbDepthFufilled == true &&
                noOfDrawersChecked > 0 &&
                surfaceMaterialsChecked > 0 &&
                rushOrderDaysChecked > 0)
            {
                allRequirementsFulfilled = true;
            }

            return allRequirementsFulfilled;
        }

        // Create the new desk object
        public Desk createDesk()
        {
            Desk desk = new Desk();
            desk.Width = Convert.ToInt32(tbWidth.Text);
            desk.Depth = Convert.ToInt32(tbDepth.Text);
            getNumberOfDrawers(desk);
            getSurfaceMaterial(desk);
            getRushOrderDays(desk);
            //desk.Days = Desk.RushOrderDays.None;
            return desk;
        }

        // Get the number of desk drawers depending on what radio button is checked
        public void getNumberOfDrawers(Desk desk)
        {
            foreach (Control c in pnlNoOfDrawers.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        switch (rb.Name)
                        {
                            case "rb0":
                                desk.NoOfDrawers = 0;
                                break;
                            case "rb1":
                                desk.NoOfDrawers = 1;
                                break;
                            case "rb2":
                                desk.NoOfDrawers = 2;
                                break;
                            case "rb3":
                                desk.NoOfDrawers = 3;
                                break;
                            case "rb4":
                                desk.NoOfDrawers = 4;
                                break;
                            case "rb5":
                                desk.NoOfDrawers = 5;
                                break;
                            case "rb6":
                                desk.NoOfDrawers = 6;
                                break;
                            case "rb7":
                                desk.NoOfDrawers = 7;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        // Get the desk object's surface material depending on what radio button is checked
        public void getSurfaceMaterial(Desk desk)
        {
            foreach (Control c in pnlMaterialOptions.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        switch(rb.Name)
                        {
                            case "rbLaminate":
                                desk.Material = Desk.SurfaceMaterial.Laminate;
                                break;
                            case "rbOak":
                                desk.Material = Desk.SurfaceMaterial.Oak;
                                break;
                            case "rbRosewood":
                                desk.Material = Desk.SurfaceMaterial.Rosewood;
                                break;
                            case "rbVeneer":
                                desk.Material = Desk.SurfaceMaterial.Veneer;
                                break;
                            case "rbPine":
                                desk.Material = Desk.SurfaceMaterial.Pine;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        // Get the desk object's surface material depending on what radio button is checked
        public void getRushOrderDays(Desk desk)
        {
            foreach (Control c in pnlRushOrderOptions.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        switch (rb.Name)
                        {
                            case "rb0":
                                desk.Days = Desk.RushOrderDays.None;
                                break;
                            case "rb3":
                                desk.Days = Desk.RushOrderDays.Three;
                                break;
                            case "rb5":
                                desk.Days = Desk.RushOrderDays.Five;
                                break;
                            case "rb7":
                                desk.Days = Desk.RushOrderDays.Seven;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        // Create the new desk quote object
        public DeskQuote createDeskQuote(Desk desk)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.GetSurfaceAreaPrice(desk.Width, desk.Depth);
            deskQuote.GetDrawerPrice(desk.NoOfDrawers);
            deskQuote.GetSurfaceMaterialPrice(desk.Material);
            deskQuote.GetRushOrderPrice(desk.Days, desk.Width, desk.Depth);

            return deskQuote;
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

        private void ValidateTBDepth(object sender, KeyPressEventArgs e)
        {

        }
    }
}
