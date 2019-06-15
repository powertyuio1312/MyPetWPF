namespace MyPets.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARE")]
    public partial class CARE
    {
        public int id { get; set; }

        [Column("Care")]
        public string Care1 { get; set; }

        public string Ills { get; set; }

        public string Vacina { get; set; }
    }
}
