using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "operadorItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoOperador = table.Column<int>(nullable: false),
                    Placa = table.Column<string>(nullable: false),
                    Tid = table.Column<string>(nullable: true),
                    Epc = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    EstadoSaldo = table.Column<int>(nullable: false),
                    Saldo = table.Column<int>(nullable: false),
                    SaldoBajo = table.Column<int>(nullable: false),
                    NumeroCliente = table.Column<int>(nullable: false),
                    Modalidad = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operadorItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "operadorItems");
        }
    }
}
