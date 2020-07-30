﻿// <auto-generated />
using Datos.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(TraficoContexto))]
    [Migration("20200730022646_prueba2")]
    partial class prueba2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelos.OperadorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoOperador")
                        .HasColumnType("int");

                    b.Property<string>("Epc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("EstadoSaldo")
                        .HasColumnType("int");

                    b.Property<string>("Modalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCliente")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Saldo")
                        .HasColumnType("int");

                    b.Property<int>("SaldoBajo")
                        .HasColumnType("int");

                    b.Property<string>("Tid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("operadorItems");
                });
#pragma warning restore 612, 618
        }
    }
}
