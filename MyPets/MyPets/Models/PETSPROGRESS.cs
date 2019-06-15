namespace MyPets.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PETSPROGRESS")]
    public partial class PETSPROGRESS
    {
        public int id { get; set; }

        public int? petID { get; set; }

        [StringLength(30)]
        public string ACTIVITY { get; set; }

        public double? WEIGHTcur { get; set; }

        [StringLength(30)]
        public string APET { get; set; }

        [StringLength(30)]
        public string HEAR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEcurr { get; set; }

        public virtual PET PET { get; set; }
    }
}
