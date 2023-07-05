using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class inventoryitemlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commodities_Consumers_ConsumerId",
                table: "Commodities");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodities_Suppliers_SupplierId",
                table: "Commodities");

            migrationBuilder.DropIndex(
                name: "IX_Commodities_ConsumerId",
                table: "Commodities");

            migrationBuilder.DropIndex(
                name: "IX_Commodities_SupplierId",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Commodities");

            migrationBuilder.CreateTable(
                name: "CommodityConsumer",
                columns: table => new
                {
                    CommoditiesCommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumersConsumerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityConsumer", x => new { x.CommoditiesCommodityId, x.ConsumersConsumerId });
                    table.ForeignKey(
                        name: "FK_CommodityConsumer_Commodities_CommoditiesCommodityId",
                        column: x => x.CommoditiesCommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommodityConsumer_Consumers_ConsumersConsumerId",
                        column: x => x.ConsumersConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "ConsumerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommoditySupplier",
                columns: table => new
                {
                    CommoditiesCommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuppliersSupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommoditySupplier", x => new { x.CommoditiesCommodityId, x.SuppliersSupplierId });
                    table.ForeignKey(
                        name: "FK_CommoditySupplier_Commodities_CommoditiesCommodityId",
                        column: x => x.CommoditiesCommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommoditySupplier_Suppliers_SuppliersSupplierId",
                        column: x => x.SuppliersSupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItemLists",
                columns: table => new
                {
                    InventoryItemListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItemLists", x => x.InventoryItemListId);
                    table.ForeignKey(
                        name: "FK_InventoryItemLists_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryItemLists_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommodityConsumer_ConsumersConsumerId",
                table: "CommodityConsumer",
                column: "ConsumersConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_CommoditySupplier_SuppliersSupplierId",
                table: "CommoditySupplier",
                column: "SuppliersSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItemLists_CommodityId",
                table: "InventoryItemLists",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItemLists_InventoryId",
                table: "InventoryItemLists",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommodityConsumer");

            migrationBuilder.DropTable(
                name: "CommoditySupplier");

            migrationBuilder.DropTable(
                name: "InventoryItemLists");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsumerId",
                table: "Commodities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierId",
                table: "Commodities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_ConsumerId",
                table: "Commodities",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_SupplierId",
                table: "Commodities",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodities_Consumers_ConsumerId",
                table: "Commodities",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "ConsumerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodities_Suppliers_SupplierId",
                table: "Commodities",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
