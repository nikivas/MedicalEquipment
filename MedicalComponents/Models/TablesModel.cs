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
        
        public static MainDatabaseEntities4 entities = new MainDatabaseEntities4();
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

        public IEnumerable<object> FillModelElement(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from model in entities.ModelElement
                       select new
                       {
                           model.model_element_id,
                           model.inventory_number,
                           model.ModelType.model_type_name,
                           model.date_creation,
                           model.date_utilisation,
                           model.serial_number,
                           model.sp_ReasonWriteOff.reason_write_off_name,
                           model.ModelToPurchase.Where(x=>x.model_element_id == model.model_element_id)
                                                .FirstOrDefault()
                                                .Purchase
                                                .purchase_document_number
                           
                       }).ToList();


            dic.Add("model_element_id", "id записи");
            dic.Add("inventory_number", "Инвентарный номер");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("date_creation", "Дата создания");
            dic.Add("date_utilisation", "Дата утилизации");
            dic.Add("serial_number", "Серийный номер");
            dic.Add("reason_write_off_name", "Причина списания");
            dic.Add("purchase_document_number", "Номер документа-поставки");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPhysicalPeople(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from people in entities.PhysicalPeople
                       select new
                       {
                           people.physical_people_id,
                           people.name,
                           people.family,
                           people.patronumic,
                           gender = people.Gender.Value == 1 ? "муж" : "жен",
                           people.contacts,
                           people.sp_OrganisationDepartment.organisation_department_name
                       }).ToList();


            dic.Add("physical_people_id", "id записи");
            dic.Add("name", "Имя");
            dic.Add("family", "Фамилия");
            dic.Add("patronumic", "Отчество");
            dic.Add("gender", "Пол");
            dic.Add("contacts", "Контакты");
            dic.Add("organisation_department_name", "Отдел");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPhysicalPeoplePositions(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from people_pos in entities.FaticalPhysicalPeoplePositions
                       select new
                       {
                           people_pos.people_position_id,
                           people_pos.sp_PysicalPeoplePositions.physical_people_position_name,
                           people_pos.date_begin,
                           people_pos.date_end,
                           people_pos.salary
                           

                       }).ToList();


            dic.Add("people_position_id", "id записи");
            dic.Add("date_begin", "Дата начала работы");
            dic.Add("date_end", "Дата конца работы");
            dic.Add("salary", "Зарплата");
            dic.Add("physical_people_position_name", "Название должности");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillMOExpluatation(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from mo_exxpluatation in entities.MOExpluatation
                       select new
                       {
                           mo_exxpluatation.mo_expluatation_id,
                           fio = mo_exxpluatation.PhysicalPeople.name+" "+mo_exxpluatation.PhysicalPeople.family,
                           mo_exxpluatation.sp_ServiceOperationPersonalRole.service_operation_personal_role_name,
                           mo_exxpluatation.ModelElement.ModelType.model_type_name,
                           mo_exxpluatation.ModelElement.inventory_number,
                           mo_exxpluatation.date_begin,
                           mo_exxpluatation.date_end


                       }).ToList();


            dic.Add("mo_expluatation_id", "id записи");
            dic.Add("date_begin", "Дата начала работы");
            dic.Add("date_end", "Дата конца работы");
            dic.Add("fio", "ФИО");
            dic.Add("service_operation_personal_role_name", "Роль Операции");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "Инвентарный номер");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillElementsDragMetal(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from drags in entities.ElementsDragMetal
                       select new
                       {
                           drags.elements_drag_metal_id,
                           drags.ModelElement.ModelType.model_type_name,
                           drags.ModelElement.inventory_number,
                           drags.sp_DragMetal.drag_metal_name,
                           drags.size


                       }).ToList();


            dic.Add("elements_drag_metal_id", "id записи");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "Инвентарный номер");
            dic.Add("drag_metal_name", "драгоценный металл");
            dic.Add("size", "вес (гр.)");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPersonalOnService(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.PersonalOnService
                       select new
                       {
                           el.personal_on_service_id,
                           el.ModelElement.ModelType.model_type_name,
                           el.ModelElement.inventory_number,
                           fio = el.PhysicalPeople.name+" "+el.PhysicalPeople.family+" "+el.PhysicalPeople.patronumic,
                           el.sp_ServiceOperationType.service_operation_type_name,
                           el.sp_ServiceOperationPersonalRole.service_operation_personal_role_name

                       }).ToList();


            dic.Add("personal_on_service_id", "id записи");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "Инвентарный номер");
            dic.Add("fio", "ФИО");
            dic.Add("service_operation_type_name", "Тип операции");
            dic.Add("service_operation_personal_role_name", "Роль эксплуатации");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPurchase(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.Purchase
                       select new
                       {
                           el.purchase_id,
                           el.sp_PurchaseType.purchase_type_name,
                           el.purchase_document_number,
                           el.date_apply
                       }).ToList();


            dic.Add("purchase_id", "id записи");
            dic.Add("purchase_type_name", "Тип закупки");
            dic.Add("purchase_document_number", "Номер документа");
            dic.Add("date_apply", "Дата приобритения");
            

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillZipOnStock(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMonStock
                       where el.sp_ZIP_AND_PM_Element.isZIP == 1
                       select new
                       {
                           el.zipPM_on_stock_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.count
                       }).ToList();


            dic.Add("zipPM_on_stock_id", "id записи");
            dic.Add("zipPM_element_name", "Название ЗИП");
            dic.Add("count", "количество");


            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPMOnStock(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMonStock
                       where el.sp_ZIP_AND_PM_Element.isZIP != 1
                       select new
                       {
                           el.zipPM_on_stock_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.count
                       }).ToList();


            dic.Add("zipPM_on_stock_id", "id записи");
            dic.Add("zipPM_element_name", "Название PM");
            dic.Add("count", "количество");


            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillZIPMoves(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMMoves
                       where el.sp_ZIP_AND_PM_Element.isZIP == 1
                       select new
                       {
                           el.zipPM_move_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.date_move,
                           el.ModelElement.ModelType.model_type_name,
                           el.ModelElement.inventory_number
                       }).ToList();


            dic.Add("zipPM_on_stock_id", "id записи");
            dic.Add("zipPM_element_name", "Название ZIP ");
            dic.Add("date_move", "Дата перемещения со склада");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "инвентарный номер");


            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillPMMoves(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMMoves
                       where el.sp_ZIP_AND_PM_Element.isZIP != 1
                       select new
                       {
                           el.zipPM_move_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.date_move,
                           el.ModelElement.ModelType.model_type_name,
                           el.ModelElement.inventory_number
                       }).ToList();


            dic.Add("zipPM_on_stock_id", "id записи");
            dic.Add("zipPM_element_name", "Название PM");
            dic.Add("date_move", "Дата перемещения со склада");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "инвентарный номер");


            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillBrokenRequest(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.BrokenRequest
                       select new
                       {
                           el.broken_request_id,
                           el.sp_BrokenRequestReason.broken_request_reason_name,
                           fio = el.PhysicalPeople.name+" "+el.PhysicalPeople.family+" "+el.PhysicalPeople.patronumic,
                           el.ModelElement.ModelType.model_type_name,
                           el.ModelElement.inventory_number,
                           el.date_to_repair,
                           isFinished = el.isFinished == 0 ? "Нет" : "Да"
                       }).ToList();


            dic.Add("broken_request_id", "id записи");
            dic.Add("broken_request_reason_name", "Название ZIP / PM");
            dic.Add("fio", "ФИО человека оставившего заявку");
            dic.Add("model_type_name", "Тип модели");
            dic.Add("inventory_number", "инвентарный номер");
            dic.Add("date_to_repair", "Дата подачи");
            dic.Add("isFinished", "Неполадка устранена?");
            

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> FillZIPDocumentsOnPurchase(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMDocumentsOnPurchase
                       where el.sp_ZIP_AND_PM_Element.isZIP == 1
                       select new
                       {
                           el.zipPM_documents_purchase_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.count,
                           el.date_coming_in,
                           el.date_to_end_possible_use
                       }).ToList();


            dic.Add("zipPM_documents_purchase_id", "id записи");
            dic.Add("zipPM_element_name", "Название PM");
            dic.Add("count", "количество");
            dic.Add("date_coming_in", "Планируемая дата поставки");
            dic.Add("date_to_end_possible_use", "Фактическая дата поставки");
            DataGridWorker.FillDataGrid(dataGridView, res, dic);
            return res;
        }

        public IEnumerable<object> FillPMDocumentsOnPurchase(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.ZIPPMDocumentsOnPurchase
                       where el.sp_ZIP_AND_PM_Element.isZIP != 1
                       select new
                       {
                           el.zipPM_documents_purchase_id,
                           el.sp_ZIP_AND_PM_Element.zipPM_element_name,
                           el.count,
                           el.date_coming_in,
                           el.date_to_end_possible_use
                       }).ToList();


            dic.Add("zipPM_documents_purchase_id", "id записи");
            dic.Add("zipPM_element_name", "Название PM");
            dic.Add("count", "количество");
            dic.Add("date_coming_in", "Планируемая дата поставки");
            dic.Add("date_to_end_possible_use", "Фактическая дата поставки");
            DataGridWorker.FillDataGrid(dataGridView, res, dic);
            return res;
        }

        public IEnumerable<object> FillPurchaseElement(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.PurchaseElements
                       select new
                       {
                           el.purchase_element_id,
                           el.ModelElement.ModelType.model_type_name,
                           el.count,
                           el.planned_date,
                           el.target_info,
                           isPurchasing = el.isPurchasing == 0 ? "Нет " : "Да"
                       }).ToList();


            dic.Add("purchase_element_id", "id записи");
            dic.Add("model_type_name", "Название типа модели");
            dic.Add("count", "количество");
            dic.Add("planned_date", "Дата поставки");
            dic.Add("target_info", "Цель приобретения");
            dic.Add("isPurchasing", "Уже куплено");
            DataGridWorker.FillDataGrid(dataGridView, res, dic);
            return res;
        }




        public IEnumerable<object> Fillsp_OrganisationType(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from org in entities.sp_OrganisationType
                       select new
                       {
                           org.organisation_type_id,
                           org.organisation_type_name

                       }).ToList();


            dic.Add("organisation_type_id", "id записи");
            dic.Add("organisation_type_name", "Тип организации по виду деятельности");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_Country(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_CountryKey
                       select new
                       {
                           el.country_key_id,
                           el.country_name
                           

                       }).ToList();


            dic.Add("country_key_id", "id записи");
            dic.Add("country_name", "Название страны");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_FunctionalyUseModel(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_FunctionalyUseModel
                       select new
                       {
                           el.functionaly_use_model_id,
                           el.functionaly_use_model_name


                       }).ToList();


            dic.Add("functionaly_use_model_id", "id записи");
            dic.Add("functionaly_use_model_name", "Название функционального назначения модели");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ReasonWriteoff(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ReasonWriteOff
                       select new
                       {
                           el.reason_write_off_id,
                           el.reason_write_off_name
                       }).ToList();


            dic.Add("reason_write_off_id", "id записи");
            dic.Add("reason_write_off_name", "Причина списания оборудования");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_PhysicalPeoplePositions(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_PysicalPeoplePositions
                       select new
                       {
                           el.physical_people_position_id,
                           el.physical_people_position_name
                       }).ToList();


            dic.Add("physical_people_position_id", "id записи");
            dic.Add("physical_people_position_name", "Фактические должности физических лиц");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ExpluatationRole(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ExpluatationRole
                       select new
                       {
                           el.expluatation_role_id,
                           el.expluatation_role_name
                       }).ToList();

            dic.Add("expluatation_role_id", "id записи");
            dic.Add("expluatation_role_name", "Роль в отношении эксплуатации");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_OrganisationDepartment(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_OrganisationDepartment
                       select new
                       {
                           el.organisation_department_id ,
                           el.organisation_department_name
                       }).ToList();

            dic.Add("organisation_department_id", "id записи");
            dic.Add("organisation_department_name", "Подразделение организации");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_Corpus(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_Corpus
                       select new
                       {
                           el.corpus_id,
                           el.corpus_name
                       }).ToList();

            dic.Add("organisation_department_id", "id записи");
            dic.Add("corpus_name", "Название корпуса");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_MoveReason(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_MoveReason
                       select new
                       {
                           el.move_reason_id,
                           el.move_reason_name
                       }).ToList();

            dic.Add("move_reason_id", "id записи");
            dic.Add("move_reason_name", "Причина перемещения");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_DragMetal(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_DragMetal
                       select new
                       {
                           el.drag_metal_id,
                           el.drag_metal_name
                       }).ToList();

            dic.Add("drag_metal_id", "id записи");
            dic.Add("drag_metal_name", "Вид драгоценного металла");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ServiceType(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ServiceType
                       select new
                       {
                           el.service_type_id,
                           el.service_type_name
                       }).ToList();

            dic.Add("service_type_id", "id записи");
            dic.Add("service_type_name", "Вид сервисного обслуживания");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ServiceOperationType(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ServiceOperationType
                       select new
                       {
                           el.service_operation_type_id,
                           el.service_operation_type_name
                       }).ToList();

            dic.Add("service_operation_type_id", "id записи");
            dic.Add("service_operation_type_name", "Вид  операции при сервисном обслуживании");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ServiceOperationPersonalRole(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ServiceOperationPersonalRole
                       select new
                       {
                           el.service_operation_personal_role_id,
                           el.service_operation_personal_role_name
                       }).ToList();

            dic.Add("service_operation_personal_role_id", "id записи");
            dic.Add("service_operation_personal_role_name", "Вид  операции при сервисном обслуживании");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_PurchaseType(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_PurchaseType
                       select new
                       {
                           el.purchase_type_id,
                           el.purchase_type_name
                       }).ToList();

            dic.Add("purchase_type_id", "id записи");
            dic.Add("purchase_type_name", "Вид закупки");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_ZIP(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ZIP_AND_PM_Element
                       where el.isZIP == 1
                       select new
                       {
                           el.zipPM_element_id,
                           el.zipPM_element_name,
                       }).ToList();

            dic.Add("zipPM_element_id", "id записи");
            dic.Add("zipPM_element_name", "Название ЗИП");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_PM(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_ZIP_AND_PM_Element
                       where el.isZIP != 1
                       select new
                       {
                           el.zipPM_element_id,
                           el.zipPM_element_name,
                       }).ToList();

            dic.Add("zipPM_element_id", "id записи");
            dic.Add("zipPM_element_name", "Название PM");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        public IEnumerable<object> Fillsp_BrokenRequestReason(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_BrokenRequestReason
                       select new
                       {
                           el.broken_request_reason_id,
                           el.broken_request_reason_name,
                       }).ToList();

            dic.Add("broken_request_reason_id", "id записи");
            dic.Add("broken_request_reason_name", "Причина подачи заявки на ремонт");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }

        //Fillsp_Standarts
        public IEnumerable<object> Fillsp_Standarts(DataGridView dataGridView)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var res = (from el in entities.sp_Standarts
                       select new
                       {
                           el.standart_id,
                           el.sp_Corpus.corpus_name,
                           el.ModelType.model_type_name,
                           el.count
                       }).ToList();

            dic.Add("standart_id", "id записи");
            dic.Add("corpus_name", "Причина подачи заявки на ремонт");
            dic.Add("model_type_name", "Причина подачи заявки на ремонт");
            dic.Add("count", "Причина подачи заявки на ремонт");

            DataGridWorker.FillDataGrid(dataGridView, res, dic);

            return res;
        }



    }
}
