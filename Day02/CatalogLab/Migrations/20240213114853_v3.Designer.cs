﻿// <auto-generated />
using System;
using CatalogLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatalogLab.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20240213114853_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatalogLab.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CatalogLab.Models.Catalog", b =>
                {
                    b.Property<int>("Catalog_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Catalog_Id"));

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Catalog_Id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("CatalogLab.Models.News", b =>
                {
                    b.Property<int>("News_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("News_Id"));

                    b.Property<int>("AuthId")
                        .HasColumnType("int");

                    b.Property<string>("Bref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly?>("Time")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("News_Id");

                    b.HasIndex("AuthId");

                    b.HasIndex("CatId");

                    b.ToTable("news");
                });

            modelBuilder.Entity("CatalogLab.Models.News", b =>
                {
                    b.HasOne("CatalogLab.Models.Author", "Auth")
                        .WithMany("News")
                        .HasForeignKey("AuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogLab.Models.Catalog", "Cat")
                        .WithMany("news")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auth");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatalogLab.Models.Author", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("CatalogLab.Models.Catalog", b =>
                {
                    b.Navigation("news");
                });
#pragma warning restore 612, 618
        }
    }
}
