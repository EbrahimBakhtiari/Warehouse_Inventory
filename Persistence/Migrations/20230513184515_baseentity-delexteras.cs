using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class baseentitydelexteras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptItemList_supplierInvoices_SupplierInvoiceId",
                table: "ReceiptItemList");

            migrationBuilder.DropForeignKey(
                name: "FK_RequisitionItemList_ConsumerInvoices_ConsumerInvoiceId",
                table: "RequisitionItemList");

            migrationBuilder.DropTable(
                name: "ConsumerInvoices");

            migrationBuilder.DropTable(
                name: "insideTransferItemLists");

            migrationBuilder.DropTable(
                name: "supplierInvoices");

            migrationBuilder.DropTable(
                name: "InsideTransfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_RequisitionItemList_ConsumerInvoiceId",
                table: "RequisitionItemList");

            migrationBuilder.DropIndex(
                name: "IX_ReceiptItemList_SupplierInvoiceId",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "ConsumerInvoiceId",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "SupplierInvoiceId",
                table: "ReceiptItemList");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Warehouses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Warehouses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UnitMeasures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UnitMeasures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "UnitMeasures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RequisitionItemList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RequisitionItemList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "RequisitionItemList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ReceiptItemList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ReceiptItemList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "ReceiptItemList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MadeInCountries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MadeInCountries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "MadeInCountries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InventoryTurnovers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InventoryTurnovers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "InventoryTurnovers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InventoryRequisitions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InventoryRequisitions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "InventoryRequisitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InventoryReceipts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InventoryReceipts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "InventoryReceipts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InventoryItemLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InventoryItemLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "InventoryItemLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Inventories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Inventories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Consumers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Consumers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Commodities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Commodities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Commodities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BuyRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BuyRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "BuyRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "buyRequestItemLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "buyRequestItemLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "buyRequestItemLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "UnitMeasures");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "RequisitionItemList");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "ReceiptItemList");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "MadeInCountries");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "InventoryItemLists");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "BuyRequests");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "buyRequestItemLists");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "buyRequestItemLists");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "buyRequestItemLists");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsumerInvoiceId",
                table: "RequisitionItemList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierInvoiceId",
                table: "ReceiptItemList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "ConsumerInvoices",
                columns: table => new
                {
                    ConsumerInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequisitiontDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerInvoices", x => x.ConsumerInvoiceId);
                    table.ForeignKey(
                        name: "FK_ConsumerInvoices_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InsideTransfers",
                columns: table => new
                {
                    InsideTransferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsideTransfers", x => x.InsideTransferId);
                    table.ForeignKey(
                        name: "FK_InsideTransfers_Inventories_DestinationInventoryId",
                        column: x => x.DestinationInventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsideTransfers_Inventories_SourceInventoryId",
                        column: x => x.SourceInventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "supplierInvoices",
                columns: table => new
                {
                    SupplierInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplierInvoices", x => x.SupplierInvoiceId);
                    table.ForeignKey(
                        name: "FK_supplierInvoices_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "insideTransferItemLists",
                columns: table => new
                {
                    InsideTransferItemListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsideTransferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insideTransferItemLists", x => x.InsideTransferItemListId);
                    table.ForeignKey(
                        name: "FK_insideTransferItemLists_InsideTransfers_InsideTransferId",
                        column: x => x.InsideTransferId,
                        principalTable: "InsideTransfers",
                        principalColumn: "InsideTransferId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionItemList_ConsumerInvoiceId",
                table: "RequisitionItemList",
                column: "ConsumerInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemList_SupplierInvoiceId",
                table: "ReceiptItemList",
                column: "SupplierInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerInvoices_WarehouseId",
                table: "ConsumerInvoices",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_insideTransferItemLists_InsideTransferId",
                table: "insideTransferItemLists",
                column: "InsideTransferId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_DestinationInventoryId",
                table: "InsideTransfers",
                column: "DestinationInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_SourceInventoryId",
                table: "InsideTransfers",
                column: "SourceInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_supplierInvoices_WarehouseId",
                table: "supplierInvoices",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptItemList_supplierInvoices_SupplierInvoiceId",
                table: "ReceiptItemList",
                column: "SupplierInvoiceId",
                principalTable: "supplierInvoices",
                principalColumn: "SupplierInvoiceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequisitionItemList_ConsumerInvoices_ConsumerInvoiceId",
                table: "RequisitionItemList",
                column: "ConsumerInvoiceId",
                principalTable: "ConsumerInvoices",
                principalColumn: "ConsumerInvoiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
