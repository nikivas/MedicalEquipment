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
    public partial class EditingEquipmentObject : Form
    {
        public int id = -1;
        public EditingEquipmentObject()
        {
            InitializeComponent();
        }
        public EditingEquipmentObject(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditingEquipmentObject_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ModelElement.Where(x => x.model_element_id == id).First();
                    textBoxInventaryNumber.Text = el.inventory_number;
                    textBoxSerialNumber.Text = el.serial_number;
                    for (int i = 0; i < comboBoxModelType.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModelType.Items[i] as dynamic;
                        if (cmbEl.id == el.model_type_id)
                            comboBoxModelType.SelectedIndex = i;
                    }
                    dateTimePickerCreated.Value = el.date_creation.Value;
                    dateTimePickerWriteOff.Value = el.date_utilisation.Value;

                    dateTimePickerMO.Value = el.date_mo ?? DateTime.Now;
                    dateTimePickerTO.Value = el.date_to ?? DateTime.Now;

                    textBoxName.Text = el.other;
                    checkBox1.Checked = el.is_mo == 1;

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
            ComboBoxWorker.initWriteOff(comboBoxWriteOffReason);
            ComboBoxWorker.initModelType(comboBoxModelType);
            ComboBoxWorker.initCountry(comboBoxCountry);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.ModelElement.Count() == 0 ? 0 : TablesModel.entities.ModelElement.Max(x => x.model_element_id) + 1;
                    TablesModel.entities.ModelElement.Add(new Models.ModelElement()
                    {
                        model_element_id = addId,
                        inventory_number = textBoxInventaryNumber.Text,
                        serial_number = textBoxSerialNumber.Text,
                        date_creation = dateTimePickerCreated.Value,
                        date_utilisation = dateTimePickerWriteOff.Value,
                        model_type_id = (int) comboBoxModelType.SelectedValue,
                        reason_write_off_id = (int) comboBoxWriteOffReason.SelectedValue,
                        other = textBoxName.Text,
                        is_mo = checkBox1.Checked ? 1 : 0,
                        date_mo = dateTimePickerMO.Value,
                        date_to = dateTimePickerTO.Value
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.ModelElement.Where(x => x.model_element_id == id).First();
                    el.inventory_number = textBoxInventaryNumber.Text;
                    el.serial_number = textBoxSerialNumber.Text;
                    el.date_creation = dateTimePickerCreated.Value;
                    el.date_utilisation = dateTimePickerWriteOff.Value;
                    el.model_type_id = (int)comboBoxModelType.SelectedValue;
                    el.reason_write_off_id = (int)comboBoxWriteOffReason.SelectedValue;
                    el.other = textBoxName.Text;
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

        private void checkBoxSpisano_CheckedChanged(object sender, EventArgs e)
        {
                comboBoxWriteOffReason.Enabled ^= true;
                dateTimePickerWriteOff.Enabled ^= true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerMO.Enabled ^= true;
        }
    }
}
