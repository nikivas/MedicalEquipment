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
    
    public partial class Organization
    {
        public int Organisation_id { get; set; }
        public Nullable<int> Organization_type_id { get; set; }
        public string Full_name { get; set; }
        public string Short_name { get; set; }
        public Nullable<int> Legal_address_id { get; set; }
        public Nullable<int> Actual_address_id { get; set; }
        public string Contact_information { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public Nullable<int> Head_id { get; set; }
        public Nullable<System.DateTime> Last_update { get; set; }
    }
}