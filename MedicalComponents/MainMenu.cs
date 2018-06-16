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
            new sp_DBEditing().Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            //new ReportFormController().Show();
        }

        private void buttonPurchasePlan_Click(object sender, EventArgs e)
        {
            new Plans().Show();
            //new EditingOrganisationsWindow().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonSPPRInformation_Click(object sender, EventArgs e)
        {
            new StandartsAdding().Show();
            //new GraphicsForm().Show();
            //new GraphicsModels().Show();
        }

        private void buttonSPPRAdministration_Click(object sender, EventArgs e)
        {
            new GraphsWithCorpuses().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Instruction().Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
