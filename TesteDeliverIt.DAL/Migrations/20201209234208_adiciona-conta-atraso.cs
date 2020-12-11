using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteDeliverIT.DAL.Migrations
{
    public partial class adicionacontaatraso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaAtraso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DiaMinimoAtraso = table.Column<int>(type: "integer", nullable: false),
                    PorcentagemMulta = table.Column<decimal>(type: "numeric", nullable: false),
                    JurosPorDia = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaAtraso", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaAtraso");
        }
    }
}
