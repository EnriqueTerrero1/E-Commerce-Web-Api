using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class Ordenes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Ordenes_OrdenId",
                table: "OrdenDetalles");

            migrationBuilder.DropIndex(
                name: "IX_OrdenDetalles_OrdenId",
                table: "OrdenDetalles");

            migrationBuilder.AddColumn<int>(
                name: "OrdenId",
                table: "Carritos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_OrdenId",
                table: "Carritos",
                column: "OrdenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Ordenes_OrdenId",
                table: "Carritos",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Ordenes_OrdenId",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_OrdenId",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "OrdenId",
                table: "Carritos");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalles_OrdenId",
                table: "OrdenDetalles",
                column: "OrdenId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalles_Ordenes_OrdenId",
                table: "OrdenDetalles",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
