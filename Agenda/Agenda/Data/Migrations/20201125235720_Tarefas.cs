using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMvcBasica.Data.Migrations
{
    public partial class Tarefas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 200, nullable: false),
                    HoraInicio = table.Column<TimeSpan>(nullable: false),
                    HoraFim = table.Column<TimeSpan>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
