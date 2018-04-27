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
    public partial class DBEditingV3 : Form
    {
        public DBEditingV3()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new EditingOrganisationsWindow().Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            new EditingOrganisationsWindow().Show();
        }
    }
}
