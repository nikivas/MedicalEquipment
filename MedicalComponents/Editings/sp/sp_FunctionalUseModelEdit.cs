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
    public partial class sp_FunctionalUseModelEdit : Form
    {
        public int id;
        public sp_FunctionalUseModelEdit()
        {
            InitializeComponent();
        }
        public sp_FunctionalUseModelEdit(int id)
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
                    int addId = TablesModel.entities.sp_FunctionalyUseModel.Count() == 0 ? 
                        0 : TablesModel.entities
                                       .sp_FunctionalyUseModel
                                       .Max(x => x.functionaly_use_model_id) + 1;
                    TablesModel.entities.sp_FunctionalyUseModel.Add(new Models.sp_FunctionalyUseModel()
                    {
                        functionaly_use_model_id= addId,
                        functionaly_use_model_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_FunctionalyUseModel.Where(x => x.functionaly_use_model_id== id).First().functionaly_use_model_name= textBox1.Text;
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

        private void sp_FunctionalUseModel_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_FunctionalyUseModel
                                                    .Where(x => x.functionaly_use_model_id== id)
                                                    .Select(x => x.functionaly_use_model_name)
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
