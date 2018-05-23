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
    public partial class sp_DragMetalEdit : Form
    {
        public int id = -1;
        public sp_DragMetalEdit()
        {
            InitializeComponent();
        }

        public sp_DragMetalEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_DragMetalEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_DragMetal
                                                    .Where(x => x.drag_metal_id == id)
                                                    .Select(x => x.drag_metal_name)
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
                    int addId = TablesModel.entities.sp_DragMetal.Count() == 0 ? 0 : TablesModel.entities.sp_DragMetal.Max(x => x.drag_metal_id) + 1;
                    TablesModel.entities.sp_DragMetal.Add(new Models.sp_DragMetal()
                    {
                        drag_metal_id = addId,
                        drag_metal_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_DragMetal.Where(x => x.drag_metal_id == id).First().drag_metal_name = textBox1.Text;
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
