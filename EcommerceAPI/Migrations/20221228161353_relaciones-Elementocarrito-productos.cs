using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class relacionesElementocarritoproductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Carritos");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_ProductoId",
                table: "Carritos",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Productos_ProductoId",
                table: "Carritos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Productos_ProductoId",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_ProductoId",
                table: "Carritos");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
