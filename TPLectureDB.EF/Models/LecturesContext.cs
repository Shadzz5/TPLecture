using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TPLectureDB.EF.Models
{
    public partial class LecturesContext : DbContext
    {
        public LecturesContext()
        {
        }

        public LecturesContext(DbContextOptions<LecturesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Livre> Livre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Database=Lectures;Uid=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PRIMARY");

                entity.ToTable("livre");

                entity.Property(e => e.Identifiant).HasColumnType("int(11)");

                entity.Property(e => e.DateEdition).HasColumnType("year(4)");

                entity.Property(e => e.DateLecture).HasColumnType("date");

                entity.Property(e => e.Edition)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.NombrePages).HasColumnType("int(11)");

                entity.Property(e => e.Note).HasColumnType("int(11)");

                entity.Property(e => e.Resume).HasMaxLength(4000);

                entity.Property(e => e.Titre)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
