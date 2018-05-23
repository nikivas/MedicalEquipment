using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalComponents.Editings;
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
            
            if (checkedListBox1.SelectedIndex == -1)
                return;
            else if(checkedListBox1.SelectedIndex == 0)
            {
                new EditingOrganisationsWindow().Show();
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                new EditingModelType().Show();
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                new EditingEquipmentObject().Show();
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                new EditingPhysicalPeople().Show();
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                new EditingPhysicalPeoplePosition().Show();
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
            else if (checkedListBox1.SelectedIndex == 8)
            {

            }
            else if (checkedListBox1.SelectedIndex == 9)
            {

            }
            else if (checkedListBox1.SelectedIndex == 10)
            {

            }
            else if (checkedListBox1.SelectedIndex == 11)
            {

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("выберите ячейку!");
                return;
            }
            var selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            if (checkedListBox1.SelectedIndex == -1)
                return;
            else if(checkedListBox1.SelectedIndex == 0)
            {
                new EditingOrganisationsWindow(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                new EditingModelType(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                new EditingEquipmentObject(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                new EditingPhysicalPeople(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                new EditingPhysicalPeoplePosition(selectedId).Show();
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
            else if (checkedListBox1.SelectedIndex == 8)
            {

            }
            else if (checkedListBox1.SelectedIndex == 9)
            {

            }
            else if (checkedListBox1.SelectedIndex == 10)
            {

            }
        }

        private void DBEditing_Load(object sender, EventArgs e)
        {
            checkedListBox1.SelectionMode = SelectionMode.One;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == checkedListBox1.SelectedIndex)
                    continue;
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("выберите ячейку!");
                return;
            }
            var selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                if (checkedListBox1.SelectedIndex == -1)
                    return;
                else if (checkedListBox1.SelectedIndex == 0)
                {
                    TablesModel.entities.Organisations.Remove(TablesModel.entities.Organisations.Where(x => x.organisation_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 1)
                {
                    TablesModel.entities.ModelType.Remove(TablesModel.entities.ModelType.Where(x => x.model_type_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 2)
                {
                    TablesModel.entities.ModelElement.Remove(TablesModel.entities.ModelElement.Where(x => x.model_element_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 3)
                {
                    TablesModel.entities.PhysicalPeople.Remove(TablesModel.entities.PhysicalPeople.Where(x => x.physical_people_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 4)
                {
                    TablesModel.entities.FaticalPhysicalPeoplePositions.Remove(TablesModel.entities.FaticalPhysicalPeoplePositions.Where(x => x.fatical_physical_people_position_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 5)
                {
                    TablesModel.entities.MOExpluatation.Remove(TablesModel.entities.MOExpluatation.Where(x => x.mo_expluatation_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 6)
                {
                    TablesModel.entities.ElementsDragMetal.Remove(TablesModel.entities.ElementsDragMetal.Where(x => x.elements_drag_metal_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 7)
                {
                    TablesModel.entities.PersonalOnService.Remove(TablesModel.entities.PersonalOnService.Where(x => x.personal_on_service_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 8)
                {
                    TablesModel.entities.Purchase.Remove(TablesModel.entities.Purchase.Where(x => x.purchase_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 9)
                {
                    TablesModel.entities.ZIPPMonStock.Remove(TablesModel.entities.ZIPPMonStock.Where(x => x.zipPM_on_stock_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 10)
                {
                    TablesModel.entities.ZIPPMMoves.Remove(TablesModel.entities.ZIPPMMoves.Where(x => x.zipPM_move_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 11)
                {
                    TablesModel.entities.ZIPPMonStock.Remove(TablesModel.entities.ZIPPMonStock.Where(x => x.zipPM_on_stock_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 12)
                {
                    TablesModel.entities.ZIPPMMoves.Remove(TablesModel.entities.ZIPPMMoves.Where(x => x.zipPM_move_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 13)
                {
                    TablesModel.entities.PurchaseElements.Remove(TablesModel.entities.PurchaseElements.Where(x => x.purchase_element_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 14)
                {
                    TablesModel.entities.ZIPPMDocumentsOnPurchase.Remove(TablesModel.entities.ZIPPMDocumentsOnPurchase.Where(x => x.zipPM_documents_purchase_id== selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 15)
                {
                    TablesModel.entities.ZIPPMDocumentsOnPurchase.Remove(TablesModel.entities.ZIPPMDocumentsOnPurchase.Where(x => x.zipPM_documents_purchase_id == selectedId).First());
                }
                
                TablesModel.entities.SaveChanges();
                MessageBox.Show("Успешно удалено");
                checkedListBox1_SelectedIndexChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("непредвиденная ситуация, база данных выполняет другую операцию, дождитесь ее окончания и попробуйте позже");
            }
        }
    }
}
