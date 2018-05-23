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
                tablesModel.FillModelTypes(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                tablesModel.FillModelElement(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                tablesModel.FillPhysicalPeople(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                tablesModel.FillPhysicalPeoplePositions(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                tablesModel.FillMOExpluatation(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 6)
            {
                tablesModel.FillElementsDragMetal(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 7)
            {
                tablesModel.FillPersonalOnService(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 8)
            {
                tablesModel.FillPurchase(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 9)
            {
                tablesModel.FillZipOnStock(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 10)
            {
                tablesModel.FillZIPMoves(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 11)
            {
                tablesModel.FillPMOnStock(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 12)
            {
                tablesModel.FillPMMoves(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 13)
            {
                tablesModel.FillPurchaseElement(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 14)
            {
                tablesModel.FillZIPDocumentsOnPurchase(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 15)
            {
                tablesModel.FillPMDocumentsOnPurchase(dataGridView1);
            }
        }
    }
}
