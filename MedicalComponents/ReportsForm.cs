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
        private const string DATE_NULL = "01.01.1950";

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ComboBoxWorker.initModelType(comboBoxModel);
        }

        public void InitCombobBoxes()
        {
            ComboBoxWorker.initModelType(comboBoxModel);
            ComboBoxWorker.initModelType(comboBoxModelRM);
            ComboBoxWorker.initCorpus(comboBoxCorpus);
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


        private IEnumerable<Dictionary<string,string>> UpdateState()
        {


            var elements = TablesModel.entities.ModelElement
                                .Where(x => x.date_creation > dateTimePickeBbefore.Value.Date)
                                .Where(x => (dateTimePickerAfter.Value > dateTimePickeBbefore.Value) || x.date_utilisation < dateTimePickerAfter.Value)
                                .Select(x => new
                                {
                                    x.model_element_id,
                                    x.inventory_number,
                                    x.ModelType.model_type_name,
                                    x.ModelType.Organisations.organisation_short_name,
                                    money = x.PurchaseElements.Where(o => o.model_element_id == x.model_element_id).Sum(o => o.money),
                                    x.reason_write_off_id,
                                    broken_count = x.BrokenRequest.Count,
                                    x.is_mo,
                                    x.date_mo,
                                    x.date_to,
                                    drag_metal = x.ElementsDragMetal.Where(o => o.model_element_id == x.model_element_id).FirstOrDefault().sp_DragMetal.drag_metal_name,
                                    size_drag_metal = x.ElementsDragMetal.Where(o => o.model_element_id == x.model_element_id).Sum(o => o.size)
                                });
            if (!checkBoxAllCorpus.Checked)
            {
                elements = elements.Where(x => TablesModel.entities.ElementsPlaces.Where(o => o.model_element_id == x.model_element_id).Count() > 0
                                    && TablesModel.entities.ElementsPlaces.Where(o => o.model_element_id == x.model_element_id && o.corpus_id == int.Parse((string)comboBoxCorpus.SelectedValue)).Count() > 0);

            }

            var listDictionary = new List<Dictionary<string, string>>();
            foreach (var el in elements)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("is_mo",el.is_mo.HasValue ? el.is_mo.Value.ToString() : "0");
                dic.Add("date_mo", el.date_mo.HasValue ? el.date_mo.ToString() : DATE_NULL);
                dic.Add("date_to", el.date_to.HasValue ? el.date_to.ToString() : DATE_NULL);
                dic.Add("broken_count", el.broken_count.ToString());
                dic.Add("reason_write_off", el.reason_write_off_id.ToString());
                dic.Add("Наименование изделия", el.inventory_number);
                dic.Add("Модель", el.model_type_name);
                dic.Add("Балансовая стоимость", el.organisation_short_name);
                dic.Add("Поставщик", el.money.ToString());
                listDictionary.Add(dic);
            }


            textBoxDragMetal.Text = elements.Count() > 0 ? elements.Sum(x => x.size_drag_metal).ToString() + " гр." : "0.0 гр.";

            return listDictionary;
        }

        public void UpdateRM()
        {

        }

        private void comboBoxCorpus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void checkedListBoxRm_SelectedIndexChanged(object sender, EventArgs e)
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

        private void buttonStatisticRM_Click(object sender, EventArgs e)
        {
            new ExcelController().GeneratePMExample(null);
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void comboBoxCorpus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void comboBoxCorpus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void dateTimePickerAfter_ValueChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void dateTimePickeBbefore_ValueChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var  list = UpdateState();
            
            if (checkedListBox1.SelectedIndex < 0)
                return;
            ExcelController excel = new ExcelController();

            if (checkedListBox1.SelectedIndex == 0)
            {//3
                list = list.Where(x => x["reason_write_off"] == "3");
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {//0
                list = list.Where(x => x["reason_write_off"] == "0");
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {//4
                list = list.Where(x => x["reason_write_off"] == "4");
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {//1
                list = list.Where(x => x["reason_write_off"] == "1");
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 4)
            {
                list = list.Where(x => int.Parse(x["broken_count"]) > 0);
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 5)
            {
                list = list.Where(x => x["is_mo"] == "1"
                            && Math.Abs((DateTime.Now - DateTime.Parse(x["date_mo"])).Days) / 365 < 1);
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 6)
            {
                list = list.Where(x => x["is_mo"] == "0"
                            && Math.Abs((DateTime.Now - DateTime.Parse(x["date_mo"])).Days) / 365 > 1);
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 7)
            {
                list = list.Where(x =>  Math.Abs((DateTime.Now - DateTime.Parse(x["date_to"])).Days) / 365 < 1);
                excel.GenerateModelElementsExample(list);
            }
            else if (checkedListBox1.SelectedIndex == 8)
            {
                list = list.Where(x => Math.Abs((DateTime.Now - DateTime.Parse(x["date_to"])).Days) / 365 > 1);
                excel.GenerateModelElementsExample(list);
            }
        }

        private void dateTimePickerbeforeRM_ValueChanged(object sender, EventArgs e)
        {
            UpdateRM();
        }

        private void dateTimePickerAfterRM_ValueChanged(object sender, EventArgs e)
        {
            UpdateRM();
        }
    }
}
