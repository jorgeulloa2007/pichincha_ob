﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using creditoautomovilistico.Infrastructure.Context;

#nullable disable

namespace creditoautomovilistico.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220817005243_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.ClientePatio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("PatioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PatioId");

                    b.ToTable("ClientePatio");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MarcaAuto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("MarcaAuto")
                        .IsUnique();

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Patio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("NumeroPuntoVenta")
                        .HasColumnType("integer");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patios");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Edad")
                        .HasColumnType("integer");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Identificacion")
                        .IsUnique();

                    b.ToTable("Personas", (string)null);
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.SolicitudCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cuotas")
                        .HasColumnType("numeric(12,2)");

                    b.Property<int>("EjecutivoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Entrada")
                        .HasColumnType("numeric(12,2)");

                    b.Property<int>("Estado")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaElaboracion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MesesPlazo")
                        .HasColumnType("integer");

                    b.Property<string>("Observacion")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("PatioId")
                        .HasColumnType("integer");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EjecutivoId");

                    b.HasIndex("PatioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Avaluo")
                        .HasColumnType("numeric");

                    b.Property<int>("Cilindraje")
                        .HasColumnType("integer");

                    b.Property<int>("MarcaId")
                        .HasColumnType("integer");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("NroChasis")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Tipo")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("Id");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Cliente", b =>
                {
                    b.HasBaseType("creditoautomovilistico.Infrastructure.Models.Persona");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("integer");

                    b.Property<string>("IdentificacionConyuge")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("NombreConyuge")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("SujetoDeCredito")
                        .HasColumnType("boolean");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Ejecutivo", b =>
                {
                    b.HasBaseType("creditoautomovilistico.Infrastructure.Models.Persona");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<int>("PatioId")
                        .HasColumnType("integer");

                    b.HasIndex("PatioId");

                    b.ToTable("Ejecutivos", (string)null);
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.ClientePatio", b =>
                {
                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Patio", null)
                        .WithMany("Clientes")
                        .HasForeignKey("PatioId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.SolicitudCredito", b =>
                {
                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Cliente", "Cliente")
                        .WithMany("Solicitudes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Ejecutivo", "Ejecutivo")
                        .WithMany()
                        .HasForeignKey("EjecutivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Patio", "Patio")
                        .WithMany()
                        .HasForeignKey("PatioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Ejecutivo");

                    b.Navigation("Patio");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Cliente", b =>
                {
                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Persona", null)
                        .WithOne()
                        .HasForeignKey("creditoautomovilistico.Infrastructure.Models.Cliente", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Ejecutivo", b =>
                {
                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Persona", null)
                        .WithOne()
                        .HasForeignKey("creditoautomovilistico.Infrastructure.Models.Ejecutivo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("creditoautomovilistico.Infrastructure.Models.Patio", "Patio")
                        .WithMany("Ejecutivos")
                        .HasForeignKey("PatioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patio");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Patio", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Ejecutivos");
                });

            modelBuilder.Entity("creditoautomovilistico.Infrastructure.Models.Cliente", b =>
                {
                    b.Navigation("Solicitudes");
                });
#pragma warning restore 612, 618
        }
    }
}
