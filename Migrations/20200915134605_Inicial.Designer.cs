﻿// <auto-generated />
using Clase2_Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clase2_Registro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200915134605_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Clase2_Registro.Actores", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SalarioAnual")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("ActorId");

                    b.ToTable("Actores");
                });
#pragma warning restore 612, 618
        }
    }
}
