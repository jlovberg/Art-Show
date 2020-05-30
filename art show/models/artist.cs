namespace art_show_app.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("art.artist")]
    public partial class artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artist()
        {
            artworks = new HashSet<artwork>();
        }

        [Key]
        [StringLength(45)]
        public string name { get; set; }

        [StringLength(13)]
        public string phone { get; set; }

        [StringLength(45)]
        public string address { get; set; }

        [StringLength(45)]
        public string birth_place { get; set; }

        public int? age { get; set; }

        [StringLength(45)]
        public string style_of_art { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artwork> artworks { get; set; }
    }
}
