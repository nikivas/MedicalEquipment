using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalComponents
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonTableEditing_Click(object sender, EventArgs e)
        {
            new DBEditing().Show();
        }

        private void buttonHelpTableEditing_Click(object sender, EventArgs e)
        {
            new DBEditingV2().Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            new DBEditingV3().Show();
        }

        private void buttonPurchasePlan_Click(object sender, EventArgs e)
        {
            new EditingOrganisationsWindow().Show();
        }
    }
}
