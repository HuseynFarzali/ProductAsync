using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationExample.Migrations
{
    public partial class ProductProductSizeProductColorProductItemv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem");

            migrationBuilder.DropColumn(
                name: "ProductColorId",
                table: "ProductItem");

            migrationBuilder.DropColumn(
                name: "ProductSizeId",
                table: "ProductItem");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "ProductItem",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "ProductItem",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "ProductItem",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "ProductItem",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ProductColorId",
                table: "ProductItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductSizeId",
                table: "ProductItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Colors_ColorId",
                table: "ProductItem",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Sizes_SizeId",
                table: "ProductItem",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
