using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class somanychanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsideTransfers_Commodities_CommodityId",
                table: "InsideTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Commodities_CommodityId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryReceipts_Commodities_CommodityId",
                table: "InventoryReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryReceipts_Suppliers_SupplierId",
                table: "InventoryReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryRequisitions_Commodities_CommodityId",
                table: "InventoryRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryRequisitions_Consumers_ConsumerID",
                table: "InventoryRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_InventoryRequisitions_CommodityId",
                table: "InventoryRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_InventoryRequisitions_ConsumerID",
                table: "InventoryRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_InventoryReceipts_CommodityId",
                table: "InventoryReceipts");

            migrationBuilder.DropIndex(
                name: "IX_InventoryReceipts_SupplierId",
                table: "InventoryReceipts");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_CommodityId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_InsideTransfers_CommodityId",
                table: "InsideTransfers");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "ConsumerID",
                table: "InventoryRequisitions");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "InventoryReceipts");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "InsideTransfers");

            migrationBuilder.AddColumn<Guid>(
                name: "InventoryReceiptId",
                table: "Suppliers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InventoryRequisitionId",
                table: "Consumers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BuyRequests",
                columns: table => new
                {
                    BuyRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyRequests", x => x.BuyRequestId);
                    table.ForeignKey(
                        name: "FK_BuyRequests_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerInvoices",
                columns: table => new
                {
                    ConsumerInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequisitiontDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "supplierInvoices",
                columns: table => new
                {
                    SupplierInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "buyRequestItemLists",
                columns: table => new
                {
                    BuyRequestItemListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buyRequestItemLists", x => x.BuyRequestItemListId);
                    table.ForeignKey(
                        name: "FK_buyRequestItemLists_BuyRequests_BuyRequestId",
                        column: x => x.BuyRequestId,
                        principalTable: "BuyRequests",
                        principalColumn: "BuyRequestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_buyRequestItemLists_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequisitionItemList",
                columns: table => new
                {
                    RequisitionItemListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryRequisitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumerInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitionItemList", x => x.RequisitionItemListId);
                    table.ForeignKey(
                        name: "FK_RequisitionItemList_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequisitionItemList_ConsumerInvoices_ConsumerInvoiceId",
                        column: x => x.ConsumerInvoiceId,
                        principalTable: "ConsumerInvoices",
                        principalColumn: "ConsumerInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequisitionItemList_InventoryRequisitions_InventoryRequisitionId",
                        column: x => x.InventoryRequisitionId,
                        principalTable: "InventoryRequisitions",
                        principalColumn: "InventoryRequisitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItemList",
                columns: table => new
                {
                    ReceiptItemListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierInvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItemList", x => x.ReceiptItemListId);
                    table.ForeignKey(
                        name: "FK_ReceiptItemList_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptItemList_InventoryReceipts_InventoryReceiptId",
                        column: x => x.InventoryReceiptId,
                        principalTable: "InventoryReceipts",
                        principalColumn: "InventoryReceiptId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptItemList_supplierInvoices_SupplierInvoiceId",
                        column: x => x.SupplierInvoiceId,
                        principalTable: "supplierInvoices",
                        principalColumn: "SupplierInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_InventoryReceiptId",
                table: "Suppliers",
                column: "InventoryReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_InventoryRequisitionId",
                table: "Consumers",
                column: "InventoryRequisitionId");

            migrationBuilder.CreateIndex(
                name: "IX_buyRequestItemLists_BuyRequestId",
                table: "buyRequestItemLists",
                column: "BuyRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_buyRequestItemLists_CommodityId",
                table: "buyRequestItemLists",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyRequests_InventoryId",
                table: "BuyRequests",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerInvoices_WarehouseId",
                table: "ConsumerInvoices",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_insideTransferItemLists_InsideTransferId",
                table: "insideTransferItemLists",
                column: "InsideTransferId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemList_CommodityId",
                table: "ReceiptItemList",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemList_InventoryReceiptId",
                table: "ReceiptItemList",
                column: "InventoryReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemList_SupplierInvoiceId",
                table: "ReceiptItemList",
                column: "SupplierInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionItemList_CommodityId",
                table: "RequisitionItemList",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionItemList_ConsumerInvoiceId",
                table: "RequisitionItemList",
                column: "ConsumerInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionItemList_InventoryRequisitionId",
                table: "RequisitionItemList",
                column: "InventoryRequisitionId");

            migrationBuilder.CreateIndex(
                name: "IX_supplierInvoices_WarehouseId",
                table: "supplierInvoices",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_InventoryRequisitions_InventoryRequisitionId",
                table: "Consumers",
                column: "InventoryRequisitionId",
                principalTable: "InventoryRequisitions",
                principalColumn: "InventoryRequisitionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_InventoryReceipts_InventoryReceiptId",
                table: "Suppliers",
                column: "InventoryReceiptId",
                principalTable: "InventoryReceipts",
                principalColumn: "InventoryReceiptId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_InventoryRequisitions_InventoryRequisitionId",
                table: "Consumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_InventoryReceipts_InventoryReceiptId",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "buyRequestItemLists");

            migrationBuilder.DropTable(
                name: "insideTransferItemLists");

            migrationBuilder.DropTable(
                name: "ReceiptItemList");

            migrationBuilder.DropTable(
                name: "RequisitionItemList");

            migrationBuilder.DropTable(
                name: "BuyRequests");

            migrationBuilder.DropTable(
                name: "supplierInvoices");

            migrationBuilder.DropTable(
                name: "ConsumerInvoices");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_InventoryReceiptId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_InventoryRequisitionId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "InventoryReceiptId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "InventoryRequisitionId",
                table: "Consumers");

            migrationBuilder.AddColumn<Guid>(
                name: "CommodityId",
                table: "InventoryRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ConsumerID",
                table: "InventoryRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CommodityId",
                table: "InventoryReceipts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierId",
                table: "InventoryReceipts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CommodityId",
                table: "Inventories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CommodityId",
                table: "InsideTransfers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequisitions_CommodityId",
                table: "InventoryRequisitions",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequisitions_ConsumerID",
                table: "InventoryRequisitions",
                column: "ConsumerID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReceipts_CommodityId",
                table: "InventoryReceipts",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReceipts_SupplierId",
                table: "InventoryReceipts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_CommodityId",
                table: "Inventories",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_CommodityId",
                table: "InsideTransfers",
                column: "CommodityId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsideTransfers_Commodities_CommodityId",
                table: "InsideTransfers",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Commodities_CommodityId",
                table: "Inventories",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryReceipts_Commodities_CommodityId",
                table: "InventoryReceipts",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryReceipts_Suppliers_SupplierId",
                table: "InventoryReceipts",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryRequisitions_Commodities_CommodityId",
                table: "InventoryRequisitions",
                column: "CommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryRequisitions_Consumers_ConsumerID",
                table: "InventoryRequisitions",
                column: "ConsumerID",
                principalTable: "Consumers",
                principalColumn: "ConsumerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
