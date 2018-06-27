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
    public partial class GraphsWithCorpuses : Form
    {
        public GraphsWithCorpuses()
        {
            InitializeComponent();
        }

        private void GraphsWithCorpuses_Load(object sender, EventArgs e)
        {
            _init();
            //Устаревание оборудования
        }
        public void _init()
        {
            CheckedListBoxWorker.initCorpus(checkedListBox1);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Устаревание оборудования"].Points.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    //TODO: ДЛЯ КАЖДОГО ИЗ ЕДИНИЦ ОБОРУДОВАНИЯ ПО НАЗВАНИЯМ ЕДИНИЦ ОБОРУДОВАНИЯ
                    //UPDATE - КАК ЪОТЕЛ БЮМ
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                    var elem = checkedListBox1.Items[i] as dynamic;
                    var selectedId = (int)elem.id;
                    var Ypos = TablesModel.entities.ModelElement.Where(x => TablesModel.entities.ElementsPlaces.Where(o => o.corpus_id == selectedId && o.model_element_id == x.model_element_id).Count() > 0).ToList();
                    var YposValue = Ypos.Count == 0 ? 0 : Ypos.Average(x => (DateTime.Now - x.date_creation.Value).Days) ;
                    YposValue += new Random().Next(Convert.ToInt32(-YposValue / 2), Convert.ToInt32(YposValue / 2));
                    chart1.Series["Устаревание оборудования"].Points.AddXY((string)elem.value, YposValue);
                }
                
            }
            
        }
    }
}
