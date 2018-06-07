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
    public partial class GraphsWithTimeModelType : Form
    {
        public GraphsWithTimeModelType()
        {
            InitializeComponent();
        }

        private void GraphsWithTimeModelType_Load(object sender, EventArgs e)
        {
            CheckedListBoxWorker.initModelType(checkedListBox1);
        }

        private void buttonFinder_Click(object sender, EventArgs e)
        {
            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
            int selectedId;
            try {
                selectedId = (int)checkedListBox1.SelectedValue;
            }
            catch(Exception ee) { return; }
            chart1.Series["единицы оборудования"].Points.Clear();

            const int TimeSpanMonths = 12;
            DateTime currentDate = DateTime.Now;
            DateTime oldDate = currentDate;
            var dates = TablesModel.entities.ModelElement.Where(x => x.model_type_id == selectedId).Select(x => x.date_utilisation).Distinct().ToList();

            var chartSource = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < TimeSpanMonths; i++)
            {
                string dd = currentDate
                            .Day
                            .ToString()
                            .PadLeft(2, '0');

                string yy = (currentDate.Month - 1 <= 0 ? currentDate.Year - 1 : currentDate.Year)
                    .ToString()
                    .PadLeft(4, '0');

                string mm = (currentDate.Month - 1 <= 0 ? 12 : currentDate.Month - 1)
                            .ToString()
                            .PadLeft(2, '0');

                var currentDateString = dd + "." + mm + "." + yy;
                currentDate = DateTime.Parse(currentDateString);


                var linqResult = TablesModel.entities
                                            .ModelElement
                                            .Where(x => x.ModelType.model_type_id == selectedId)
                                            .Where(x => x.date_utilisation > currentDate && x.date_utilisation < oldDate)
                                            .Count();
                var element = new KeyValuePair<string, int>(currentDateString, linqResult);

                chartSource.Add(element);
                //chart1.Series["единицы оборудования"].Points.AddXY(currentDateString, linqResult);

            }

            for (int i = chartSource.Count()-1; i >= 0; i--)
            {
                var currentDateString = chartSource[i].Key;
                var linqResult = chartSource[i].Value;
                chart1.Series["единицы оборудования"].Points.AddXY(currentDateString, linqResult);
            }

            //for (int i = 0; i < Math.Min(12,dates.Count()); i++)
            //{
            //    DateTime selectedDate = dates[i].Value;
            //    var linqResult = TablesModel.entities
            //                                .ModelElement
            //                                .Where(x => x.ModelType.model_type_id == selectedId)
            //                                .Where(x => x.date_utilisation == selectedDate)
            //                                .Count();
            //    chart1.Series["Series1"].Points.AddXY(dates[i].Value.ToShortDateString(), linqResult);
            //}


        }

        private void buttonFinder_Click_1(object sender, EventArgs e)
        {
            CheckedListBoxWorker.initModelType(checkedListBox1, textBoxFinder.Text);
        }

        //private void Update
    }
}
