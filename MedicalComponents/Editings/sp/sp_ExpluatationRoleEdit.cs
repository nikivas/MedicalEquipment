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
    public partial class sp_ExpluatationRoleEdit : Form
    {
        public int id = -1;
        public sp_ExpluatationRoleEdit()
        {
            InitializeComponent();
        }
        public sp_ExpluatationRoleEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.sp_ExpluatationRole.Count() == 0 ? 0 : TablesModel.entities.sp_ExpluatationRole.Max(x => x.expluatation_role_id) + 1;
                    TablesModel.entities.sp_ExpluatationRole.Add(new Models.sp_ExpluatationRole()
                    {
                        expluatation_role_id = addId,
                        expluatation_role_name = textBox1.Text,
                        other = ".."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ExpluatationRole.Where(x => x.expluatation_role_id == id).First().expluatation_role_name = textBox1.Text;
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

        private void sp_ExpluatationRoleEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ExpluatationRole
                                                    .Where(x => x.expluatation_role_id == id)
                                                    .Select(x => x.expluatation_role_name)
                                                    .First();
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
