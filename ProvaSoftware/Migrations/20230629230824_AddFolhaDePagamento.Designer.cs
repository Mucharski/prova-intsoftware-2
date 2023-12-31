﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaSoftware.Data;

#nullable disable

namespace ProvaSoftware.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230629230824_AddFolhaDePagamento")]
    partial class AddFolhaDePagamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("ProvaSoftware.Data.Models.FolhaDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Bruto")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Fgts")
                        .HasColumnType("TEXT");

                    b.Property<int>("Horas")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Inss")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Irrf")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Liquido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FolhaPagamento");
                });
#pragma warning restore 612, 618
        }
    }
}
