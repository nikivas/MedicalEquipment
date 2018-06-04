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

namespace MedicalComponents.Editings
{
    public partial class EditingPersonalOnService : Form
    {
        public int id = -1;
        public EditingPersonalOnService()
        {
            InitializeComponent();
        }

        public EditingPersonalOnService(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditingPersonalOnService_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.PersonalOnService.Where(x => x.personal_on_service_id== id).First();
                    

                    for (int i = 0; i < comboBoxFIO.Items.Count; i++)
                    {
                        var cmbEl = comboBoxFIO.Items[i] as dynamic;
                        if (cmbEl.id == el.physical_people_id)
                            comboBoxFIO.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxModelElement.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModelElement.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModelElement.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxRole.Items.Count; i++)
                    {
                        var cmbEl = comboBoxRole.Items[i] as dynamic;
                        if (cmbEl.id == el.service_operation_personal_role_id)
                            comboBoxRole.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxServiceOperation.Items.Count; i++)
                    {
                        var cmbEl = comboBoxServiceOperation.Items[i] as dynamic;
                        if (cmbEl.id == el.service_operation_type_id)
                            comboBoxServiceOperation.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxServiceType.Items.Count; i++)
                    {
                        var cmbEl = comboBoxServiceType.Items[i] as dynamic;
                        if (cmbEl.id == el.service_type_id)
                            comboBoxServiceType.SelectedIndex = i;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }
        }

        public void initComboBoxes()
        {
            ComboBoxWorker.initFIO(comboBoxFIO);
            ComboBoxWorker.initModelElement(comboBoxModelElement);
            ComboBoxWorker.initServiceOperationRole(comboBoxRole);
            ComboBoxWorker.initServiceOperation(comboBoxServiceOperation);
            ComboBoxWorker.initServiceType(comboBoxServiceType);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.PersonalOnService.Count() == 0 ? 0 : TablesModel.entities.PersonalOnService.Max(x => x.personal_on_service_id) + 1;
                    TablesModel.entities.PersonalOnService.Add(new Models.PersonalOnService()
                    {
                        personal_on_service_id = addId,
                        physical_people_id = (int)comboBoxFIO.SelectedValue,
                        service_type_id = (int) comboBoxServiceType.SelectedValue,
                        service_operation_type_id = (int)comboBoxServiceOperation.SelectedValue,
                        service_operation_personal_role_id = (int)comboBoxRole.SelectedValue,
                        model_element_id = (int) comboBoxModelElement.SelectedValue
                      
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.PersonalOnService.Where(x => x.personal_on_service_id== id).First();
                    el.physical_people_id = (int)comboBoxFIO.SelectedValue;
                    el.service_type_id = (int)comboBoxServiceType.SelectedValue;
                    el.service_operation_type_id = (int)comboBoxServiceOperation.SelectedValue;
                    el.service_operation_personal_role_id = (int)comboBoxRole.SelectedValue;

                    el.physical_people_id = (int)comboBoxFIO.SelectedValue;
                    el.model_element_id = (int)comboBoxModelElement.SelectedValue;

                    TablesModel.entities.SaveChanges();
                }
                var frm = DBEditing.getInstanceDB();
                if (frm != null)
                    frm.UPdateDB();
                MessageBox.Show("изменения успешно приняты");
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
