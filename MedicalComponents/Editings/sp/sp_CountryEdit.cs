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
    public partial class sp_CountryEdit : Form
    {
        public int id = -1;

        public sp_CountryEdit()
        {
            InitializeComponent();
        }
        public sp_CountryEdit(int id)
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
                    int addId = TablesModel.entities.sp_CountryKey.Count() == 0 ? 0 : TablesModel.entities.sp_CountryKey.Max(x => x.country_key_id) + 1;
                    TablesModel.entities.sp_CountryKey.Add(new Models.sp_CountryKey()
                    {
                        country_key_id = addId,
                        country_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_CountryKey.Where(x => x.country_key_id == id).First().country_name = textBox1.Text;
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

        private void sp_CountryEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_CountryKey
                                                    .Where(x => x.country_key_id == id)
                                                    .Select(x => x.country_name)
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
