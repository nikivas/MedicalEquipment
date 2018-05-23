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
    public partial class sp_PMEdit : Form
    {
        public int id = -1;
        public sp_PMEdit()
        {
            InitializeComponent();
        }

        public sp_PMEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_PMEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ZIP_AND_PM_Element
                                                    .Where(x => x.zipPM_element_id == id)
                                                    .Select(x => x.zipPM_element_name)
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
                    int addId = TablesModel.entities.sp_ZIP_AND_PM_Element.Count() == 0 ? 0 : TablesModel.entities.sp_ZIP_AND_PM_Element.Max(x => x.zipPM_element_id) + 1;
                    TablesModel.entities.sp_ZIP_AND_PM_Element.Add(new Models.sp_ZIP_AND_PM_Element()
                    {
                        zipPM_element_id = addId,
                        zipPM_element_name = textBox1.Text,
                        isZIP = 0
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ZIP_AND_PM_Element.Where(x => x.zipPM_element_id == id).First().zipPM_element_name = textBox1.Text;
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
