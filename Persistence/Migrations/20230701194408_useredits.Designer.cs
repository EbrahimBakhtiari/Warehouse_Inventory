﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230701194408_useredits")]
    partial class useredits
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CommodityConsumer", b =>
                {
                    b.Property<Guid>("CommoditiesCommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConsumersConsumerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommoditiesCommodityId", "ConsumersConsumerId");

                    b.HasIndex("ConsumersConsumerId");

                    b.ToTable("CommodityConsumer");
                });

            modelBuilder.Entity("CommoditySupplier", b =>
                {
                    b.Property<Guid>("CommoditiesCommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SuppliersSupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommoditiesCommodityId", "SuppliersSupplierId");

                    b.HasIndex("SuppliersSupplierId");

                    b.ToTable("CommoditySupplier");
                });

            modelBuilder.Entity("Domain.Entities.BuyRequest", b =>
                {
                    b.Property<Guid>("BuyRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyRequestId");

                    b.HasIndex("InventoryId");

                    b.ToTable("BuyRequests");
                });

            modelBuilder.Entity("Domain.Entities.BuyRequestItemList", b =>
                {
                    b.Property<Guid>("BuyRequestItemListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuyRequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyRequestItemListId");

                    b.HasIndex("BuyRequestId");

                    b.HasIndex("CommodityId");

                    b.ToTable("BuyRequestItemLists");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.Entities.Commodity", b =>
                {
                    b.Property<Guid>("CommodityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommodityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("MadeInCountryCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitMeasureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommodityId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MadeInCountryCountryId");

                    b.HasIndex("UnitMeasureId");

                    b.ToTable("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.Consumer", b =>
                {
                    b.Property<Guid>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConsumerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsumerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsumerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("InventoryRequisitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsumerId");

                    b.HasIndex("InventoryRequisitionId");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("Domain.Entities.Inventory", b =>
                {
                    b.Property<Guid>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InventoryId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Domain.Entities.InventoryItemList", b =>
                {
                    b.Property<Guid>("InventoryItemListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryItemListId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryItemLists");
                });

            modelBuilder.Entity("Domain.Entities.InventoryReceipt", b =>
                {
                    b.Property<Guid>("InventoryReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryReceiptId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryReceipts");
                });

            modelBuilder.Entity("Domain.Entities.InventoryRequisition", b =>
                {
                    b.Property<Guid>("InventoryRequisitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryRequisitionId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryRequisitions");
                });

            modelBuilder.Entity("Domain.Entities.InventoryTurnover", b =>
                {
                    b.Property<Guid>("InventoryTurnoverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PeriodEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuantityPurchased")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuantitySold")
                        .HasColumnType("int");

                    b.Property<decimal>("TurnoverRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryTurnoverId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryTurnovers");
                });

            modelBuilder.Entity("Domain.Entities.MadeInCountry", b =>
                {
                    b.Property<Guid>("MadeInCountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MadeInCountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MadeInCountryId");

                    b.ToTable("MadeInCountries");
                });

            modelBuilder.Entity("Domain.Entities.ReceiptItemList", b =>
                {
                    b.Property<Guid>("ReceiptItemListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceiptItemListId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("InventoryReceiptId");

                    b.ToTable("ReceiptItemList");
                });

            modelBuilder.Entity("Domain.Entities.RequisitionItemList", b =>
                {
                    b.Property<Guid>("RequisitionItemListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InventoryRequisitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequisitionItemListId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("InventoryRequisitionId");

                    b.ToTable("RequisitionItemList");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Property<Guid>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("InventoryReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.HasIndex("InventoryReceiptId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Domain.Entities.UnitMeasure", b =>
                {
                    b.Property<Guid>("UnitMeasureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UnitMeasureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitMeasureId");

                    b.ToTable("UnitMeasures");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime>("Birthday")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Property<Guid>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsernameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("CommodityConsumer", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", null)
                        .WithMany()
                        .HasForeignKey("CommoditiesCommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Consumer", null)
                        .WithMany()
                        .HasForeignKey("ConsumersConsumerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CommoditySupplier", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", null)
                        .WithMany()
                        .HasForeignKey("CommoditiesCommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersSupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.BuyRequest", b =>
                {
                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Domain.Entities.BuyRequestItemList", b =>
                {
                    b.HasOne("Domain.Entities.BuyRequest", "BuyRequest")
                        .WithMany("RequestedItmes")
                        .HasForeignKey("BuyRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BuyRequest");

                    b.Navigation("Commodity");
                });

            modelBuilder.Entity("Domain.Entities.Commodity", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Commodities")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MadeInCountry", "MadeInCountry")
                        .WithMany("Commodities")
                        .HasForeignKey("MadeInCountryCountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UnitMeasure", "UnitMeasure")
                        .WithMany("Commodities")
                        .HasForeignKey("UnitMeasureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("MadeInCountry");

                    b.Navigation("UnitMeasure");
                });

            modelBuilder.Entity("Domain.Entities.Consumer", b =>
                {
                    b.HasOne("Domain.Entities.InventoryRequisition", null)
                        .WithMany("Consumers")
                        .HasForeignKey("InventoryRequisitionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Inventory", b =>
                {
                    b.HasOne("Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Inventories")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Domain.Entities.InventoryItemList", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany("Items")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Domain.Entities.InventoryReceipt", b =>
                {
                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Domain.Entities.InventoryRequisition", b =>
                {
                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Domain.Entities.InventoryTurnover", b =>
                {
                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Domain.Entities.ReceiptItemList", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.InventoryReceipt", "InventoryReceipt")
                        .WithMany("ReceiptItems")
                        .HasForeignKey("InventoryReceiptId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("InventoryReceipt");
                });

            modelBuilder.Entity("Domain.Entities.RequisitionItemList", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.InventoryRequisition", "InventoryRequisition")
                        .WithMany("RequisitionItems")
                        .HasForeignKey("InventoryRequisitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("InventoryRequisition");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.HasOne("Domain.Entities.InventoryReceipt", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("InventoryReceiptId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.BuyRequest", b =>
                {
                    b.Navigation("RequestedItmes");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.Inventory", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Domain.Entities.InventoryReceipt", b =>
                {
                    b.Navigation("ReceiptItems");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("Domain.Entities.InventoryRequisition", b =>
                {
                    b.Navigation("Consumers");

                    b.Navigation("RequisitionItems");
                });

            modelBuilder.Entity("Domain.Entities.MadeInCountry", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.UnitMeasure", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Inventories");
                });
#pragma warning restore 612, 618
        }
    }
}
