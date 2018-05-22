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
    public partial class sp_CorpusEdit : Form
    {
        public int id = -1;
        public sp_CorpusEdit()
        {
            InitializeComponent();
        }
        public sp_CorpusEdit(int id )
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_CorpusEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                    this.textBox1.Text = TablesModel.entities
                                                    .sp_Corpus
                                                    .Where(x => x.corpus_id == id)
                                                    .Select(x => x.corpus_name)
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
                    int addId = TablesModel.entities.sp_Corpus.Count() == 0 ? 0 : TablesModel.entities.sp_Corpus.Max(x => x.corpus_id) + 1;
                    TablesModel.entities.sp_Corpus.Add(new Models.sp_Corpus()
                    {
                        corpus_id = addId,
                        corpus_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_Corpus.Where(x => x.corpus_id == id).First().corpus_name = textBox1.Text;
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
