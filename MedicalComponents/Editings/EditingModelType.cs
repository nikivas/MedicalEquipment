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
    public partial class EditingModelType : Form
    {
        public int id = -1;
        public EditingModelType()
        {
            InitializeComponent();
        }

        public EditingModelType(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingModelType_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ModelType.Where(x => x.model_type_id == id).First();
                    textBoxName.Text = el.model_type_name;
                    for (int i = 0; i < comboBoxExpluatation.Items.Count; i++)
                    {
                        var cmbEl = comboBoxExpluatation.Items[i] as dynamic;
                        if (cmbEl.value == el.expluatation_role_id)
                            comboBoxExpluatation.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxFunc.Items.Count; i++)
                    {
                        var cmbEl = comboBoxFunc.Items[i] as dynamic;
                        if (cmbEl.value == el.functionaly_use_model_id)
                            comboBoxFunc.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxOrganisation.Items.Count; i++)
                    {
                        var cmbEl = comboBoxOrganisation.Items[i] as dynamic;
                        if (cmbEl.value == el.organisation_id)
                            comboBoxOrganisation.SelectedIndex = i;
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
            ComboBoxWorker.initOrganisation(comboBoxOrganisation);
            ComboBoxWorker.initFuncModel(comboBoxFunc);
            ComboBoxWorker.initExpluatationRole(comboBoxExpluatation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.ModelType.Count() == 0 ? 0 : TablesModel.entities.ModelType.Max(x => x.model_type_id) + 1;
                    TablesModel.entities.ModelType.Add(new Models.ModelType()
                    {
                        model_type_id = addId,
                        expluatation_role_id = (int) comboBoxExpluatation.SelectedValue,
                        organisation_id = (int) comboBoxOrganisation.SelectedValue,
                        functionaly_use_model_id = (int) comboBoxFunc.SelectedValue,
                        model_type_name = textBoxName.Text
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.ModelType.Where(x => x.model_type_id== id).First();
                    el.model_type_name = textBoxName.Text;
                    el.organisation_id= (int)comboBoxOrganisation.SelectedValue;
                    el.functionaly_use_model_id= (int)comboBoxFunc.SelectedValue;
                    el.expluatation_role_id = (int)comboBoxExpluatation.SelectedValue;
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
