using Microsoft.EntityFrameworkCore.Migrations;

namespace TelegramBot_2020_Righi_Montanari_NetCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professori",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Cognome = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Flag_Feedback = table.Column<bool>(nullable: false),
                    Flag_Ban = table.Column<bool>(nullable: false),
                    Flag_Circolari = table.Column<bool>(nullable: false),
                    Flag_Condizioni = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Cognome = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    Classe = table.Column<string>(nullable: true),
                    Flag_Feedback = table.Column<bool>(nullable: false),
                    Flag_Ban = table.Column<bool>(nullable: false),
                    Flag_Circolari = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professori");

            migrationBuilder.DropTable(
                name: "Studenti");
        }
    }
}
