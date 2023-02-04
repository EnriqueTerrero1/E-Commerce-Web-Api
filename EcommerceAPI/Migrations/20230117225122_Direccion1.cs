using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class Direccion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Direcciones_direccionId1",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_direccionId1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "direccionId1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Direcciones");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_direccionId",
                table: "Usuarios",
                column: "direccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Direcciones_direccionId",
                table: "Usuarios",
                column: "direccionId",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Direcciones_direccionId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_direccionId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "direccionId1",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Direcciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_direccionId1",
                table: "Usuarios",
                column: "direccionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Direcciones_direccionId1",
                table: "Usuarios",
                column: "direccionId1",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
