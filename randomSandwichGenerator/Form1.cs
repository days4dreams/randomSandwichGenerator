using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomSandwichGenerator
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();

            SandwichMaker menu = new SandwichMaker()
            { Randomizer = new Random() };
            //initialise a ref to SandwichMaker object and new instance of Random class

            SandwichOne.Text = "1. " + menu.GetMenuItem();
            SandwichTwo.Text = "2. " + menu.GetMenuItem();
            SandwichThree.Text = "3. " + menu.GetMenuItem();
            SandwichFour.Text = "4. " + menu.GetMenuItem();
            //call the GetMenuItem method four times to select sandwich varieties and set copy of labels
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subIntroLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
