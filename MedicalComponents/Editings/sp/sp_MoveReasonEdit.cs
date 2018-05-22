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
    public partial class sp_MoveReasonEdit : Form
    {
        public int id = -1;
        public sp_MoveReasonEdit()
        {
            InitializeComponent();
        }
        public sp_MoveReasonEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_MoveReasonEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_MoveReason
                                                    .Where(x => x.move_reason_id== id)
                                                    .Select(x => x.move_reason_name)
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
                    int addId = TablesModel.entities.sp_MoveReason.Count() == 0 ? 0 : TablesModel.entities.sp_MoveReason.Max(x => x.move_reason_id) + 1;
                    TablesModel.entities.sp_MoveReason.Add(new Models.sp_MoveReason()
                    {
                        move_reason_id = addId,
                        move_reason_name = textBox1.Text
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_MoveReason.Where(x => x.move_reason_id == id).First().move_reason_name = textBox1.Text;
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
