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
    
    public partial class sp_ReasonWriteOff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sp_ReasonWriteOff()
        {
            this.ModelElement = new HashSet<ModelElement>();
        }
    
        public int reason_write_off_id { get; set; }
        public string reason_write_off_name { get; set; }
        public string other { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelElement> ModelElement { get; set; }
    }
}
