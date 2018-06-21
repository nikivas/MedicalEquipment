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
    public partial class EditingZIPDocumentsPurchase : Form
    {
        public int id = -1;
        public EditingZIPDocumentsPurchase()
        {
            InitializeComponent();
        }
        public EditingZIPDocumentsPurchase(int id )
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingZIPDocumentsPurchase_Load(object sender, EventArgs e)
        {
            initComboBoxes();


            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ZIPPMDocumentsOnPurchase.Where(x => x.zipPM_documents_purchase_id == id).First();
                    for (int i = 0; i < comboBoxModelElement.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModelElement.Items[i] as dynamic;
                        if (cmbEl.id == el.zipPM_element_id)
                            comboBoxModelElement.SelectedIndex = i;
                    }
                    dateTimePickerPlanned.Value = el.date_coming_in;
                    dateTimePickerFactical.Value = el.date_to_end_possible_use.Value;
                    textBoxCount.Text = el.count.ToString();
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
            ComboBoxWorker.initZIPMElement(comboBoxModelElement, 1);
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
                    int addId = TablesModel.entities.ZIPPMDocumentsOnPurchase.Count() == 0 ? 0 : TablesModel.entities.ZIPPMDocumentsOnPurchase.Max(x => x.zipPM_documents_purchase_id) + 1;
                    TablesModel.entities.ZIPPMDocumentsOnPurchase.Add(new Models.ZIPPMDocumentsOnPurchase()
                    {
                        zipPM_documents_purchase_id = addId,
                        zipPM_element_id = (int)comboBoxModelElement.SelectedValue,
                        count = int.Parse(textBoxCount.Text),
                        date_coming_in = dateTimePickerPlanned.Value,
                        date_to_end_possible_use = dateTimePickerFactical.Value
                    });

                }
                else
                {
                    var el = TablesModel.entities.ZIPPMDocumentsOnPurchase.Where(x => x.zipPM_documents_purchase_id == id).First();
                    el.date_coming_in = dateTimePickerPlanned.Value;
                    el.date_to_end_possible_use = dateTimePickerFactical.Value;
                    el.count = int.Parse(textBoxCount.Text);
                    el.zipPM_element_id = (int)comboBoxModelElement.SelectedValue;
                }
                TablesModel.entities.SaveChanges();
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
