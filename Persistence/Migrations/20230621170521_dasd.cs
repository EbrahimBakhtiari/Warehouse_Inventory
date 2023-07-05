using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buyRequestItemLists_BuyRequests_BuyRequestId",
                table: "buyRequestItemLists");

            migrationBuilder.DropForeignKey(
                name: "FK_buyRequestItemLists_Commodities_CommodityId",
                table: "buyRequestItemLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_buyRequestItemLists",
                table: "buyRequestItemLists");

            migrationBuilder.RenameTable(
                name: "buyRequestItemLists",
                newName: "BuyRequestItemLists");

            migrationBuilder.RenameIndex(
                name: "IX_buyRequestItemLists_CommodityId",
                table: "BuyRequestItemLists",
                newName: "IX_BuyRequestItemLists_CommodityId");

            migrationBuilder.RenameIndex(
                name: "IX_buyRequestItemLists_BuyRequestId",
                table: "BuyRequestItemLists",
                newName: "IX_BuyRequestItemLists_BuyRequestId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuyRequestItemLists",
                table: "BuyRequestItemLists",
                column: "BuyRequestItemListId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuyRequestItemLists_BuyRequests_BuyRequestId",
                table: "BuyRequestItemLists",
                column: "BuyRequestId",
                principalTable: "BuyRequests",
                principalColumn: "BuyRequestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuyRequestItemLists_Commodities_CommodityId",
                table: "BuyRequestItemLists",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuyRequestItemLists_BuyRequests_BuyRequestId",
                table: "BuyRequestItemLists");

            migrationBuilder.DropForeignKey(
                name: "FK_BuyRequestItemLists_Commodities_CommodityId",
                table: "BuyRequestItemLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuyRequestItemLists",
                table: "BuyRequestItemLists");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "BuyRequestItemLists",
                newName: "buyRequestItemLists");

            migrationBuilder.RenameIndex(
                name: "IX_BuyRequestItemLists_CommodityId",
                table: "buyRequestItemLists",
                newName: "IX_buyRequestItemLists_CommodityId");

            migrationBuilder.RenameIndex(
                name: "IX_BuyRequestItemLists_BuyRequestId",
                table: "buyRequestItemLists",
                newName: "IX_buyRequestItemLists_BuyRequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_buyRequestItemLists",
                table: "buyRequestItemLists",
                column: "BuyRequestItemListId");

            migrationBuilder.AddForeignKey(
                name: "FK_buyRequestItemLists_BuyRequests_BuyRequestId",
                table: "buyRequestItemLists",
                column: "BuyRequestId",
                principalTable: "BuyRequests",
                principalColumn: "BuyRequestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_buyRequestItemLists_Commodities_CommodityId",
                table: "buyRequestItemLists",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
