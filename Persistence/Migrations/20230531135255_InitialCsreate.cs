using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCsreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Warehouses",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UnitMeasures",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Suppliers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "RequisitionItemList",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "ReceiptItemList",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "MadeInCountries",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "InventoryTurnovers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "InventoryRequisitions",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "InventoryReceipts",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "InventoryItemLists",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Inventories",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Consumers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Commodities",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Categories",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "BuyRequests",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "buyRequestItemLists",
                newName: "ByUsername");

            migrationBuilder.AddColumn<string>(
                name: "ByUsername",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ByUsername",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Warehouses",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "UnitMeasures",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Suppliers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "RequisitionItemList",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "ReceiptItemList",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "MadeInCountries",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryTurnovers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryRequisitions",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryReceipts",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryItemLists",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Inventories",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Consumers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Commodities",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Categories",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "BuyRequests",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "buyRequestItemLists",
                newName: "Username");
        }
    }
}
