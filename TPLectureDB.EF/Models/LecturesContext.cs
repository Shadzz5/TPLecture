using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TPLectureDB.EF.Models
{
    public partial class lecturesContext : DbContext
    {
        public lecturesContext()
        {
        }

        public lecturesContext(DbContextOptions<lecturesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commentaire> Commentaire { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=localhost;Database=lectures;Uid=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentaire>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PRIMARY");

                entity.ToTable("commentaire");

                entity.HasIndex(e => e.IdentifiantLivre)
                    .HasName("fk_commentaire_livre");

                entity.Property(e => e.Identifiant).HasColumnType("int(11)");

                entity.Property(e => e.Commentaire1)
                    .IsRequired()
                    .HasColumnName("commentaire");

                entity.Property(e => e.Datepublication)
                    .HasColumnName("datepublication")
                    .HasColumnType("date");

                entity.Property(e => e.IdentifiantLivre).HasColumnType("int(11)");

                entity.Property(e => e.Pseudo)
                    .IsRequired()
                    .HasColumnName("pseudo")
                    .HasMaxLength(255);

                entity.Property(e => e.Timepublication).HasColumnName("timepublication");

                entity.HasOne(d => d.IdentifiantLivreNavigation)
                    .WithMany(p => p.CommentaireNavigation)
                    .HasForeignKey(d => d.IdentifiantLivre)
                    .HasConstraintName("fk_commentaire_livre");
            });

            modelBuilder.Entity<Livre>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PRIMARY");

                entity.ToTable("livre");

                entity.Property(e => e.Identifiant).HasColumnType("int(11)");

                entity.Property(e => e.DateEdition).HasColumnType("date");

                entity.Property(e => e.DateLecture).HasColumnType("date");

                entity.Property(e => e.Edition)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(255);

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
