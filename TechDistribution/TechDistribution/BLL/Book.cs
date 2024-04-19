//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechDistribution.BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }
    
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> YearPublished { get; set; }
        public Nullable<int> QOH { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> PublisherID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
