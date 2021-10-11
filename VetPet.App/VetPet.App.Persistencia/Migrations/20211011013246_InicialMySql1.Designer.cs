﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetPet.App.Persistencia;

namespace VetPet.App.Persistencia.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211011013246_InicialMySql1")]
    partial class InicialMySql1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("VetPet.App.Dominio.Anotacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Historiaid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("mascotaid")
                        .HasColumnType("int");

                    b.Property<int>("medicamento")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Historiaid");

                    b.HasIndex("mascotaid");

                    b.HasIndex("veterinarioid");

                    b.ToTable("Anotaciones");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Cita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("dia")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("mascotaid")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mascotaid");

                    b.HasIndex("veterinarioid");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Historia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("propietarioid")
                        .HasColumnType("int");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("propietarioid");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("apellido")
                        .HasColumnType("longtext");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("cedula")
                        .IsUnique();

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.HasIndex("username")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("VetPet.App.Dominio.Persona");

                    b.Property<string>("ciudad")
                        .HasColumnType("longtext");

                    b.Property<string>("direccion")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("VetPet.App.Dominio.Persona");

                    b.Property<DateTime>("horario_entrada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("horario_salida")
                        .HasColumnType("datetime(6)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Anotacion", b =>
                {
                    b.HasOne("VetPet.App.Dominio.Historia", null)
                        .WithMany("anotaciones")
                        .HasForeignKey("Historiaid");

                    b.HasOne("VetPet.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("mascotaid");

                    b.HasOne("VetPet.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioid");

                    b.Navigation("mascota");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Cita", b =>
                {
                    b.HasOne("VetPet.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("mascotaid");

                    b.HasOne("VetPet.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioid");

                    b.Navigation("mascota");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Mascota", b =>
                {
                    b.HasOne("VetPet.App.Dominio.Propietario", "propietario")
                        .WithMany("mascotas")
                        .HasForeignKey("propietarioid");

                    b.Navigation("propietario");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Historia", b =>
                {
                    b.Navigation("anotaciones");
                });

            modelBuilder.Entity("VetPet.App.Dominio.Propietario", b =>
                {
                    b.Navigation("mascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
