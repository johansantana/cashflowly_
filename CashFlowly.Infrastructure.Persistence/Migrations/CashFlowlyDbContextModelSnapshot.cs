﻿// <auto-generated />
using System;
using CashFlowly.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CashFlowly.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(CashFlowlyDbContext))]
    partial class CashFlowlyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaGasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriasGastos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Vivienda"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Alimentación"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Transporte"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Salud"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Entretenimiento"
                        });
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaGastoPersonalizada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CategoriasGastosPersonalizadas");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaIngreso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriasIngresos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Salario"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Deudas cobradas"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Regalos / Donaciones"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Ventas personales"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Inversiones"
                        });
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaIngresoPersonalizada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CategoriasIngresosPersonalizadas");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SaldoDisponible")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Gasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CuentaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Ingreso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IngresoFijo")
                        .HasColumnType("bit");

                    b.Property<decimal>("Monto")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CuentaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ingresos");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.MetaFinanciera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaPropuesta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Objetivo")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("MetasFinancieras");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Confirmado")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IntentosFallidos")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RecordarSesion")
                        .HasColumnType("bit");

                    b.Property<bool>("Suspendido")
                        .HasColumnType("bit");

                    b.Property<string>("TokenVerificacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaGastoPersonalizada", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("CategoriasGastosPersonalizadas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaIngresoPersonalizada", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("CategoriasIngresosPersonalizadas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Cuenta", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Cuentas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Gasto", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.CategoriaGasto", "Categoria")
                        .WithMany("Gastos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CashFlowly.Core.Domain.Entities.Cuenta", "Cuenta")
                        .WithMany("Gastos")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Gastos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Cuenta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Ingreso", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.CategoriaIngreso", "Categoria")
                        .WithMany("Ingresos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CashFlowly.Core.Domain.Entities.Cuenta", "Cuenta")
                        .WithMany("Ingresos")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Ingresos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Cuenta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.MetaFinanciera", b =>
                {
                    b.HasOne("CashFlowly.Core.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Metas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaGasto", b =>
                {
                    b.Navigation("Gastos");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.CategoriaIngreso", b =>
                {
                    b.Navigation("Ingresos");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Cuenta", b =>
                {
                    b.Navigation("Gastos");

                    b.Navigation("Ingresos");
                });

            modelBuilder.Entity("CashFlowly.Core.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("CategoriasGastosPersonalizadas");

                    b.Navigation("CategoriasIngresosPersonalizadas");

                    b.Navigation("Cuentas");

                    b.Navigation("Gastos");

                    b.Navigation("Ingresos");

                    b.Navigation("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}
