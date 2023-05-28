﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XProject.Infra.Data;

#nullable disable

namespace XProject.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230528131618_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XProject.Domain.Entitities.AppPage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValue("");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Views");

                    b.HasData(
                        new
                        {
                            Id = "732b776f-44f2-4124-b89a-f9917ae6cbd7",
                            IsVisible = true,
                            Name = "Home"
                        },
                        new
                        {
                            Id = "7b7055f1-600e-4ced-8ab7-51a08cf34407",
                            IsVisible = true,
                            Name = "Privacy"
                        },
                        new
                        {
                            Id = "68d362ad-2775-43ca-ba29-e41512aa45e3",
                            IsVisible = true,
                            Name = "RandomPage"
                        },
                        new
                        {
                            Id = "741eb342-f4da-46d7-ae0d-092ab7b9fda6",
                            IsVisible = true,
                            Name = "PageManagement"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
