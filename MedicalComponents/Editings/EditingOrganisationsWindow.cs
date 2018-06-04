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
    public partial class EditingOrganisationsWindow : Form
    {
        public int id = -1;
        public EditingOrganisationsWindow()
        {
            InitializeComponent();
        }
        public EditingOrganisationsWindow(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        public EditingOrganisationsWindow(string OrganisationName, string OrganisationNameShort, string OrganisationUristAddress, string OrganisationPhysicalAddress, string qwe)
        {
            InitializeComponent();
        }

        private void EditingOrganisationsWindow_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.Organisations.Where(x => x.organisation_id== id).First();
                    textBoxOrganisationName.Text = el.organisation_full_name;
                    textBoxOrganisationNameShort.Text = el.organisation_short_name;
                    textBoxPhysicalAddress.Text = el.factic_address;
                    textBoxContactInfo.Text = el.contacts;
                    textBoxEmail.Text = el.email;
                    for (int i = 0; i < comboBoxCountr.Items.Count; i++)
                    {
                        var cmbEl = comboBoxCountr.Items[i] as dynamic;
                        if (cmbEl.id == el.country_key_id)
                            comboBoxCountr.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBoxOrgType.Items.Count; i++)
                    {
                        var cmbEl = comboBoxOrgType.Items[i] as dynamic;
                        if (cmbEl.id == el.organisation_type_id)
                            comboBoxOrgType.SelectedIndex = i;
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
            ComboBoxWorker.initCountry(comboBoxCountr);
            ComboBoxWorker.initOrganisationType(comboBoxOrgType);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.Organisations.Count() == 0 ? 0 : TablesModel.entities.Organisations.Max(x => x.organisation_id) + 1;
                    TablesModel.entities.Organisations.Add(new Models.Organisations()
                    {
                        organisation_id = addId,
                        organisation_full_name = textBoxOrganisationName.Text,
                        organisation_short_name = textBoxOrganisationNameShort.Text,
                        factic_address = textBoxPhysicalAddress.Text,
                        email = textBoxEmail.Text,
                        contacts = textBoxContactInfo.Text,
                        organisation_type_id = (int) comboBoxOrgType.SelectedValue,
                        country_key_id = (int) comboBoxCountr.SelectedValue
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.Organisations.Where(x => x.organisation_id== id).First();
                    el.organisation_full_name = textBoxOrganisationName.Text;
                    el.organisation_short_name = textBoxOrganisationNameShort.Text;
                    el.contacts = textBoxContactInfo.Text;
                    el.email = textBoxEmail.Text;
                    el.factic_address = textBoxPhysicalAddress.Text;

                    el.organisation_type_id = (int)comboBoxOrgType.SelectedValue;
                    el.country_key_id = (int)comboBoxCountr.SelectedValue;

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
