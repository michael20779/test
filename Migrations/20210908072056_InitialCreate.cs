using Microsoft.EntityFrameworkCore.Migrations;

namespace corewebapioracle.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "OT");

            migrationBuilder.CreateTable(
                name: "CONTACT_EM",
                schema: "OT",
                columns: table => new
                {
                    CONTACT_ID = table.Column<string>(type: "VARCHAR2(38)", nullable: false),
                    CRM_ID = table.Column<string>(type: "NCHAR(38)", fixedLength: true, maxLength: 38, nullable: true),
                    FULL_NAME = table.Column<string>(type: "VARCHAR2(38)", unicode: false, maxLength: 38, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR2(38)", unicode: false, maxLength: 38, nullable: true),
                    PHONE_NO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CONTACT_EM_PK", x => x.CONTACT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONTACT_EM",
                schema: "OT");
        }
    }
}
