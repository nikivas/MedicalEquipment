using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MedicalComponents.Models
{
    class CheckedListBoxWorker
    {

        public static void initModelType(CheckedListBox cmb, string maskValue = ".*")
        {
            var res = from el in TablesModel.entities.ModelType
                      select new
                      {
                          id = el.model_type_id,
                          value = el.model_type_name
                      };

            cmb.DataSource = res.ToList().Where(x=>Regex.IsMatch(x.value,maskValue)).ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.ToList().Where(x => Regex.IsMatch(x.value, maskValue)).ToList().Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initCorpus(CheckedListBox cmb, string maskValue = ".*")
        {
            var res = from el in TablesModel.entities.sp_Corpus
                      select new
                      {
                          id = el.corpus_id,
                          value = el.corpus_name
                      };
            int help = TablesModel.entities.sp_Corpus.Count();
            cmb.DataSource = res.ToList().Where(x => Regex.IsMatch(x.value, maskValue)).ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }


    }
}
