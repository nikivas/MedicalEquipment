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


            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
            chart1.Series.Add("seriesPredict");
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика

            chart1.Series["seriesPredict"].Color = Color.Red;





            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
            chart2.Series.Add("seriesPredict");
            chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика

            chart2.Series["seriesPredict"].Color = Color.Red;

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

                updateChart2();

                
                //var data = TablesModel.entities.sp_ZIP_AND_PM_Element.Where(x=>x)


            }catch(Exception ee) { }


        }

        private void updateChart2()
        {
            chart2.Series.Clear();
            foreach (var el in listBoxZIPPMSelected.Items)
            {
                var element = el as dynamic;
                string name = (string)element.value;
                string predictName = name + "predict";
                chart2.Series.Add(name);
                chart2.Series.Add(predictName);



                chart2.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
                chart2.Series[predictName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
                chart2.Series[name].Color = Color.Blue;
                chart2.Series[predictName].Color = Color.Red;
                int zippm_id = (int)element.id;

                var year = DateTime.Now;
                var rnd = new Random(zippm_id);
                List<double> y_val = new List<double>();
                List<double> x_val = new List<double>();
                for (int i = 0; i < 12; i++)
                {
                    x_val.Add(i + 1);
                    y_val.Add(rnd.Next(0, 100));
                }
                for (int i = 0; i < y_val.Count(); i++)
                {
                    chart2.Series[name].Points.AddXY(x_val[i], y_val[i]);
                }
                x_val.Add(14);
                y_val.Add(y_val[0]);
                double pred = Interpolation.InterpolateLagrangePolynomial(13, x_val.ToArray(), y_val.ToArray(), 13);
                pred = Math.Abs(pred);
                pred = pred > 1.5 * y_val.Last() ? y_val.Last() : pred;
                chart2.Series[predictName].Points.AddXY(12, y_val[11]);
                chart2.Series[predictName].Points.AddXY(13, pred);


                /*
                var dataSource = TablesModel.entities
                                      .ZIPPMMoves
                                      .Where(x => x.sp_ZIP_AND_PM_Element.zipPM_element_id == zippm_id)
                                      .Where(x => (x.date_move - year).Days < 365 )
                                      .Select(x=>new
                                      {
                                          date = x.date_move.Year*1000 + x.date_move.Month,
                                          id = x.zipPM_move_id
                                      });

                var data = (from el2 in dataSource
                           group el2 by el2.date
                           into g
                           select new
                           {
                               g.Key,
                               Value = g.Count()
                           }).ToList().OrderBy(x=>x.Key);



                List<int> dat = new List<int>();

                */



            }
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

                updateChart2();
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

        private void comboBoxModelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModelType.SelectedIndex == -1) return;

            try { 
                new TablesModel().FillModelElementByModelType(dataGridView1, (int)comboBoxModelType.SelectedValue);
            }catch(Exception ee)
            {
                return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var data = TablesModel.entities.


            var x = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14 };
            var y = new double[] { 6, 6, 6, 5, 5, 5, 5, 4, 4, 4, 3, 3, 1 };
            for (int i = 0; i < 12; i++)
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            chart1.Series[1].Points.AddXY(x[11], y[11]);
            double x_val = 13;
            var y_val = Interpolation.InterpolateLagrangePolynomial(x_val, x, y, 13);
            chart1.Series[1].Points.AddXY(13, y_val);

        }
    }
}
