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

namespace MedicalComponents.Editings
{
    public partial class EditingPurchaseElement : Form
    {
        public EditingPurchaseElement()
        {
            InitializeComponent();
        }

        private void EditingPurchaseElement_Load(object sender, EventArgs e)
        {
            initComboBoxes();



        }
        private void initComboBoxes()
        {
            ComboBoxWorker.initModelElement(comboBoxModelElement);
        }
    }
}
