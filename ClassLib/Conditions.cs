//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conditions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conditions()
        {
            this.Offers = new HashSet<Offers>();
        }
    
        public int c_ID { get; set; }
        public int c_client_type { get; set; }
        public int c_sum_max { get; set; }
        public int c_sum_min { get; set; }
        public int c_deposit_count_min { get; set; }
        public int c_credit_count_max { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
