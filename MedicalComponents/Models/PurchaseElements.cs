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
    
    public partial class PurchaseElements
    {
        public int purchase_element_id { get; set; }
        public int model_element_id { get; set; }
        public int count { get; set; }
        public System.DateTime planned_date { get; set; }
        public string target_info { get; set; }
        public int isPurchasing { get; set; }
        public Nullable<int> money { get; set; }
    
        public virtual ModelElement ModelElement { get; set; }
    }
}
