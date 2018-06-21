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
    public partial class EditingZipPmOnStock : Form
    {
        public int id = -1;
        private int isZIP;
        public EditingZipPmOnStock(int isZIP)
        {
            this.isZIP = isZIP;
            InitializeComponent();
        }

        public EditingZipPmOnStock(int id , int isZIP)
        {
            this.isZIP = isZIP;
            this.id = id;
            InitializeComponent();
        }


        private void EditingZipPmOnStock_Load(object sender, EventArgs e)
        {
            initComboBoxes();
            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ZIPPMonStock.Where(x => x.zipPM_on_stock_id== id).First();
                    textBoxSize.Text = el.count.ToString();

                    for (int i = 0; i < comboBoxZIPPM.Items.Count; i++)
                    {
                        var cmbEl = comboBoxZIPPM.Items[i] as dynamic;
                        if (cmbEl.id == el.zipPM_element_id)
                            comboBoxZIPPM.SelectedIndex = i;
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
            ComboBoxWorker.initZIPMElement(comboBoxZIPPM, isZIP);
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
                    int addId = TablesModel.entities.ZIPPMonStock.Count() == 0 ? 0 : TablesModel.entities.ZIPPMonStock.Max(x => x.zipPM_on_stock_id) + 1;
                    TablesModel.entities.ZIPPMonStock.Add(new Models.ZIPPMonStock()
                    {
                        zipPM_on_stock_id = addId,
                        count = int.Parse(textBoxSize.Text),
                        zipPM_element_id = (int)comboBoxZIPPM.SelectedValue,
                        other = ".."
                    });

                }
                else
                {
                    var el = TablesModel.entities.ZIPPMonStock.Where(x => x.zipPM_on_stock_id == id).First();
                    el.count = int.Parse(textBoxSize.Text);
                    el.zipPM_element_id = (int)comboBoxZIPPM.SelectedValue;

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
