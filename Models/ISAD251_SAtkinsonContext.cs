using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace COMP2001_Review.Models
{
    public partial class ISAD251_SAtkinsonContext : DbContext
    {
        public ISAD251_SAtkinsonContext()
        {
        }

        public ISAD251_SAtkinsonContext(DbContextOptions<ISAD251_SAtkinsonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=socem1.uopnet.plymouth.ac.uk;Database=ISAD251_SAtkinson;User Id=SAtkinson;Password=ISAD123!;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient", "RB");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.Allergen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
