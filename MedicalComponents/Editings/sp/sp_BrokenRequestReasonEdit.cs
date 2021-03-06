﻿using MedicalComponents.Models;
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
    public partial class sp_BrokenRequestReasonEdit : Form
    {
        public int id = -1;
        public sp_BrokenRequestReasonEdit()
        {
            InitializeComponent();
        }

        public sp_BrokenRequestReasonEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_BrokenRequestReasonEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_BrokenRequestReason
                                                    .Where(x => x.broken_request_reason_id == id)
                                                    .Select(x => x.broken_request_reason_name)
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
                    int addId = TablesModel.entities.sp_BrokenRequestReason.Count() == 0 ? 0 : TablesModel.entities.sp_BrokenRequestReason.Max(x => x.broken_request_reason_id) + 1;
                    TablesModel.entities.sp_BrokenRequestReason.Add(new Models.sp_BrokenRequestReason()
                    {
                        broken_request_reason_id = addId,
                        broken_request_reason_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_BrokenRequestReason.Where(x => x.broken_request_reason_id == id).First().broken_request_reason_name = textBox1.Text;
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
