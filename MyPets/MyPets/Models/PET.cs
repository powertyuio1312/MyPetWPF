namespace MyPets.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PETS")]
    public partial class PET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET()
        {
            PETSPROGRESSes = new HashSet<PETSPROGRESS>();
        }

        public int petID { get; set; }

        public int userID { get; set; }

        public int? petTYPE { get; set; }

        [StringLength(20)]
        public string petNAME { get; set; }

        public int? petAGE { get; set; }

        public int? petWEIGHT { get; set; }

        [StringLength(1)]
        public string petGENDER { get; set; }

        public int? petKIND { get; set; }

        public byte[] PHOTO { get; set; }

        public virtual KIND KIND { get; set; }

        public virtual PETTYPE PETTYPE1 { get; set; }

        public virtual USER USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PETSPROGRESS> PETSPROGRESSes { get; set; }
    }
}
