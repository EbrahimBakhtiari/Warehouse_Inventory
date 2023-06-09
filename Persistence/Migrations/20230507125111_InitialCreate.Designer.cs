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
    [Migration("20230507125111_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
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

                    b.Property<Guid?>("ConsumerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MadeInCountryCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitMeasureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommodityId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ConsumerId");

                    b.HasIndex("MadeInCountryCountryId");

                    b.HasIndex("SupplierId");

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

                    b.HasKey("ConsumerId");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("Domain.Entities.InsideTransfer", b =>
                {
                    b.Property<Guid>("InsideTransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinationInventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SourceInventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InsideTransferId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("DestinationInventoryId");

                    b.HasIndex("SourceInventoryId");

                    b.ToTable("InsideTransfers");
                });

            modelBuilder.Entity("Domain.Entities.Inventory", b =>
                {
                    b.Property<Guid>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InventoryId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Domain.Entities.InventoryReceipt", b =>
                {
                    b.Property<Guid>("InventoryReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryReceiptId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("InventoryReceipts");
                });

            modelBuilder.Entity("Domain.Entities.InventoryRequisition", b =>
                {
                    b.Property<Guid>("InventoryRequisitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommodityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConsumerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RequisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryRequisitionId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("ConsumerID");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryRequisitions");
                });

            modelBuilder.Entity("Domain.Entities.InventoryTurnover", b =>
                {
                    b.Property<Guid>("InventoryTurnoverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasKey("InventoryTurnoverId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryTurnovers");
                });

            modelBuilder.Entity("Domain.Entities.MadeInCountry", b =>
                {
                    b.Property<Guid>("MadeInCountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MadeInCountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MadeInCountryId");

                    b.ToTable("MadeInCountries");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Property<Guid>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Domain.Entities.UnitMeasure", b =>
                {
                    b.Property<Guid>("UnitMeasureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UnitMeasureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitMeasureId");

                    b.ToTable("UnitMeasures");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Property<Guid>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WarehouseLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Domain.Entities.Commodity", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Commodities")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Consumer", null)
                        .WithMany("Commodities")
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.MadeInCountry", "MadeInCountry")
                        .WithMany("Commodities")
                        .HasForeignKey("MadeInCountryCountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Supplier", "Supplier")
                        .WithMany("Commodities")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UnitMeasure", "UnitMeasure")
                        .WithMany("Commodities")
                        .HasForeignKey("UnitMeasureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("MadeInCountry");

                    b.Navigation("Supplier");

                    b.Navigation("UnitMeasure");
                });

            modelBuilder.Entity("Domain.Entities.InsideTransfer", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Inventory", "DestinationInventory")
                        .WithMany()
                        .HasForeignKey("DestinationInventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Inventory", "SourceInventory")
                        .WithMany()
                        .HasForeignKey("SourceInventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("DestinationInventory");

                    b.Navigation("SourceInventory");
                });

            modelBuilder.Entity("Domain.Entities.Inventory", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Inventories")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Domain.Entities.InventoryReceipt", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("Inventory");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Domain.Entities.InventoryRequisition", b =>
                {
                    b.HasOne("Domain.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Consumer", "Consumer")
                        .WithMany()
                        .HasForeignKey("ConsumerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commodity");

                    b.Navigation("Consumer");

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

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.Consumer", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.MadeInCountry", b =>
                {
                    b.Navigation("Commodities");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
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
