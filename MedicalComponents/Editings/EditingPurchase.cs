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
    public partial class EditingPurchase : Form
    {
        public int id = -1;
        public EditingPurchase()
        {
            InitializeComponent();
        }
        public EditingPurchase(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingPurchase_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.Purchase.Where(x => x.purchase_id== id).First();
                    textBoxDocNumber.Text = el.purchase_document_number;
                    dateTimePickerCreated.Value = el.date_apply.Value;

                    for (int i = 0; i < comboBoxPurchaseType.Items.Count; i++)
                    {
                        var cmbEl = comboBoxPurchaseType.Items[i] as dynamic;
                        if (cmbEl.id == el.purchase_type_id)
                            comboBoxPurchaseType.SelectedIndex = i;
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
            ComboBoxWorker.initPurchase(comboBoxPurchaseType);
            ComboBoxWorker.initOrganisation(comboBoxOrg);
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
                    int addId = TablesModel.entities.Purchase.Count() == 0 ? 0 : TablesModel.entities.Purchase.Max(x => x.purchase_id) + 1;
                    TablesModel.entities.Purchase.Add(new Models.Purchase()
                    {
                        purchase_id = addId,
                        date_apply = dateTimePickerCreated.Value,
                        purchase_document_number = textBoxDocNumber.Text,
                        purchase_type_id = (int)comboBoxPurchaseType.SelectedValue
                    });
                    
                }
                else
                {
                    var el = TablesModel.entities.Purchase.Where(x => x.purchase_id== id).First();
                    el.date_apply = dateTimePickerCreated.Value;
                    el.purchase_document_number = textBoxDocNumber.Text;
                    el.purchase_type_id = (int)comboBoxPurchaseType.SelectedValue;
                    
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
