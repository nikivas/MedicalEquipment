using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalComponents.Models;

namespace MedicalComponents
{
    public partial class DBEditing : Form
    {
        public DBEditing()
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

        private void DBEditing_Load(object sender, EventArgs e)
        {
            checkedListBox1.SelectionMode = SelectionMode.One;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablesModel tablesModel = new TablesModel();

            if(checkedListBox1.SelectedIndex == 0)
            {
                tablesModel.FillOrganisation(dataGridView1);
            }
            else if(checkedListBox1.SelectedIndex == 1)
            {

            }
            else if (checkedListBox1.SelectedIndex == 2)
            {

            }
            else if (checkedListBox1.SelectedIndex == 3)
            {

            }
            else if (checkedListBox1.SelectedIndex == 4)
            {

            }
            else if (checkedListBox1.SelectedIndex == 5)
            {

            }
            else if (checkedListBox1.SelectedIndex == 6)
            {

            }
            else if (checkedListBox1.SelectedIndex == 7)
            {

            }
        }
    }
}
