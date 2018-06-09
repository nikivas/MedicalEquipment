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
    public partial class sp_StandartsEdit : Form
    {
        public sp_StandartsEdit()
        {
            InitializeComponent();
        }
        public int id = -1;
        public sp_StandartsEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_StandartsEdit_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.sp_Standarts.Where(x => x.standart_id == id).First();
                    for (int i = 0; i < comboBoxBroken.Items.Count; i++)
                    {
                        var cmbEl = comboBoxBroken.Items[i] as dynamic;
                        if (cmbEl.id == el.ModelType.model_type_id)
                            comboBoxBroken.SelectedIndex = i;
                    }
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        var cmbEl = comboBox1.Items[i] as dynamic;
                        if (cmbEl.id == el.sp_Corpus.corpus_id)
                            comboBox1.SelectedIndex = i;
                    }

                    textBoxSerialNumber.Text = el.count.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }
        }
        public void initComboBoxes()
        {
            ComboBoxWorker.initModelType(comboBoxBroken);
            ComboBoxWorker.initCorpus(comboBox1);
        }
    }
}
