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




    }
}
