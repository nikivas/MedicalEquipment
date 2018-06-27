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





            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine; // тут сами поизменяет/повыбирайте тип вывода графика
            chart2.Series.Add("seriesPredict");
            chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine; // тут сами поизменяет/повыбирайте тип вывода графика

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
            for (int i = 0; i < chart2.ChartAreas.Count; i++)
            {
                chart2.ChartAreas[i].AxisX.IsStartedFromZero = false;
            }
            foreach (var el in listBoxZIPPMSelected.Items)
            {
                var element = el as dynamic;
                string name = (string)element.value;
                string predictName = name + " ожидаемое";
                chart2.Series.Add(name);
                chart2.Series.Add(predictName);



                chart2.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
                chart2.Series[predictName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика
                chart2.Series[name].Color = Color.Blue;
                chart2.Series[predictName].Color = Color.Red;
                int zippm_id = (int)element.id;
                
                var rnd = new Random(zippm_id);
                List<double> y_val = new List<double>();
                List<double> x_val = new List<double>();
                int current_date = DateTime.Now.Year * 100 + DateTime.Now.Month;
                List<double> dates_comments = new List<double>();
                current_date += 1;
                for (int i = 0; i < 12; i++)
                {
                    current_date -= 1;
                    if (current_date % 100 == 0)
                    {
                        current_date += 12;
                        current_date -= 100;
                    }
                    dates_comments.Add(current_date);
                    //x_val.Add(current_date / 100.0);
                    var current_year = (int)(current_date / 100);
                    var current_month = (int)(current_date % 100);
                    var countItems = TablesModel.entities.ZIPPMMoves.Where(o => o.date_move.Year == current_year && o.date_move.Month == current_month && o.zipPM_element_id == zippm_id).Count();
                    y_val.Add(countItems);
                    x_val.Add(12 - i);
                }

                for (int i = 0; i < y_val.Count(); i++)
                {
                    var year = ((int)(dates_comments[11 - i] / 100));
                    var month = (dates_comments[11 - i] % 100);

                    var count = TablesModel.entities.ZIPPMMoves.Where(x => x.date_move.Year == year && x.date_move.Month == month && x.zipPM_element_id == zippm_id).Count();
                    chart2.Series[name].Points.AddXY(x_val[y_val.Count() - i - 1], y_val[y_val.Count() - i - 1]);
                    chart2.Series[name].Points[i].AxisLabel =  year+ " - "+month;
                }
                double pred = Interpolation.InterpolateLagrangePolynomial(13, x_val.ToArray(), y_val.ToArray(), 12);
                pred = Math.Abs(pred);
                pred = pred > 1.5 * y_val.First() ?(int)( y_val.First()*1.5) : pred;
                chart2.Series[predictName].Points.AddXY(12, y_val[0]);
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
            List<Dictionary<string, string>> dic = new List<Dictionary<string, string>>();
            foreach (var el in listBoxZIPPMSelected.Items)
            {
                var element = el as dynamic;
                int zippm_id = (int)element.id;

                Dictionary<string, string> buf = new Dictionary<string, string>();
                buf["Наименование ЗИП/РМ"] = TablesModel.entities.sp_ZIP_AND_PM_Element.Where(x=>zippm_id == x.zipPM_element_id).First().zipPM_element_name;
                buf["Дата закупки"] = DateTime.Now.ToShortDateString();


                var rnd = new Random(zippm_id);
                List<double> y_val = new List<double>();
                List<double> x_val = new List<double>();
                int current_date = DateTime.Now.Year * 100 + DateTime.Now.Month;
                List<double> dates_comments = new List<double>();
                current_date += 1;
                for (int i = 0; i < 12; i++)
                {
                    current_date -= 1;
                    if (current_date % 100 == 0)
                    {
                        current_date += 12;
                        current_date -= 100;
                    }
                    dates_comments.Add(current_date);
                    //x_val.Add(current_date / 100.0);
                    var current_year = (int)(current_date / 100);
                    var current_month = (int)(current_date % 100);
                    var countItems = TablesModel.entities.ZIPPMMoves.Where(o => o.date_move.Year == current_year && o.date_move.Month == current_month && o.zipPM_element_id == zippm_id).Count();
                    y_val.Add(countItems);
                    x_val.Add(12 - i);
                }

                for (int i = 0; i < y_val.Count(); i++)
                {
                    var year = ((int)(dates_comments[11 - i] / 100));
                    var month = (dates_comments[11 - i] % 100);

                    var count = TablesModel.entities.ZIPPMMoves.Where(x => x.date_move.Year == year && x.date_move.Month == month && x.zipPM_element_id == zippm_id).Count();
                    
                }
                double pred = Interpolation.InterpolateLagrangePolynomial(13, x_val.ToArray(), y_val.ToArray(), 12);
                pred = Math.Abs(pred);
                pred = pred > 1.5 * y_val.First() ? (int)(y_val.First() * 1.5 ): pred;




                buf["Количество"] = pred.ToString();
                dic.Add(buf);

            }
            _excelController.GeneratePLans(dic, "Планы закупок");
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
            // TODO : вынести этот график на верхнюю в менюшке, а тут - по сроку оставшейся эксплуатации
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var x = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var y = new List<double>();// double[] { 6, 6, 6, 5, 5, 5, 5, 4, 4, 4, 3, 3, 1 };
            //
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            //
            var selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
                var brokenCount = TablesModel.entities.BrokenRequest.Where(xx => xx.model_element_id == selectedId && xx.date_to_repair.Year == year && xx.date_to_repair.Month == month ).Count();

                y.Add(i+1);
            }


            for (int i = 0; i < 12; i++)
            { 
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                chart1.Series[0].Points[i].AxisLabel = ((int)(dates_comments[11 - i] / 100)) + " - " + (dates_comments[11 - i] % 100);
            }
            var date_util = (DateTime.Now - TablesModel.entities.ModelElement.Where(o => o.model_element_id == selectedId).First().date_utilisation).Value.Days / 30.0;
            var second = (DateTime.Now.Month > TablesModel.entities.ModelElement.Where(o => o.model_element_id == selectedId).First().date_utilisation.Value.Month) && DateTime.Now.Year == TablesModel.entities.ModelElement.Where(o => o.model_element_id == selectedId).First().date_utilisation.Value.Year;
            var first = DateTime.Now.Year > TablesModel.entities.ModelElement.Where(o => o.model_element_id == selectedId).First().date_utilisation.Value.Year;
            if (first || second) {
                var date = TablesModel.entities.ModelElement.Where(o => o.model_element_id == selectedId).First().date_utilisation.Value;
                int idx = dates_comments.IndexOf(date.Year * 100 + date.Month);
                idx = idx < 0 ? 12 : idx;
                date_util = 12 - idx;
            }
            else
            {
                date_util += 12;
            }

            chart1.Series[1].Points.AddXY(date_util, 0);
            chart1.Series[1].Points.AddXY(date_util, 20+1);


        }
    }
}
