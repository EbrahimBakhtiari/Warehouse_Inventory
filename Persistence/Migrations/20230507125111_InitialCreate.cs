using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    ConsumerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.ConsumerId);
                });

            migrationBuilder.CreateTable(
                name: "MadeInCountries",
                columns: table => new
                {
                    MadeInCountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeInCountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MadeInCountries", x => x.MadeInCountryId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeasures",
                columns: table => new
                {
                    UnitMeasureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitMeasureName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasures", x => x.UnitMeasureId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeInCountryCountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitMeasureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.CommodityId);
                    table.ForeignKey(
                        name: "FK_Commodities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commodities_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "ConsumerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commodities_MadeInCountries_MadeInCountryCountryId",
                        column: x => x.MadeInCountryCountryId,
                        principalTable: "MadeInCountries",
                        principalColumn: "MadeInCountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commodities_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commodities_UnitMeasures_UnitMeasureId",
                        column: x => x.UnitMeasureId,
                        principalTable: "UnitMeasures",
                        principalColumn: "UnitMeasureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_Inventories_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Warehouses_WarehouseId",
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
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsideTransfers", x => x.InsideTransferId);
                    table.ForeignKey(
                        name: "FK_InsideTransfers_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "InventoryReceipts",
                columns: table => new
                {
                    InventoryReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryReceipts", x => x.InventoryReceiptId);
                    table.ForeignKey(
                        name: "FK_InventoryReceipts_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReceipts_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReceipts_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryRequisitions",
                columns: table => new
                {
                    InventoryRequisitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    RequisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryRequisitions", x => x.InventoryRequisitionId);
                    table.ForeignKey(
                        name: "FK_InventoryRequisitions_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryRequisitions_Consumers_ConsumerID",
                        column: x => x.ConsumerID,
                        principalTable: "Consumers",
                        principalColumn: "ConsumerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryRequisitions_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTurnovers",
                columns: table => new
                {
                    InventoryTurnoverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantitySold = table.Column<int>(type: "int", nullable: false),
                    TotalQuantityPurchased = table.Column<int>(type: "int", nullable: false),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TurnoverRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTurnovers", x => x.InventoryTurnoverId);
                    table.ForeignKey(
                        name: "FK_InventoryTurnovers_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_CategoryId",
                table: "Commodities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_ConsumerId",
                table: "Commodities",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_MadeInCountryCountryId",
                table: "Commodities",
                column: "MadeInCountryCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_SupplierId",
                table: "Commodities",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_UnitMeasureId",
                table: "Commodities",
                column: "UnitMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_CommodityId",
                table: "InsideTransfers",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_DestinationInventoryId",
                table: "InsideTransfers",
                column: "DestinationInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InsideTransfers_SourceInventoryId",
                table: "InsideTransfers",
                column: "SourceInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_CommodityId",
                table: "Inventories",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventories",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReceipts_CommodityId",
                table: "InventoryReceipts",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReceipts_InventoryId",
                table: "InventoryReceipts",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReceipts_SupplierId",
                table: "InventoryReceipts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequisitions_CommodityId",
                table: "InventoryRequisitions",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequisitions_ConsumerID",
                table: "InventoryRequisitions",
                column: "ConsumerID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequisitions_InventoryId",
                table: "InventoryRequisitions",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTurnovers_InventoryId",
                table: "InventoryTurnovers",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsideTransfers");

            migrationBuilder.DropTable(
                name: "InventoryReceipts");

            migrationBuilder.DropTable(
                name: "InventoryRequisitions");

            migrationBuilder.DropTable(
                name: "InventoryTurnovers");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "MadeInCountries");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "UnitMeasures");
        }
    }
}
