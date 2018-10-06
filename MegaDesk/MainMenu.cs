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
    public partial class MainMenu : Form
    {
        class Desk
        {
            public string CustomerName;
            public int Width;
            public int Depth;
            public int NoOfDrawers;
            public SurfaceMaterial Material;
            public RushOrderDays RushOrderDays;
        };

        enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        };

        enum RushOrderDays
        {
            Three = 3,
            Five = 5,
            Seven = 7,
        };

        public MainMenu()
        {
            InitializeComponent();
            Desk desk = new Desk();
            desk.CustomerName = "Desk Order for Alex Nielson";
            desk.Width = 48;
            desk.Depth = 36;
            desk.NoOfDrawers = 3;
            desk.Material = SurfaceMaterial.Laminate;
            desk.RushOrderDays = RushOrderDays.Seven;
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
    }
}
