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
    
    public partial class Organisation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organisation()
        {
            this.FaticalPhysicalPeoplePositions = new HashSet<FaticalPhysicalPeoplePosition>();
            this.ModelTypes = new HashSet<ModelType>();
        }
    
        public int organisation_id { get; set; }
        public string organisation_short_name { get; set; }
        public string organisation_full_name { get; set; }
        public int organisation_type_id { get; set; }
        public int country_key_id { get; set; }
        public string factic_address { get; set; }
        public string contacts { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaticalPhysicalPeoplePosition> FaticalPhysicalPeoplePositions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelType> ModelTypes { get; set; }
        public virtual sp_OrganisationType sp_OrganisationType { get; set; }
        public virtual sp_CountryKey sp_CountryKey { get; set; }
    }
}
