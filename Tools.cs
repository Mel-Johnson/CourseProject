using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBMFDB
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
    }
    
    private void submitButton_Click(object sender, EventArgs e)
        {
            if (drillCheckBox.Checked)
            {
                MessageBox.Show("You have selected Drill");
            }

            if (impactdriverCheckBox.Checked)
            {
                MessageBox.Show("You have selected Impact Driver");
            }

            if (aircompressorCheckBox.Checked)
            {
                MessageBox.Show("You have selected Air Compressor");
            }

            if (grinderCheckBox.Checked)
            {
                MessageBox.Show("You have selected Grinder");
            }

            if (reciprocatingsawcheckBox.Checked)
            {
                MessageBox.Show("You have selected Reciprocating Saw");
            }

            if (powerratchetsetCheckBox.Checked)
            {
                MessageBox.Show("You have selected Power Ratchet Set");
            }

            if (sidegrinderCheckBox.Checked)
            {
                MessageBox.Show("You have selected Side Grinder");
            }

            if (powersanderCheckBox.Checked)
            {
                MessageBox.Show("You have selected Power Sander");
            }

        }
}
