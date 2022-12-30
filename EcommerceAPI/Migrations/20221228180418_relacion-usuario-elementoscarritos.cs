using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class relacionusuarioelementoscarritos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_UsuarioId",
                table: "Carritos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Usuarios_UsuarioId",
                table: "Carritos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Usuarios_UsuarioId",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_UsuarioId",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Carritos");
        }
    }
}
