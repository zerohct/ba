using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<loaisach> loaisaches { get; set; }
        public virtual DbSet<sach> saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<loaisach>()
                .HasMany(e => e.saches)
                .WithRequired(e => e.loaisach)
                .WillCascadeOnDelete(false);
        }
    }
}
