//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalComponents.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOExpluatation
    {
        public int mo_expluatation_id { get; set; }
        public int physical_people_id { get; set; }
        public int model_element_id { get; set; }
        public System.DateTime date_begin { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public int service_operation_personal_role_id { get; set; }
    
        public virtual ModelElement ModelElement { get; set; }
        public virtual PhysicalPeople PhysicalPeople { get; set; }
        public virtual sp_ServiceOperationPersonalRole sp_ServiceOperationPersonalRole { get; set; }
    }
}
