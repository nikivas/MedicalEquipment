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
    public partial class sp_ServiceOperationTypeEdit : Form
    {
        public int id = -1;

        public sp_ServiceOperationTypeEdit()
        {
            InitializeComponent();
        }

        public sp_ServiceOperationTypeEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_ServiceOperationType_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ServiceOperationType
                                                    .Where(x => x.service_operation_type_id == id)
                                                    .Select(x => x.service_operation_type_name)
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
                    int addId = TablesModel.entities.sp_ServiceOperationType.Count() == 0 ? 0 : TablesModel.entities.sp_ServiceOperationType.Max(x => x.service_operation_type_id) + 1;
                    TablesModel.entities.sp_ServiceOperationType.Add(new Models.sp_ServiceOperationType()
                    {
                        service_operation_type_id = addId,
                        service_operation_type_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ServiceOperationType.Where(x => x.service_operation_type_id == id).First().service_operation_type_name = textBox1.Text;
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
