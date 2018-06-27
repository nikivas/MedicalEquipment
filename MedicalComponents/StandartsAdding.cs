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
    public partial class StandartsAdding : Form
    {
        public StandartsAdding()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StandartsAdding_Load(object sender, EventArgs e)
        {
            initComboListBox();
        }
        private void initComboListBox()
        {
            CheckedListBoxWorker.initCorpus(checkedListBox1);
        }

        private IEnumerable<int> selectedValues()
        {
            List<int> selected = new List<int>();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    var buf = checkedListBox1.Items[i] as dynamic;
                    selected.Add((int) buf.id);
                }
            }

            return selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> answer = new List<Dictionary<string, string>>();
            var selectedIdCorpuses = selectedValues();

            foreach (var corpusId in selectedIdCorpuses)
            {
                var result = TablesModel.entities
                                        .sp_Standarts
                                        .Where(x => x.corpus_id == corpusId)
                                        .Select(x => x.model_type_id).ToList();
                foreach (var modeltypes in result)
                {
                    var count = TablesModel.entities
                                           .ElementsPlaces
                                           .Where(x => x.corpus_id == corpusId && x.ModelElement.model_type_id == modeltypes)
                                           .Count();
                    Dictionary<string, string> buf = new Dictionary<string, string>();
                    buf.Add("Наименование модели", TablesModel.entities.ModelType.Where(x => x.model_type_id == modeltypes).Select(x => x.model_type_name).First());
                    buf.Add("Фактическое количество в отделении", count.ToString());
                    var count_doos = (TablesModel.entities.sp_Standarts.Where(x => x.model_type_id == modeltypes && x.corpus_id == corpusId).Select(x => x.count - count).First());
                    count_doos = count_doos < 0 ? 0 : count_doos;
                    buf.Add("Необходимое дооснащение", count_doos.ToString());
                    buf.Add("Отделение", TablesModel.entities.sp_Corpus.Where(x => x.corpus_id == corpusId).Select(x => x.corpus_name).First());
                    buf.Add("Требуемое количество по стандарту", TablesModel.entities.sp_Standarts.Where(x => x.model_type_id == modeltypes && x.corpus_id == corpusId).Select(x => x.count).First().ToString());
                    answer.Add(buf);
                    //Отделение
                }


            }

            //int selectedValue = selectedId.First();
            //var result = TablesModel.entities.sp_Standarts.Where(x => x.corpus_id == selectedValue).Select(x=> x.model_type_id ).ToList();
            //foreach (var el in result)
            //{
            //    var res1 = TablesModel.entities.ModelElement.Where(x => el == x.model_type_id && x.ElementsPlaces.First().sp_Corpus.corpus_id == selectedValue).Count();
            //    Dictionary<string, string> buf = new Dictionary<string, string>();
            //    buf.Add("Наименование модели", TablesModel.entities.ModelType.Where(x => x.model_type_id == el).Select(x => x.model_type_name).First());
            //    buf.Add("Количество в отделении", res1.ToString());
            //    buf.Add("Недостающее", TablesModel.entities.sp_Standarts.Where(x => x.model_type_id == el && x.corpus_id == selectedValue).Select(x => x.count - res1).ToString());
            //    buf.Add("Отделение", TablesModel.entities.sp_Corpus.Where(x => x.corpus_id == selectedValue).Select(x => x.corpus_name).First());
            //    answer.Add(buf);
            //}

            ExcelController a = new ExcelController();
            a.GenerateStandart(answer, "Информация об оснащенности по стандартам");




        }
    }
}
