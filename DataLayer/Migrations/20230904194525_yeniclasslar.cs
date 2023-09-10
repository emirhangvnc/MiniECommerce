using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class yeniclasslar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productAndImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productAndImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productAndImages_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "specificationValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specificationValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_specificationValues_specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productAndSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SpecificationValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productAndSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productAndSpecifications_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productAndSpecifications_specificationValues_SpecificationValueId",
                        column: x => x.SpecificationValueId,
                        principalTable: "specificationValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productAndImages_ProductId",
                table: "productAndImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productAndSpecifications_ProductId",
                table: "productAndSpecifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productAndSpecifications_SpecificationValueId",
                table: "productAndSpecifications",
                column: "SpecificationValueId");

            migrationBuilder.CreateIndex(
                name: "IX_specificationValues_SpecificationId",
                table: "specificationValues",
                column: "SpecificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productAndImages");

            migrationBuilder.DropTable(
                name: "productAndSpecifications");

            migrationBuilder.DropTable(
                name: "specificationValues");

            migrationBuilder.DropTable(
                name: "specifications");
        }
    }
}
