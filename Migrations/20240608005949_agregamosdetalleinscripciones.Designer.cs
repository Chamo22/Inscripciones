﻿// <auto-generated />
using System;
using Inscripcioness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inscripcioness.Migrations
{
    [DbContext(typeof(InscripcionesContext))]
    [Migration("20240608005949_agregamosdetalleinscripciones")]
    partial class agregamosdetalleinscripciones
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Inscripcioness.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoNombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("alumnos");
                });

            modelBuilder.Entity("Inscripcioness.Models.AnioCarrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.ToTable("aniosCarreras");
                });

            modelBuilder.Entity("Inscripcioness.Models.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("carreras");
                });

            modelBuilder.Entity("Inscripcioness.Models.DetalleInscripciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("ModalidadCursado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InscripcionId");

                    b.HasIndex("MateriaId");

                    b.ToTable("DetalleInscripciones");
                });

            modelBuilder.Entity("Inscripcioness.Models.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlumnoID")
                        .HasColumnType("int");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoID");

                    b.HasIndex("CarreraId");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("Inscripcioness.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnioCarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnioCarreraId");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("Inscripcioness.Models.AnioCarrera", b =>
                {
                    b.HasOne("Inscripcioness.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("Inscripcioness.Models.DetalleInscripciones", b =>
                {
                    b.HasOne("Inscripcioness.Models.Inscripcion", "Inscripcion")
                        .WithMany()
                        .HasForeignKey("InscripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inscripcioness.Models.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inscripcion");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Inscripcioness.Models.Inscripcion", b =>
                {
                    b.HasOne("Inscripcioness.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inscripcioness.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("Inscripcioness.Models.Materia", b =>
                {
                    b.HasOne("Inscripcioness.Models.AnioCarrera", "AnioCarrera")
                        .WithMany()
                        .HasForeignKey("AnioCarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnioCarrera");
                });
#pragma warning restore 612, 618
        }
    }
}
