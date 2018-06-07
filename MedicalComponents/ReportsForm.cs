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
            //ComboBoxWorker.initModelType(comboBoxModel);
            InitCombobBoxes();
        }

        public void InitCombobBoxes()
        {
            ComboBoxWorker.initModelType(comboBoxModel);
            ComboBoxWorker.initModelType(comboBoxModelRM);
            ComboBoxWorker.initCorpus(comboBoxCorpus);
            ComboBoxWorker.initCorpus(comboBoxCorpusRM);
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
                                    x.ModelType.Organisations.organisation_full_name,
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
                if(comboBoxCorpus.SelectedIndex >= 0)
                {
                    int value = int.Parse((string)comboBoxCorpus.SelectedValue);
                    elements = elements.Where(x => TablesModel.entities.ElementsPlaces.Where(o => o.model_element_id == x.model_element_id).Count() > 0
                                        && TablesModel.entities.ElementsPlaces.Where(o => o.model_element_id == x.model_element_id && o.corpus_id == value).Count() > 0);
                }
                

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
                dic.Add("Поставщик", el.organisation_full_name);
                dic.Add("Балансовая стоимость", el.money.ToString());
                listDictionary.Add(dic);
            }
            var listEl = elements.ToList();

            textBoxDragMetal.Text = elements.Count() > 0 ? elements.Sum(x => x.size_drag_metal).ToString() + " гр." : "0.0 гр.";

            return listDictionary;
        }

        public IEnumerable<Dictionary<string,string>> UpdateRM()
        {
            var elements = TablesModel.entities.ZIPPMonStock
                                //.Where()
                                .Select(x => new
                                {
                                    x.sp_ZIP_AND_PM_Element.zipPM_element_name,
                                    x.count,
                                    x.sp_ZIP_AND_PM_Element
                                });
            if (!checkBoxAllCorpus.Checked)
            {
                if(comboBoxCorpusRM.SelectedIndex >= 0)
                {
                    int value = int.Parse((string)comboBoxCorpusRM.SelectedValue);
                    elements = elements.Where(
                        x => x.sp_ZIP_AND_PM_Element.ZIPPMMoves.Where(o=>x.sp_ZIP_AND_PM_Element.zipPM_element_id ==  o.zipPM_element_id).Count() > 0 
                        && x.sp_ZIP_AND_PM_Element.ZIPPMMoves.Where(o => x.sp_ZIP_AND_PM_Element.zipPM_element_id == o.zipPM_element_id).FirstOrDefault().ModelElement.ElementsPlaces.Where(o => o.model_element_id == x.sp_ZIP_AND_PM_Element.ZIPPMMoves.FirstOrDefault().model_element_id).Count() > 0
                        && x.sp_ZIP_AND_PM_Element.ZIPPMMoves.Where(o => x.sp_ZIP_AND_PM_Element.zipPM_element_id == o.zipPM_element_id).FirstOrDefault().ModelElement.ElementsPlaces.Where(o => o.model_element_id == x.sp_ZIP_AND_PM_Element.ZIPPMMoves.FirstOrDefault().model_element_id && o.corpus_id == value ).Count() > 0);
                }
            }

            var listDictionary = new List<Dictionary<string, string>>();
            foreach (var el in elements)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("Наименование изделия", el.zipPM_element_name);
                dic.Add("Модель", el.count.ToString());
                listDictionary.Add(dic);
            }
            return listDictionary;
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
            for (int i = 0; i < checkedListBoxRm.Items.Count; i++)
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
            ExcelController excel = new ExcelController();
            var list = UpdateRM();
            if(checkedListBoxRm.SelectedIndex < 0)
            {
                return;
            }

            if(checkedListBoxRm.SelectedIndex == 0)
            {
                excel.GeneratePMExample(list);
            }
            else if (checkedListBoxRm.SelectedIndex == 1)
            {
                var linqResult = new List<Dictionary<string, string>>();

                var list1 = from el in TablesModel.entities.ZIPPMDocumentsOnPurchase
                       where el.date_coming_in >= dateTimePickerbeforeRM.Value && el.date_coming_in <= dateTimePickerAfterRM.Value
                       select new
                       {
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.count,
                           el.sp_ZIP_AND_PM_Element
                       };
                foreach (var el in list1)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("Наименование изделия", el.zipPM_element_name);
                    dic.Add("Модель", el.count.ToString());
                    linqResult.Add(dic);
                }
                excel.GeneratePMExample(linqResult);
            }
            else if (checkedListBoxRm.SelectedIndex == 2)
            {
                var linqResult = new List<Dictionary<string, string>>();
                var list1 = from el in TablesModel.entities.ZIPPMMoves
                            where el.date_move >= dateTimePickerbeforeRM.Value && el.date_move <= dateTimePickerAfterRM.Value
                            select new
                            {
                                el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                                count = 1,
                                el.sp_ZIP_AND_PM_Element
                            };
                foreach (var el in list1)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("Наименование изделия", el.zipPM_element_name);
                    dic.Add("Модель", el.count.ToString());
                    linqResult.Add(dic);
                }

                excel.GeneratePMExample(linqResult);
            }
            else if (checkedListBoxRm.SelectedIndex == 3)
            {
                var linqResult = new List<Dictionary<string, string>>();
                var list1 = from el in TablesModel.entities.ZIPPMMoves
                            where el.date_move >= dateTimePickerbeforeRM.Value && el.date_move <= dateTimePickerAfterRM.Value
                            select new
                            {
                                el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                                count = 1,
                                el.sp_ZIP_AND_PM_Element
                            };
                foreach (var el in list1)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("Наименование изделия", el.zipPM_element_name);
                    dic.Add("Модель", el.count.ToString());
                    linqResult.Add(dic);
                }

                excel.GeneratePMExample(linqResult);
            }
            
            //new ExcelController().GeneratePMExample(null);
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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //var lst = TablesModel.entities.ModelType.Select(x => x.model_type_id).ToList();

            //Random rnd = new Random();
            //int start_idx = TablesModel.entities.ModelElement.Count() > 0 ? TablesModel.entities.ModelElement.Max(x => x.model_element_id) + 1 : 0;
            //foreach (var el in lst)
            //{
            //    for (int i = 0; i < rnd.Next(10, 30); i++)
            //    {
            //        int value = rnd.Next(5, 40);
            //        var random_to = DateTime.Parse("01.01.2017");
            //        random_to = DateTime.Parse(rnd.Next(2, 28).ToString().PadLeft(2, '0') + "." + rnd.Next(1, 12).ToString().PadLeft(2, '0') + "." + rnd.Next(2015, 2017).ToString().PadLeft(4, '0'));
            //        var rnd_mo = rnd.Next(0, 1);
            //        var random_mo = DateTime.Parse(rnd.Next(2, 28).ToString().PadLeft(2, '0') + "." + rnd.Next(1, 12).ToString().PadLeft(2, '0') + "." + rnd.Next(2015, 2017).ToString().PadLeft(4, '0'));

            //        var create = DateTime.Parse(rnd.Next(2, 28).ToString().PadLeft(2, '0') + "." + rnd.Next(1, 12).ToString().PadLeft(2, '0') + "." + rnd.Next(2008, 2012).ToString().PadLeft(4, '0'));
            //        DateTime util;
            //        if(rnd.Next(1,3) < 3)
            //        {
            //            util = DateTime.Parse(rnd.Next(2, 28).ToString().PadLeft(2, '0') + "." + rnd.Next(1, 6).ToString().PadLeft(2, '0') + ".2018"); ;
            //        }
            //        else
            //        {
            //            util = DateTime.Parse(rnd.Next(2, 28).ToString().PadLeft(2, '0') + "." + rnd.Next(5, 12).ToString().PadLeft(2, '0') + ".2017"); ;
            //        }

            //        var rnd_expl = rnd.Next(0, 4);
            //        var rnd_ser = rnd.Next(1000, 9999).ToString();
            //        var rnd_number = rnd.Next(1000000, 1999999).ToString();
            //        var obj = new ModelElement()
            //        {
            //            model_element_id = start_idx,
            //            date_to = random_to,
            //            is_mo = rnd_mo,
            //            date_mo = random_mo,
            //            inventory_number = rnd_number,
            //            date_creation = create,
            //            date_utilisation = util,
            //            reason_write_off_id = rnd_expl,
            //            serial_number = rnd_ser,
            //            model_type_id = el,
            //            other = ".."
            //        };
            //        start_idx++;
            //        TablesModel.entities.ModelElement.Add(obj);


            //    }
            //    TablesModel.entities.SaveChanges();
            //}

            var listElements = TablesModel.entities.ModelElement.Select(x => x);
            var id = TablesModel.entities.ElementsPlaces.Count() > 0 ? TablesModel.entities.ElementsPlaces.Max(x => x.element_place_id)+1 : 0;
            Random rnd = new Random();
            List<ElementsPlaces> lst = new List<ElementsPlaces>();
            foreach (var el in listElements)
            {
                int corp_id = rnd.Next(1, 8);
                var begin = el.date_creation.Value;
                
                var place = new ElementsPlaces()
                {
                    element_place_id = id,
                    corpus_id = corp_id,
                    date_begin = begin,
                    date_end = el.date_utilisation,
                    floor = 0,
                    room = "0",
                    move_reason_id = 0,
                    model_element_id = el.model_element_id
                };
                id++;
                lst.Add(place);
                
            }
            TablesModel.entities.ElementsPlaces.AddRange(lst);
            TablesModel.entities.SaveChanges();


            MessageBox.Show("done");
        }
    }
}
