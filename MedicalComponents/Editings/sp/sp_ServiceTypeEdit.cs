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
    public partial class sp_ServiceTypeEdit : Form
    {
        public int id = -1;
        public sp_ServiceTypeEdit()
        {
            InitializeComponent();
        }

        public sp_ServiceTypeEdit(int id)
        {
            InitializeComponent();
        }

        private void sp_ServiceTypeEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ServiceType
                                                    .Where(x => x.service_type_id == id)
                                                    .Select(x => x.service_type_name)
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
                    int addId = TablesModel.entities.sp_ServiceType.Count() == 0 ? 0 : TablesModel.entities.sp_ServiceType.Max(x => x.service_type_id) + 1;
                    TablesModel.entities.sp_ServiceType.Add(new Models.sp_ServiceType()
                    {
                        service_type_id = addId,
                        service_type_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ServiceType.Where(x => x.service_type_id == id).First().service_type_name = textBox1.Text;
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
