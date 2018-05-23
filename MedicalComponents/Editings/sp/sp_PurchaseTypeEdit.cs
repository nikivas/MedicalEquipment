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

namespace MedicalComponents.Editings.sp
{
    public partial class sp_PurchaseTypeEdit : Form
    {
        public int id = -1;
        public sp_PurchaseTypeEdit()
        {
            InitializeComponent();
        }

        public sp_PurchaseTypeEdit(int id)
        {
            InitializeComponent();
        }

        private void sp_PurchaseTypeEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_PurchaseType
                                                    .Where(x => x.purchase_type_id == id)
                                                    .Select(x => x.purchase_type_name)
                                                    .First();
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.sp_PurchaseType.Count() == 0 ? 0 : TablesModel.entities.sp_PurchaseType.Max(x => x.purchase_type_id) + 1;
                    TablesModel.entities.sp_PurchaseType.Add(new Models.sp_PurchaseType()
                    {
                        purchase_type_id = addId,
                        purchase_type_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_PurchaseType.Where(x => x.purchase_type_id == id).First().purchase_type_name = textBox1.Text;
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
