using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace corewebapioracle.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactEm> ContactEms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=OT;Password=OraPasswd1;Data Source=65.52.183.15:1521/oratest1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("OT")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<ContactEm>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("CONTACT_EM_PK");

                entity.ToTable("CONTACT_EM");

                entity.Property(e => e.ContactId)
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_ID")
                    .HasDefaultValueSql("sys_guid() ");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(38)
                    .HasColumnName("CRM_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FullName)
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
