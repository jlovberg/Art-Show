namespace art_show_app.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("art.artwork")]
    public partial class artwork
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artwork()
        {
            art_show = new HashSet<art_show>();
        }

        [Key]
        [StringLength(45)]
        public string unique_title { get; set; }

        [StringLength(45)]
        public string artist { get; set; }

        [StringLength(45)]
        public string type_of_art { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_creation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_acquired { get; set; }

        public decimal? price { get; set; }

        [StringLength(45)]
        public string location { get; set; }

        [StringLength(13)]
        public string customerphone { get; set; }

        public virtual artist artist1 { get; set; }

        public virtual customer customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<art_show> art_show { get; set; }
    }
}
