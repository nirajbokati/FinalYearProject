//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPackage()
        {
            this.tblDayActivities = new HashSet<tblDayActivity>();
            this.tblGalleries = new HashSet<tblGallery>();
        }
    
        public int Tour_ID { get; set; }
        public string Tour_Name { get; set; }
        public string Package_Image { get; set; }
        public string Packagedetails { get; set; }
        public string OfferInclude { get; set; }
        public string OfferExclude { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public Nullable<int> Price { get; set; }
        public string Extra { get; set; }
        public string Extratwo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDayActivity> tblDayActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGallery> tblGalleries { get; set; }
    }
}