using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogLab.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthId",
                table: "news",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "news",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_news_AuthId",
                table: "news",
                column: "AuthId");

            migrationBuilder.CreateIndex(
                name: "IX_news_CatId",
                table: "news",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_news_Authors_AuthId",
                table: "news",
                column: "AuthId",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_news_Catalogs_CatId",
                table: "news",
                column: "CatId",
                principalTable: "Catalogs",
                principalColumn: "Catalog_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_Authors_AuthId",
                table: "news");

            migrationBuilder.DropForeignKey(
                name: "FK_news_Catalogs_CatId",
                table: "news");

            migrationBuilder.DropIndex(
                name: "IX_news_AuthId",
                table: "news");

            migrationBuilder.DropIndex(
                name: "IX_news_CatId",
                table: "news");

            migrationBuilder.DropColumn(
                name: "AuthId",
                table: "news");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "news");
        }
    }
}
