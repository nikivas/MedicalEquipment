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
        public DatabaseEntities entities = new DatabaseEntities();
        public IEnumerable<object> FillOrganisation(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from organisation in entities.Organization
                      join organisationType in entities.S_OrganisationType on organisation.Organization_type_id equals organisationType.Organisation_type_id
                      join headPeople in entities.PhysicalPeople on organisation.Head_id equals headPeople.Physical_people_Id
                      select new
                      {
                          organisation_id = organisation.Organisation_id,
                          organisation_name = organisation.Full_name,
                          organisation_short_name = organisation.Short_name,
                          organisation_type = organisationType.Organisation_type_name,
                          head_name = headPeople.Name,
                          contact_information = organisation.Contact_information,
                          email = organisation.Email,
                          site = organisation.Site
                      }).ToList();


            dic.Add("organisation_id", "Идентификатор Организации");
            dic.Add("organisation_name", "Полное название");
            dic.Add("organisation_short_name", "Короткое название");
            dic.Add("organisation_type", "Тип организации");
            dic.Add("head_name", "Имя руководителя");
            dic.Add("contact_information", "Контакты");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }




    }
}
