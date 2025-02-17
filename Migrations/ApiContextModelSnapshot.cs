﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using premozi;

#nullable disable

namespace premozi.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("premozi.Models.Terem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allapot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Ferohely")
                        .HasColumnType("int");

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Oszlopok")
                        .HasColumnType("int");

                    b.Property<int>("Sorok")
                        .HasColumnType("int");

                    b.Property<string>("Tipus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Termek", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
