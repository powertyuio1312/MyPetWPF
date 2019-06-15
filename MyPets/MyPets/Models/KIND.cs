namespace MyPets.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KINDS")]
    public partial class KIND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KIND()
        {
            PETS = new HashSet<PET>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string petKIND { get; set; }

        public int? typeID { get; set; }

        public virtual PETTYPE PETTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET> PETS { get; set; }
    }
}
