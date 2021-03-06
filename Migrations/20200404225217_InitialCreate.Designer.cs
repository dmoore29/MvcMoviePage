﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20200404225217_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("MvcMovie.Models.Grid", b =>
                {
                    b.Property<int>("key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("action")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("gridId")
                        .HasColumnType("INTEGER");

                    b.HasKey("key");

                    b.HasIndex("gridId");

                    b.ToTable("G");
                });

            modelBuilder.Entity("MvcMovie.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("XLoc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YLoc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("myD")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LocationGroupId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MvcMovie.Models.LocationGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("LocationGroup");
                });

            modelBuilder.Entity("MvcMovie.Models.Grid", b =>
                {
                    b.HasOne("MvcMovie.Models.LocationGroup", "grid")
                        .WithMany()
                        .HasForeignKey("gridId");
                });

            modelBuilder.Entity("MvcMovie.Models.Location", b =>
                {
                    b.HasOne("MvcMovie.Models.LocationGroup", null)
                        .WithMany("locations")
                        .HasForeignKey("LocationGroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
