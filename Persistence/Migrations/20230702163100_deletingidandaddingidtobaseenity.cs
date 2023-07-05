using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deletingidandaddingidtobaseenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommodityConsumer_Commodities_CommoditiesCommodityId",
                table: "CommodityConsumer");

            migrationBuilder.DropForeignKey(
                name: "FK_CommodityConsumer_Consumers_ConsumersConsumerId",
                table: "CommodityConsumer");

            migrationBuilder.DropForeignKey(
                name: "FK_CommoditySupplier_Commodities_CommoditiesCommodityId",
                table: "CommoditySupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_CommoditySupplier_Suppliers_SuppliersSupplierId",
                table: "CommoditySupplier");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "Warehouses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnitMeasureId",
                table: "UnitMeasures",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Suppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RequisitionItemListId",
                table: "RequisitionItemList",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReceiptItemListId",
                table: "ReceiptItemList",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MadeInCountryId",
                table: "MadeInCountries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryTurnoverId",
                table: "InventoryTurnovers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryRequisitionId",
                table: "InventoryRequisitions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryReceiptId",
                table: "InventoryReceipts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryItemListId",
                table: "InventoryItemLists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryId",
                table: "Inventories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ConsumerId",
                table: "Consumers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SuppliersSupplierId",
                table: "CommoditySupplier",
                newName: "SuppliersId");

            migrationBuilder.RenameColumn(
                name: "CommoditiesCommodityId",
                table: "CommoditySupplier",
                newName: "CommoditiesId");

            migrationBuilder.RenameIndex(
                name: "IX_CommoditySupplier_SuppliersSupplierId",
                table: "CommoditySupplier",
                newName: "IX_CommoditySupplier_SuppliersId");

            migrationBuilder.RenameColumn(
                name: "ConsumersConsumerId",
                table: "CommodityConsumer",
                newName: "ConsumersId");

            migrationBuilder.RenameColumn(
                name: "CommoditiesCommodityId",
                table: "CommodityConsumer",
                newName: "CommoditiesId");

            migrationBuilder.RenameIndex(
                name: "IX_CommodityConsumer_ConsumersConsumerId",
                table: "CommodityConsumer",
                newName: "IX_CommodityConsumer_ConsumersId");

            migrationBuilder.RenameColumn(
                name: "CommodityId",
                table: "Commodities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BuyRequestId",
                table: "BuyRequests",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BuyRequestItemListId",
                table: "BuyRequestItemLists",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityConsumer_Commodities_CommoditiesId",
                table: "CommodityConsumer",
                column: "CommoditiesId",
                principalTable: "Commodities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityConsumer_Consumers_ConsumersId",
                table: "CommodityConsumer",
                column: "ConsumersId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommoditySupplier_Commodities_CommoditiesId",
                table: "CommoditySupplier",
                column: "CommoditiesId",
                principalTable: "Commodities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommoditySupplier_Suppliers_SuppliersId",
                table: "CommoditySupplier",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommodityConsumer_Commodities_CommoditiesId",
                table: "CommodityConsumer");

            migrationBuilder.DropForeignKey(
                name: "FK_CommodityConsumer_Consumers_ConsumersId",
                table: "CommodityConsumer");

            migrationBuilder.DropForeignKey(
                name: "FK_CommoditySupplier_Commodities_CommoditiesId",
                table: "CommoditySupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_CommoditySupplier_Suppliers_SuppliersId",
                table: "CommoditySupplier");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Warehouses",
                newName: "WarehouseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UnitMeasures",
                newName: "UnitMeasureId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RequisitionItemList",
                newName: "RequisitionItemListId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReceiptItemList",
                newName: "ReceiptItemListId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MadeInCountries",
                newName: "MadeInCountryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InventoryTurnovers",
                newName: "InventoryTurnoverId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InventoryRequisitions",
                newName: "InventoryRequisitionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InventoryReceipts",
                newName: "InventoryReceiptId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InventoryItemLists",
                newName: "InventoryItemListId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventories",
                newName: "InventoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumers",
                newName: "ConsumerId");

            migrationBuilder.RenameColumn(
                name: "SuppliersId",
                table: "CommoditySupplier",
                newName: "SuppliersSupplierId");

            migrationBuilder.RenameColumn(
                name: "CommoditiesId",
                table: "CommoditySupplier",
                newName: "CommoditiesCommodityId");

            migrationBuilder.RenameIndex(
                name: "IX_CommoditySupplier_SuppliersId",
                table: "CommoditySupplier",
                newName: "IX_CommoditySupplier_SuppliersSupplierId");

            migrationBuilder.RenameColumn(
                name: "ConsumersId",
                table: "CommodityConsumer",
                newName: "ConsumersConsumerId");

            migrationBuilder.RenameColumn(
                name: "CommoditiesId",
                table: "CommodityConsumer",
                newName: "CommoditiesCommodityId");

            migrationBuilder.RenameIndex(
                name: "IX_CommodityConsumer_ConsumersId",
                table: "CommodityConsumer",
                newName: "IX_CommodityConsumer_ConsumersConsumerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Commodities",
                newName: "CommodityId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuyRequests",
                newName: "BuyRequestId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuyRequestItemLists",
                newName: "BuyRequestItemListId");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityConsumer_Commodities_CommoditiesCommodityId",
                table: "CommodityConsumer",
                column: "CommoditiesCommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityConsumer_Consumers_ConsumersConsumerId",
                table: "CommodityConsumer",
                column: "ConsumersConsumerId",
                principalTable: "Consumers",
                principalColumn: "ConsumerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommoditySupplier_Commodities_CommoditiesCommodityId",
                table: "CommoditySupplier",
                column: "CommoditiesCommodityId",
                principalTable: "Commodities",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommoditySupplier_Suppliers_SuppliersSupplierId",
                table: "CommoditySupplier",
                column: "SuppliersSupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
