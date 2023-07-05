using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BEupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Warehouses",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Users",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "UnitMeasures",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Suppliers",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "RequisitionItemList",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "ReceiptItemList",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "MadeInCountries",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryTurnovers",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryRequisitions",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryReceipts",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "InventoryItemLists",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Inventories",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Consumers",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Commodities",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "Categories",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "BuyRequests",
                newName: "UsernameId");

            migrationBuilder.RenameColumn(
                name: "ByUsername",
                table: "buyRequestItemLists",
                newName: "UsernameId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "UnitMeasures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "UnitMeasures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "UnitMeasures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Suppliers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Suppliers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "RequisitionItemList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "RequisitionItemList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "RequisitionItemList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "ReceiptItemList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "ReceiptItemList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "ReceiptItemList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "MadeInCountries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "MadeInCountries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "MadeInCountries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "InventoryTurnovers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "InventoryTurnovers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "InventoryTurnovers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "InventoryRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "InventoryRequisitions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "InventoryRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "InventoryReceipts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "InventoryReceipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "InventoryReceipts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "InventoryItemLists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "InventoryItemLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "InventoryItemLists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Inventories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Inventories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Consumers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Consumers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Consumers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Commodities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Commodities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Commodities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "BuyRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "BuyRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "BuyRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "buyRequestItemLists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDateTime",
                table: "buyRequestItemLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "buyRequestItemLists",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "buyRequestItemLists");

            migrationBuilder.DropColumn(
                name: "InsertDateTime",
                table: "buyRequestItemLists");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "buyRequestItemLists");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Warehouses",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Users",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "UnitMeasures",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Suppliers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "RequisitionItemList",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "ReceiptItemList",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "MadeInCountries",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "InventoryTurnovers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "InventoryRequisitions",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "InventoryReceipts",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "InventoryItemLists",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Inventories",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Consumers",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Commodities",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "Categories",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "BuyRequests",
                newName: "ByUsername");

            migrationBuilder.RenameColumn(
                name: "UsernameId",
                table: "buyRequestItemLists",
                newName: "ByUsername");
        }
    }
}
