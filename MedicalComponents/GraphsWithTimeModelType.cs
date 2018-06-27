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


            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var x = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14 };
            var y = new List<double>();// double[] { 6, 6, 6, 5, 5, 5, 5, 4, 4, 4, 3, 3, 1 };


            int current_date = DateTime.Now.Year * 100 + DateTime.Now.Month;
            List<double> dates_comments = new List<double>();
            Random rnd = new Random(123);
            for (int i = 0; i < 12; i++)
            {
                current_date -= 1;
                if (current_date % 100 == 0)
                {
                    current_date += 12;
                    current_date -= 100;
                }

                dates_comments.Add(current_date);
                int year = (int)(current_date / 100);
                int month = (int)(current_date % 100);
                var brokenCount = TablesModel.entities.BrokenRequest.Where(xx => xx.model_element_id == selectedId && xx.date_to_repair.Year == year && xx.date_to_repair.Month == month).Count();

                y.Add(brokenCount);
                //x_val.Add(current_date / 100.0);
                //y.Add(rnd.Next(0, 100));
                //x_val.Add(i + 1);
            }


            for (int i = 0; i < 12; i++)
            {
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                chart1.Series[0].Points[i].AxisLabel = ((int)(dates_comments[11 - i] / 100)) + " - " + (dates_comments[11 - i] % 100);
            }

            chart1.Series[1].Points.AddXY(x[11], y[11]);
            double x_val = 13;
            var y_val = Interpolation.InterpolateLagrangePolynomial(x_val, x, y.ToArray(), 12);
            y_val = Math.Abs(y_val);
            y_val = y_val = y_val > y[10] * 1.5 ? y[10] * 1.5 : y_val;
            chart1.Series[1].Points.AddXY(13, y_val);

        }

        private void buttonFinder_Click_1(object sender, EventArgs e)
        {
            CheckedListBoxWorker.initModelType(checkedListBox1, textBoxFinder.Text);
        }

        //private void Update
    }
}
