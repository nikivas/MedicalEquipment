using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalComponents.Models
{
    public class ComboBoxWorker
    {
        public static void initCountry(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_CountryKey
                      select new
                      {
                          id = el.country_key_id,
                          value = el.country_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initWriteOff(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_ReasonWriteOff
                      select new
                      {
                          id = el.reason_write_off_id,
                          value = el.reason_write_off_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initModelType(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.ModelType
                      select new
                      {
                          id = el.model_type_id,
                          value = el.model_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initOrganisation(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.Organisations
                      select new
                      {
                          id = el.organisation_id,
                          value = el.organisation_full_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initFuncModel(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_FunctionalyUseModel
                      select new
                      {
                          id = el.functionaly_use_model_id,
                          value = el.functionaly_use_model_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initExpluatationRole(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_ExpluatationRole
                      select new
                      {
                          id = el.expluatation_role_id,
                          value = el.expluatation_role_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initOrganisationType(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_OrganisationType
                      select new
                      {
                          id = el.organisation_type_id,
                          value = el.organisation_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initDepartment(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_OrganisationDepartment
                      select new
                      {
                          id = el.organisation_department_id,
                          value = el.organisation_department_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }
    }
}
