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
    public partial class sp_ServiceOperationPersonalRoleEdit : Form
    {
        public int id = -1;
        public sp_ServiceOperationPersonalRoleEdit()
        {
            InitializeComponent();
        }

        public sp_ServiceOperationPersonalRoleEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_ServiceOperationPersonalRoleEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ServiceOperationPersonalRole
                                                    .Where(x => x.service_operation_personal_role_id == id)
                                                    .Select(x => x.service_operation_personal_role_name)
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
                    int addId = TablesModel.entities.sp_ServiceOperationPersonalRole.Count() == 0 ? 0 : TablesModel.entities.sp_ServiceOperationPersonalRole.Max(x => x.service_operation_personal_role_id) + 1;
                    TablesModel.entities.sp_ServiceOperationPersonalRole.Add(new Models.sp_ServiceOperationPersonalRole()
                    {
                        service_operation_personal_role_id = addId,
                        service_operation_personal_role_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ServiceOperationPersonalRole.Where(x => x.service_operation_personal_role_id== id).First().service_operation_personal_role_name = textBox1.Text;
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
