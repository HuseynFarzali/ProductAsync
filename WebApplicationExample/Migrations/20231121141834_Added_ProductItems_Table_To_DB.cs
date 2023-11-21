using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationExample.Migrations
{
    public partial class Added_ProductItems_Table_To_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Products_ProductId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem");

            migrationBuilder.RenameTable(
                name: "ProductItem",
                newName: "ProductItems");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_SizeId",
                table: "ProductItems",
                newName: "IX_ProductItems_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_ProductId",
                table: "ProductItems",
                newName: "IX_ProductItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_ColorId",
                table: "ProductItems",
                newName: "IX_ProductItems_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductItems",
                table: "ProductItems",
                column: "ProductItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Colors_ColorId",
                table: "ProductItems",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Products_ProductId",
                table: "ProductItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Sizes_SizeId",
                table: "ProductItems",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Colors_ColorId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Products_ProductId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Sizes_SizeId",
                table: "ProductItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductItems",
                table: "ProductItems");

            migrationBuilder.RenameTable(
                name: "ProductItems",
                newName: "ProductItem");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_SizeId",
                table: "ProductItem",
                newName: "IX_ProductItem_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItem",
                newName: "IX_ProductItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_ColorId",
                table: "ProductItem",
                newName: "IX_ProductItem_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem",
                column: "ProductItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Products_ProductId",
                table: "ProductItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
