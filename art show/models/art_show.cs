namespace art_show_app.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("art.art_show")]
    public partial class art_show
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public art_show()
        {
            artworks = new HashSet<artwork>();
        }

        [Key]
        [Column(Order = 0)]
        public DateTime date_and_time { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(45)]
        public string location { get; set; }

        [StringLength(45)]
        public string contact_phone { get; set; }

        [StringLength(45)]
        public string contact_name { get; set; }

        [StringLength(45)]
        public string artist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artwork> artworks { get; set; }
    }
}
