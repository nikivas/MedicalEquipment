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
    public partial class EditingPurchaseElement : Form
    {
        public int id = -1;
        public EditingPurchaseElement()
        {
            InitializeComponent();
        }
        public EditingPurchaseElement(int id)
        {
            InitializeComponent();
        }

        private void EditingPurchaseElement_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.PurchaseElements.Where(x => x.purchase_element_id == id).First();
                    textBoxMoney.Text = el.money.ToString();
                    textBoxCount.Text = el.count.ToString();
                    dateTimePickerMoved.Value = el.planned_date;
                    checkBox1.Checked = el.isPurchasing == 1;

                    for (int i = 0; i < comboBoxModelElement.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModelElement.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModelElement.SelectedIndex = i;
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
            ComboBoxWorker.initModelElement(comboBoxModelElement);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.PurchaseElements.Count() == 0 ? 0 : TablesModel.entities.PurchaseElements.Max(x => x.purchase_element_id) + 1;
                    TablesModel.entities.PurchaseElements.Add(new Models.PurchaseElements()
                    {
                        purchase_element_id = addId,
                        isPurchasing = checkBox1.Checked ? 1 : 0,
                        count = int.Parse(textBoxCount.Text),
                        money = int.Parse(textBoxMoney.Text),
                        model_element_id = int.Parse((string)comboBoxModelElement.SelectedValue),
                        planned_date = dateTimePickerMoved.Value

                    });

                }
                else
                {
                    var el = TablesModel.entities.PurchaseElements.Where(x => x.purchase_element_id == id).First();
                    el.isPurchasing = checkBox1.Checked ? 1 : 0;
                    el.count = int.Parse(textBoxCount.Text);
                    el.money = int.Parse(textBoxMoney.Text);
                    el.model_element_id = int.Parse((string)comboBoxModelElement.SelectedValue);
                    el.planned_date = dateTimePickerMoved.Value;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
