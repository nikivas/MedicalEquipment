using MedicalComponents.Editings.sp;
using MedicalComponents.Models;
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
    public partial class sp_DBEditing : Form
    {
        public sp_DBEditing()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                    continue;
                }
                checkedListBox1.SetItemCheckState(i,CheckState.Unchecked);
            }
            TablesModel tablesModel = new TablesModel();

            if (checkedListBox1.SelectedIndex == 0)
            {
                tablesModel.Fillsp_OrganisationType(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                tablesModel.Fillsp_Country(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                tablesModel.Fillsp_FunctionalyUseModel(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                tablesModel.Fillsp_ReasonWriteoff(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                tablesModel.Fillsp_PhysicalPeoplePositions(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                tablesModel.Fillsp_ExpluatationRole(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 6)
            {
                tablesModel.Fillsp_OrganisationDepartment(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 7)
            {
                tablesModel.Fillsp_Corpus(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 8)
            {
                tablesModel.Fillsp_MoveReason(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 9)
            {
                tablesModel.Fillsp_DragMetal(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 10)
            {
                tablesModel.Fillsp_ServiceType(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 11)
            {
                tablesModel.Fillsp_ServiceOperationType(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 12)
            {
                tablesModel.Fillsp_ServiceOperationPersonalRole(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 13)
            {
                tablesModel.Fillsp_PurchaseType(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 14)
            {
                tablesModel.Fillsp_ZIP(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 15)
            {
                tablesModel.Fillsp_PM(dataGridView1);
            }
            else if (checkedListBox1.SelectedIndex == 16)
            {
                tablesModel.Fillsp_BrokenRequestReason(dataGridView1);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
                return;
            else if(checkedListBox1.SelectedIndex == 0)
            {
                new sp_OrganisationTypeEdit().Show();

            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                new sp_CountryEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                new sp_FunctionalUseModelEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                new sp_ReasonWriteOffEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                new sp_PhysicalPeoplePositionEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                new sp_ExpluatationRoleEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 6)
            {
                new sp_OrganisationDepartmentEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 7)
            {
                new sp_CorpusEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 8)
            {
                new sp_MoveReasonEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 9)
            {
                new sp_DragMetalEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 10)
            {
                new sp_ServiceTypeEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 11)
            {
                new sp_ServiceOperationTypeEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 12)
            {
                new sp_ServiceOperationPersonalRoleEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 13)
            {
                new sp_PurchaseTypeEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 14)
            {
                new sp_ZIPEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 15)
            {
                new sp_PMEdit().Show();
            }
            else if (checkedListBox1.SelectedIndex == 16)
            {
                new sp_BrokenRequestReasonEdit().Show();
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
            else if (checkedListBox1.SelectedIndex == 0)
            {
                new sp_OrganisationTypeEdit(selectedId).Show();
            }
            else if(checkedListBox1.SelectedIndex == 1)
            {
                new sp_CountryEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                new sp_FunctionalUseModelEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                new sp_ReasonWriteOffEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                new sp_PhysicalPeoplePositionEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                new sp_ExpluatationRoleEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 6)
            {
                new sp_OrganisationDepartmentEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 7)
            {
                new sp_CorpusEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 8)
            {
                new sp_MoveReasonEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 9)
            {
                new sp_DragMetalEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 10)
            {
                new sp_ServiceTypeEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 11)
            {
                new sp_ServiceOperationTypeEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 12)
            {
                new sp_ServiceOperationPersonalRoleEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 13)
            {
                new sp_PurchaseTypeEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 14)
            {
                new sp_ZIPEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 15)
            {
                new sp_PMEdit(selectedId).Show();
            }
            else if (checkedListBox1.SelectedIndex == 16)
            {
                new sp_BrokenRequestReasonEdit(selectedId).Show();
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
                    TablesModel.entities.sp_OrganisationType.Remove(TablesModel.entities.sp_OrganisationType.Where(x => x.organisation_type_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 1)
                {
                    TablesModel.entities.sp_CountryKey.Remove(TablesModel.entities.sp_CountryKey.Where(x => x.country_key_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 2)
                {
                    TablesModel.entities.sp_FunctionalyUseModel.Remove(TablesModel.entities.sp_FunctionalyUseModel.Where(x => x.functionaly_use_model_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 3)
                {
                    TablesModel.entities.sp_ReasonWriteOff.Remove(TablesModel.entities.sp_ReasonWriteOff.Where(x => x.reason_write_off_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 4)
                {
                    TablesModel.entities.sp_PysicalPeoplePositions.Remove(TablesModel.entities.sp_PysicalPeoplePositions.Where(x => x.physical_people_position_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 5)
                {
                    TablesModel.entities.sp_ExpluatationRole.Remove(TablesModel.entities.sp_ExpluatationRole.Where(x => x.expluatation_role_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 6)
                {
                    TablesModel.entities.sp_OrganisationDepartment.Remove(TablesModel.entities.sp_OrganisationDepartment.Where(x => x.organisation_department_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 7)
                {
                    TablesModel.entities.sp_Corpus.Remove(TablesModel.entities.sp_Corpus.Where(x => x.corpus_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 8)
                {
                    TablesModel.entities.sp_MoveReason.Remove(TablesModel.entities.sp_MoveReason.Where(x => x.move_reason_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 9)
                {
                    TablesModel.entities.sp_DragMetal.Remove(TablesModel.entities.sp_DragMetal.Where(x => x.drag_metal_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 10)
                {
                    TablesModel.entities.sp_ServiceType.Remove(TablesModel.entities.sp_ServiceType.Where(x => x.service_type_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 11)
                {
                    TablesModel.entities.sp_ServiceOperationType.Remove(TablesModel.entities.sp_ServiceOperationType.Where(x => x.service_operation_type_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 12)
                {
                    TablesModel.entities.sp_ServiceOperationPersonalRole.Remove(TablesModel.entities.sp_ServiceOperationPersonalRole.Where(x => x.service_operation_personal_role_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 13)
                {
                    TablesModel.entities.sp_PurchaseType.Remove(TablesModel.entities.sp_PurchaseType.Where(x => x.purchase_type_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 14)
                {
                    TablesModel.entities.sp_ZIP_AND_PM_Element.Remove(TablesModel.entities.sp_ZIP_AND_PM_Element.Where(x => x.zipPM_element_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 15)
                {
                    TablesModel.entities.sp_ZIP_AND_PM_Element.Remove(TablesModel.entities.sp_ZIP_AND_PM_Element.Where(x => x.zipPM_element_id == selectedId).First());
                }
                else if (checkedListBox1.SelectedIndex == 16)
                {
                    TablesModel.entities.sp_BrokenRequestReason.Remove(TablesModel.entities.sp_BrokenRequestReason.Where(x => x.broken_request_reason_id == selectedId).First());
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
