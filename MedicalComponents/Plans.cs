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

namespace MedicalComponents
{
    public partial class Plans : Form
    {
        public Plans()
        {
            InitializeComponent();
        }
        int flag = 0;


        List<object> _zippms = new List<object>();

        private void Plans_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            ComboBoxWorker.initCorpus(comboBoxCorpus);
            LIstBoxWorker.initZIPPM(listBoxZIPPM);
            flag = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 0)
                return;
            int corp_id = (int)(comboBoxCorpus.SelectedValue);
            ComboBoxWorker.initModelTypeByCorpusId(comboBoxModelType, corp_id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                _zippms.Add(listBoxZIPPM.SelectedItem);
            
                listBoxZIPPMSelected.DataSource = null;
                listBoxZIPPMSelected.DataSource = _zippms;
                listBoxZIPPMSelected.DisplayMember = "value";
                listBoxZIPPMSelected.ValueMember = "id";
            }catch(Exception ee) { }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _zippms.RemoveAt(listBoxZIPPMSelected.SelectedIndex);
                listBoxZIPPMSelected.DataSource = null;
                listBoxZIPPMSelected.DataSource = _zippms;
                listBoxZIPPMSelected.DisplayMember = "value";
                listBoxZIPPMSelected.ValueMember = "id";
            }
            catch (Exception ee) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LIstBoxWorker.initZIPPM(listBoxZIPPM, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelController _excelController = new ExcelController();
            _excelController.GeneratePLans(new List<Dictionary<string, string>>(), "Планы закупок");
            //TODO

        }
    }
}
