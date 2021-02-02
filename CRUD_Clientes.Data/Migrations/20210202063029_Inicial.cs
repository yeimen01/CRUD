using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Clientes.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IntIdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrNombre = table.Column<string>(maxLength: 50, nullable: true),
                    StrApellido = table.Column<string>(maxLength: 50, nullable: true),
                    DtFechaNacimineto = table.Column<DateTime>(nullable: false),
                    ESexo = table.Column<int>(nullable: false),
                    StrDirección = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IntIdCliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
