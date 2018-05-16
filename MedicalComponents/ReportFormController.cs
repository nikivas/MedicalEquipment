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
    public partial class ReportFormController : Form
    {
        public ReportFormController()
        {
            InitializeComponent();
        }

        private void ReportFormController_Load(object sender, EventArgs e)
        {
            checkedListBox1.SelectionMode = SelectionMode.One;
        }
    }
}
