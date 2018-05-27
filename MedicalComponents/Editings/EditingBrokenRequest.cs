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
    public partial class EditingBrokenRequest : Form
    {

        public int id = -1;

        public EditingBrokenRequest()
        {
            InitializeComponent();
        }
        public EditingBrokenRequest(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingBrokenRequest_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.BrokenRequest.Where(x => x.broken_request_reason_id == id).First();
                    for (int i = 0; i < comboBoxBroken.Items.Count; i++)
                    {
                        var cmbEl = comboBoxBroken.Items[i] as dynamic;
                        if (cmbEl.id == el.sp_BrokenRequestReason.broken_request_reason_name)
                            comboBoxBroken.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxModel.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModel.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModel.SelectedIndex = i;
                    }


                    for (int i = 0; i < comboBoxPeople.Items.Count; i++)
                    {
                        var cmbEl = comboBoxPeople.Items[i] as dynamic;
                        if (cmbEl.id == el.physical_people_id)
                            comboBoxPeople.SelectedIndex = i;
                    }
                    dateTimePickerMoved.Value = el.date_to_repair;
                    checkBox1.Checked = el.isFinished == 1;
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
            ComboBoxWorker.initPeoplePosition(comboBoxPeople);
            ComboBoxWorker.initModelElement(comboBoxModel);
            ComboBoxWorker.initBroken(comboBoxBroken);

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
                    int addId = TablesModel.entities.BrokenRequest.Count() == 0 ? 0 : TablesModel.entities.BrokenRequest.Max(x => x.broken_request_id) + 1;
                    TablesModel.entities.BrokenRequest.Add(new Models.BrokenRequest()
                    {
                        broken_request_id = addId,
                        date_to_repair = dateTimePickerMoved.Value,
                        model_element_id = (int)comboBoxModel.SelectedValue,
                        physical_people_id = (int)comboBoxPeople.SelectedValue,
                        broken_request_reason_id = (int) comboBoxBroken.SelectedValue,
                        isFinished = checkBox1.Checked ? 1 : 0
                    });

                }
                else
                {
                    var el = TablesModel.entities.BrokenRequest.Where(x => x.broken_request_id == id).First();
                    el.date_to_repair = dateTimePickerMoved.Value;
                    el.broken_request_id = (int)comboBoxBroken.SelectedValue;
                    el.model_element_id = (int)comboBoxModel.SelectedValue;
                    el.physical_people_id = (int)comboBoxPeople.SelectedValue;
                    el.isFinished = checkBox1.Checked ? 1 : 0;

                }
                TablesModel.entities.SaveChanges();
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
