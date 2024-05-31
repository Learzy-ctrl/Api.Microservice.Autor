﻿// <auto-generated />
using System;
using Api.Microservice.Autor.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Microservice.Autor.Migrations
{
    [DbContext(typeof(ContextoAutor))]
    partial class ContextoAutorModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Microservice.Autor.Modelo.AutorLibro", b =>
                {
                    b.Property<int>("AutorLibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AutorLibroGuid")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AutorLibroId");

                    b.ToTable("AutorLibros");
                });

            modelBuilder.Entity("Api.Microservice.Autor.Modelo.GradoAcademico", b =>
                {
                    b.Property<int>("GradoAcademicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AutorLibroId")
                        .HasColumnType("int");

                    b.Property<string>("CentroAcademico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FechaGrado")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GradoAcademicoGuid")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GradoAcademicoId");

                    b.HasIndex("AutorLibroId");

                    b.ToTable("GradoAcademicos");
                });

            modelBuilder.Entity("Api.Microservice.Autor.Modelo.GradoAcademico", b =>
                {
                    b.HasOne("Api.Microservice.Autor.Modelo.AutorLibro", "AutorLibro")
                        .WithMany("GradoAcademicos")
                        .HasForeignKey("AutorLibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutorLibro");
                });

            modelBuilder.Entity("Api.Microservice.Autor.Modelo.AutorLibro", b =>
                {
                    b.Navigation("GradoAcademicos");
                });
#pragma warning restore 612, 618
        }
    }
}
