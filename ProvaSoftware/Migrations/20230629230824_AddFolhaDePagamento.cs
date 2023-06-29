using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaSoftware.Migrations
{
    /// <inheritdoc />
    public partial class AddFolhaDePagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testes");

            migrationBuilder.CreateTable(
                name: "FolhaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mes = table.Column<string>(type: "TEXT", nullable: false),
                    Ano = table.Column<int>(type: "INTEGER", nullable: false),
                    Horas = table.Column<int>(type: "INTEGER", nullable: false),
                    Bruto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Inss = table.Column<decimal>(type: "TEXT", nullable: false),
                    Irrf = table.Column<decimal>(type: "TEXT", nullable: false),
                    Fgts = table.Column<decimal>(type: "TEXT", nullable: false),
                    Liquido = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPagamento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FolhaPagamento");

            migrationBuilder.CreateTable(
                name: "Testes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testes", x => x.Id);
                });
        }
    }
}
