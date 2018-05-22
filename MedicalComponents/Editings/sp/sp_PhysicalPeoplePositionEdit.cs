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
    public partial class sp_PhysicalPeoplePositionEdit : Form
    {
        public int id = -1;

        public sp_PhysicalPeoplePositionEdit()
        {
            InitializeComponent();
        }
        public sp_PhysicalPeoplePositionEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_PhysicalPeoplePositionEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_PysicalPeoplePositions
                                                    .Where(x => x.physical_people_position_id== id)
                                                    .Select(x => x.physical_people_position_name)
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
                    int addId = TablesModel.entities.sp_PysicalPeoplePositions.Count() == 0 ? 0 : TablesModel.entities.sp_PysicalPeoplePositions.Max(x => x.physical_people_position_id) + 1;
                    TablesModel.entities.sp_PysicalPeoplePositions.Add(new Models.sp_PysicalPeoplePositions()
                    {
                        physical_people_position_id = addId,
                        physical_people_position_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_PysicalPeoplePositions.Where(x => x.physical_people_position_id == id).First().physical_people_position_name = textBox1.Text;
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
