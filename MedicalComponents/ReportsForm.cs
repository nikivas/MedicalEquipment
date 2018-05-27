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
    }
}
