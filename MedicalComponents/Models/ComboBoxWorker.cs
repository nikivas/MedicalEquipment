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
        public static void initCorpus(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_Corpus
                      select new
                      {
                          id = el.corpus_id,
                          value = el.corpus_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

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

        public static void initFIO(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.PhysicalPeople
                      select new
                      {
                          id = el.physical_people_id,
                          value = el.name+" "+el.family+" "+el.patronumic
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initPeoplePosition(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_PysicalPeoplePositions
                      select new
                      {
                          id = el.physical_people_position_id,
                          value = el.physical_people_position_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initModelElement(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.ModelElement
                      select new
                      {
                          id = el.model_element_id,
                          value = el.inventory_number
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initServiceOperationRole(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_ServiceOperationPersonalRole
                      select new
                      {
                          id = el.service_operation_personal_role_id,
                          value = el.service_operation_personal_role_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initDragMetal(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_DragMetal
                      select new
                      {
                          id = el.drag_metal_id,
                          value = el.drag_metal_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initServiceType(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_ServiceType
                      select new
                      {
                          id = el.service_type_id,
                          value = el.service_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initServiceOperation(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_ServiceOperationType
                      select new
                      {
                          id = el.service_operation_type_id,
                          value = el.service_operation_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initPurchase(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_PurchaseType
                      select new
                      {
                          id = el.purchase_type_id,
                          value = el.purchase_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initZIPMElement(ComboBox cmb, int isZIP)
        {
            var res = from el in TablesModel.entities.sp_ZIP_AND_PM_Element
                      where el.isZIP == isZIP
                      select new
                      {
                          id = el.zipPM_element_id,
                          value = el.zipPM_element_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public static void initBroken(ComboBox cmb)
        {
            var res = from el in TablesModel.entities.sp_BrokenRequestReason
                      select new
                      {
                          id = el.broken_request_reason_id,
                          value = el.broken_request_reason_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }


        public static void initModelTypeByCorpusId(ComboBox cmb, int id)
        {
            var res = from el in TablesModel.entities.sp_Standarts
                      where el.corpus_id == id
                      select new
                      {
                          id = el.ModelType.model_type_id,
                          value = el.ModelType.model_type_name
                      };
            cmb.DataSource = res.ToList();
            cmb.DisplayMember = "value";
            cmb.ValueMember = "id";
            if (res.Count() > 0)
                cmb.SelectedIndex = 0;
        }

    }
}
