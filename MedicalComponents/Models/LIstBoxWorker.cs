using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalComponents.Models
{
    class LIstBoxWorker
    {

        public static void initZIPPM(ListBox cmb, string maskValue = ".*")
        {
            var res = from el in TablesModel.entities.sp_ZIP_AND_PM_Element
                      select new
                      {
                          id = el.zipPM_element_id,
                          value = el.zipPM_element_name
                      };
            int help = TablesModel.entities.sp_Corpus.Count();
            cmb.DataSource = res.ToList().Where(x => Regex.IsMatch(x.value, maskValue)).ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.ToList().Where(x => Regex.IsMatch(x.value, maskValue)).ToList().Count() > 0)
                cmb.SelectedIndex = 0;
        }
    }
}
