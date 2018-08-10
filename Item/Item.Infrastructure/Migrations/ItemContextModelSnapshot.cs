﻿// <auto-generated />
using System;
using Item.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Item.Infrastructure.Migrations
{
    [DbContext(typeof(ItemContext))]
    partial class ItemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Item.Domain.AggregatesModel.ItemAggregate.ItemMaster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Decription");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("ShortName")
                        .HasMaxLength(16);

                    b.Property<int?>("TypeId")
                        .IsRequired();

                    b.Property<Guid?>("UnitMeasureId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("UnitMeasureId");

                    b.ToTable("ItemMaster");
                });

            modelBuilder.Entity("Item.Domain.AggregatesModel.ItemAggregate.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Item.Domain.AggregatesModel.ItemAggregate.UnitMeasure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Decription");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("UnitMeasure");
                });

            modelBuilder.Entity("Item.Domain.AggregatesModel.ItemAggregate.ItemMaster", b =>
                {
                    b.HasOne("Item.Domain.AggregatesModel.ItemAggregate.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Item.Domain.AggregatesModel.ItemAggregate.UnitMeasure", "UnitMeasure")
                        .WithMany()
                        .HasForeignKey("UnitMeasureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
