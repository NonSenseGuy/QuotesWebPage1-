using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quotes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LoginError = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Petition = table.Column<string>(nullable: true),
                    EventType = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    EventDate = table.Column<string>(nullable: true),
                    NAssistants = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    phone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCustomer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LoginError = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCustomer", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "UserCustomer");
        }
    }
}
