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
    public partial class sp_ReasonWriteOffEdit : Form
    {
        public int id;

        public sp_ReasonWriteOffEdit()
        {
            InitializeComponent();
        }
        public sp_ReasonWriteOffEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_ReasonWriteOffEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_ReasonWriteOff
                                                    .Where(x => x.reason_write_off_id == id)
                                                    .Select(x => x.reason_write_off_name)
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
                    int addId = TablesModel.entities.sp_ReasonWriteOff.Count() == 0 ? 0 : TablesModel.entities.sp_ReasonWriteOff.Max(x => x.reason_write_off_id) + 1;
                    TablesModel.entities.sp_ReasonWriteOff.Add(new Models.sp_ReasonWriteOff()
                    {
                        reason_write_off_id = addId,
                        reason_write_off_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_ReasonWriteOff.Where(x => x.reason_write_off_id == id).First().reason_write_off_name = textBox1.Text;
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
