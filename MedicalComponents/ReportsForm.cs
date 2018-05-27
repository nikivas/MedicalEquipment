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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ComboBoxWorker.initModelType(comboBoxModel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ExcelController().GenerateModelElementsExample(null);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                    continue;
                }
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
