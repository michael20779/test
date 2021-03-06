// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using corewebapioracle.Data;

namespace corewebapioracle.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210908072056_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("OT")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("corewebapioracle.Data.ContactEm", b =>
                {
                    b.Property<decimal>("ContactId")
                        .HasColumnType("NUMBER")
                        .HasColumnName("CONTACT_ID");

                    b.Property<string>("CrmId")
                        .HasMaxLength(38)
                        .HasColumnType("NCHAR(38)")
                        .HasColumnName("CRM_ID")
                        .IsFixedLength(true);

                    b.Property<string>("Email")
                        .HasMaxLength(38)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(38)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("FullName")
                        .HasMaxLength(38)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(38)")
                        .HasColumnName("FULL_NAME");

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("PHONE_NO");

                    b.HasKey("ContactId")
                        .HasName("CONTACT_EM_PK");

                    b.ToTable("CONTACT_EM");
                });
#pragma warning restore 612, 618
        }
    }
}
