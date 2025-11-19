using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_proyecto_sena.Migrations
{
    /// <inheritdoc />
    public partial class Miration_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Usuario_Salt",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario_Salt",
                table: "Usuarios");
        }
    }
}
