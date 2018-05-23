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
    public partial class EditingPhysicalPeoplePosition : Form
    {
        public int id = -1;
        public EditingPhysicalPeoplePosition()
        {
            InitializeComponent();
        }
        public EditingPhysicalPeoplePosition(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void EditingPhysicalPeoplePosition_Load(object sender, EventArgs e)
        {
            initComboBox();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.FaticalPhysicalPeoplePositions.Where(x => x.fatical_physical_people_position_id== id).First();
                    textBoxSalary.Text = el.salary.ToString();
                    dateTimePickerBegin.Value = el.date_begin.Value;
                    dateTimePickerEnd.Value = el.date_end.Value;
                    
                    for (int i = 0; i < comboBoxFIO.Items.Count; i++)
                    {
                        var cmbEl = comboBoxFIO.Items[i] as dynamic;
                        if (cmbEl.value == el.physical_people_id)
                            comboBoxFIO.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxOrganisation.Items.Count; i++)
                    {
                        var cmbEl = comboBoxOrganisation.Items[i] as dynamic;
                        if (cmbEl.value == el.organisation_id)
                            comboBoxOrganisation.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxPosition.Items.Count; i++)
                    {
                        var cmbEl = comboBoxPosition.Items[i] as dynamic;
                        if (cmbEl.value == el.people_position_id)
                            comboBoxPosition.SelectedIndex = i;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }


        }

        private void initComboBox()
        {
            ComboBoxWorker.initFIO(comboBoxFIO);
            ComboBoxWorker.initOrganisation(comboBoxOrganisation);
            ComboBoxWorker.initPeoplePosition(comboBoxPosition);
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
                    int addId = TablesModel.entities.FaticalPhysicalPeoplePositions.Count() == 0 ? 0 : TablesModel.entities.FaticalPhysicalPeoplePositions.Max(x => x.fatical_physical_people_position_id) + 1;
                    TablesModel.entities.FaticalPhysicalPeoplePositions.Add(new Models.FaticalPhysicalPeoplePositions()
                    {
                        fatical_physical_people_position_id = addId,
                        date_begin = dateTimePickerBegin.Value,
                        date_end = dateTimePickerEnd.Value,
                        salary = int.Parse(textBoxSalary.Text),
                        people_position_id = (int)comboBoxPosition.SelectedValue,
                        physical_people_id = (int)comboBoxFIO.SelectedValue,
                        organisation_id = (int) comboBoxOrganisation.SelectedValue
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.FaticalPhysicalPeoplePositions.Where(x => x.fatical_physical_people_position_id== id).First();
                    el.date_begin = dateTimePickerBegin.Value;
                    el.date_end = dateTimePickerEnd.Value;
                    el.salary = int.Parse(textBoxSalary.Text);
                    el.people_position_id = (int)comboBoxPosition.SelectedValue;

                    el.physical_people_id = (int)comboBoxFIO.SelectedValue;
                    el.organisation_id = (int)comboBoxOrganisation.SelectedValue;

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
    }
}
