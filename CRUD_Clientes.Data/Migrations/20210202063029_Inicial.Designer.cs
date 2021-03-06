﻿// <auto-generated />
using System;
using CRUD_Clientes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Clientes.Data.Migrations
{
    [DbContext(typeof(Clientes_Context))]
    [Migration("20210202063029_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD_Clientes.Model.ClsClientes", b =>
                {
                    b.Property<int>("IntIdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtFechaNacimineto")
                        .HasColumnType("datetime2");

                    b.Property<int>("ESexo")
                        .HasColumnType("int");

                    b.Property<string>("StrApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrDirección")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntIdCliente");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
