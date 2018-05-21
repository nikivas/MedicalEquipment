using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicalComponents.Models
{
    class TablesModel
    {
        
        public MainDatabaseEntities1 entities = new MainDatabaseEntities1();
        public IEnumerable<object> FillOrganisation(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from organisation in entities.Organisations
                      select new
                      {
                          organisation_id = organisation.organisation_id,
                          organisation_name = organisation.organisation_full_name,
                          organisation_short_name = organisation.organisation_short_name,
                          organisation_type = organisation.sp_OrganisationType.organisation_type_name,
                          contact_information = organisation.contacts,
                          email = organisation.email
                      }).ToList();


            dic.Add("organisation_id", "Идентификатор Организации");
            dic.Add("organisation_name", "Полное название");
            dic.Add("organisation_short_name", "Короткое название");
            dic.Add("organisation_type", "Тип организации");
            dic.Add("contact_information", "Контакты");
            dic.Add("email", "email");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }


        public IEnumerable<object> FillModelTypes(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from modelType in entities.ModelType
                       select new
                       {
                           model_type_id = modelType.model_type_id,
                           model_type_name = modelType.model_type_name,
                           organisation_name = modelType.Organisations.organisation_full_name,
                           functionaly_use_model = modelType.sp_FunctionalyUseModel.functionaly_use_model_name,
                           expluatation_role = modelType.sp_ExpluatationRole.expluatation_role_name

                       }).ToList();


            dic.Add("model_type_id", "id записи");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("organisation_name", "Название организации");
            dic.Add("functionaly_use_model", "Функциональное назначение модели");
            dic.Add("expluatation_role", "Роль эксплуатации");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }





    }
}
