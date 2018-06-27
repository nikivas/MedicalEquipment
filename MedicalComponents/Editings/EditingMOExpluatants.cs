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
    public partial class EditingMOExpluatants : Form
    {
        public int id = -1;
        public EditingMOExpluatants()
        {
            InitializeComponent();
        }

        public EditingMOExpluatants(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingMOExpluatants_Load(object sender, EventArgs e)
        {
            initComboBoxes();


            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.MOExpluatation.Where(x => x.mo_expluatation_id== id).First();
                    
                    dateTimePickerBegin.Value = el.date_begin;
                    dateTimePickerEnd.Value = el.date_end.Value;

                    for (int i = 0; i < comboBoxFIO.Items.Count; i++)
                    {
                        var cmbEl = comboBoxFIO.Items[i] as dynamic;
                        if (cmbEl.id == el.physical_people_id)
                            comboBoxFIO.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxModel.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModel.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModel.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxRole.Items.Count; i++)
                    {
                        var cmbEl = comboBoxRole.Items[i] as dynamic;
                        if (cmbEl.id == el.service_operation_personal_role_id)
                            comboBoxRole.SelectedIndex = i;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }

        }

        private void initComboBoxes()
        {
            ComboBoxWorker.initFIO(comboBoxFIO);
            ComboBoxWorker.initModelElement(comboBoxModel);
            ComboBoxWorker.initServiceOperationRole(comboBoxRole);
            ComboBoxWorker.initModelType(comboBoxType);
            ComboBoxWorker.initElementsModelName(comboBoxName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.MOExpluatation.Count() == 0 ? 0 : TablesModel.entities.MOExpluatation.Max(x => x.mo_expluatation_id) + 1;
                    TablesModel.entities.MOExpluatation.Add(new Models.MOExpluatation()
                    {
                        mo_expluatation_id = addId,
                        date_begin = dateTimePickerBegin.Value,
                        date_end = dateTimePickerEnd.Value,
                        service_operation_personal_role_id = (int)comboBoxRole.SelectedValue,
                        physical_people_id = (int)comboBoxFIO.SelectedValue,
                        model_element_id = (int)comboBoxModel.SelectedValue
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.MOExpluatation.Where(x => x.mo_expluatation_id == id).First();
                    el.date_begin = dateTimePickerBegin.Value;
                    el.date_end = dateTimePickerEnd.Value;
                    el.model_element_id = (int)comboBoxModel.SelectedValue;

                    el.physical_people_id = (int)comboBoxFIO.SelectedValue;
                    el.service_operation_personal_role_id = (int)comboBoxRole.SelectedValue;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
