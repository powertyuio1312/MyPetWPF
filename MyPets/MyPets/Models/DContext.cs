namespace MyPets.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DContext : DbContext
    {
        public DContext()
            : base("name=DContext")
        {
        }

        public virtual DbSet<CARE> CAREs { get; set; }
        public virtual DbSet<KIND> KINDS { get; set; }
        public virtual DbSet<PET> PETS { get; set; }
        public virtual DbSet<PETSPROGRESS> PETSPROGRESSes { get; set; }
        public virtual DbSet<PETTYPE> PETTYPES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KIND>()
                .HasMany(e => e.PETS)
                .WithOptional(e => e.KIND)
                .HasForeignKey(e => e.petKIND);

            modelBuilder.Entity<PETTYPE>()
                .HasMany(e => e.KINDS)
                .WithOptional(e => e.PETTYPE)
                .HasForeignKey(e => e.typeID);

            modelBuilder.Entity<PETTYPE>()
                .HasMany(e => e.PETS)
                .WithOptional(e => e.PETTYPE1)
                .HasForeignKey(e => e.petTYPE);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.PETS)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
