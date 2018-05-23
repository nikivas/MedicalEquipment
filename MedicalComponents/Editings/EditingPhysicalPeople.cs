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
    public partial class EditingPhysicalPeople : Form
    {
        public int id = -1;
        public EditingPhysicalPeople()
        {
            InitializeComponent();
        }
        public EditingPhysicalPeople(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingPhysicalPeople_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.PhysicalPeople.Where(x => x.physical_people_id== id).First();
                    textBoxName.Text = el.name;
                    textBoxFam.Text = el.family;
                    textBoxPatr.Text = el.patronumic;
                    textBoxContacts.Text = el.contacts;
                    for (int i = 0; i < comboBoxDep.Items.Count; i++)
                    {
                        var cmbEl = comboBoxDep.Items[i] as dynamic;
                        if (cmbEl.id == el.organisation_department_id)
                            comboBoxDep.SelectedIndex = i;
                    }
                    comboBoxGender.SelectedIndex = el.Gender == 1 ? 1 : 0;
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
            ComboBoxWorker.initDepartment(comboBoxDep);
            comboBoxGender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.PhysicalPeople.Count() == 0 ? 0 : TablesModel.entities.PhysicalPeople.Max(x => x.physical_people_id) + 1;
                    TablesModel.entities.PhysicalPeople.Add(new Models.PhysicalPeople()
                    {
                        physical_people_id = addId,
                        name = textBoxName.Text,
                        family= textBoxFam.Text,
                        patronumic = textBoxPatr.Text,
                        contacts = textBoxContacts.Text,
                        organisation_department_id = (int)comboBoxDep.SelectedValue,
                        Gender = comboBoxGender.SelectedIndex
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.PhysicalPeople.Where(x => x.physical_people_id == id).First();
                    el.name= textBoxName.Text;
                    el.family= textBoxFam.Text;
                    el.patronumic = textBoxPatr.Text;
                    el.contacts = textBoxContacts.Text;

                    el.organisation_department_id = (int)comboBoxDep.SelectedValue;
                    el.Gender = comboBoxGender.SelectedIndex;

                    TablesModel.entities.SaveChanges();
                }
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
