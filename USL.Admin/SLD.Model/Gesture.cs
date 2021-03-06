//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gesture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gesture()
        {
            this.GestureMappers = new HashSet<GestureMapper>();
        }
    
        public int GestureID { get; set; }
        public string GestureName { get; set; }
        public string Matrix { get; set; }
        public int Hands { get; set; }
        public int Fingers { get; set; }
        public Nullable<int> MockupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GestureMapper> GestureMappers { get; set; }
    }
}
