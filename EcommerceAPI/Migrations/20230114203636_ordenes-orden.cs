using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class ordenesorden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalle_Productos_ProductoId",
                table: "OrdenDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalle_Usuarios_UsuarioId",
                table: "OrdenDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenDetalle",
                table: "OrdenDetalle");

            migrationBuilder.RenameTable(
                name: "OrdenDetalle",
                newName: "OrdenDetalles");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalle_UsuarioId",
                table: "OrdenDetalles",
                newName: "IX_OrdenDetalles_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalle_ProductoId",
                table: "OrdenDetalles",
                newName: "IX_OrdenDetalles_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenDetalles",
                table: "OrdenDetalles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalles_Productos_ProductoId",
                table: "OrdenDetalles",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalles_Usuarios_UsuarioId",
                table: "OrdenDetalles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Ordenes_OrdenId",
                table: "OrdenDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Productos_ProductoId",
                table: "OrdenDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Usuarios_UsuarioId",
                table: "OrdenDetalles");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenDetalles",
                table: "OrdenDetalles");

            migrationBuilder.DropIndex(
                name: "IX_OrdenDetalles_OrdenId",
                table: "OrdenDetalles");

            migrationBuilder.RenameTable(
                name: "OrdenDetalles",
                newName: "OrdenDetalle");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalles_UsuarioId",
                table: "OrdenDetalle",
                newName: "IX_OrdenDetalle_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalles_ProductoId",
                table: "OrdenDetalle",
                newName: "IX_OrdenDetalle_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenDetalle",
                table: "OrdenDetalle",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalle_Productos_ProductoId",
                table: "OrdenDetalle",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalle_Usuarios_UsuarioId",
                table: "OrdenDetalle",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
