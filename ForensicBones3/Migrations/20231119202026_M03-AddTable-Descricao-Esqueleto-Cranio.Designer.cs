﻿// <auto-generated />
using System;
using ForensicBones3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForensicBones3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231119202026_M03-AddTable-Descricao-Esqueleto-Cranio")]
    partial class M03AddTableDescricaoEsqueletoCranio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForensicBones3.Models.DescricaoCranio", b =>
                {
                    b.Property<int>("DescricaoCranioId")
                        .HasColumnType("int");

                    b.Property<string>("CartilagemTireoide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConchaNasalDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConchaNasalEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Esfenoide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtmoideDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtmoideEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frontal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hioide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LacrimalDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LacrimalEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mandibula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maxilar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NasalEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocipital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParietalDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParietalEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemporalDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemporalEsq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vomer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZigomaticoDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZigomaticoEsq")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescricaoCranioId");

                    b.ToTable("DescricoesCranios");
                });

            modelBuilder.Entity("ForensicBones3.Models.InventarioCranio", b =>
                {
                    b.Property<int>("InventarioCranioId")
                        .HasColumnType("int");

                    b.Property<string>("FotoCranio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventarioEsqueletoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventarioCranioId");

                    b.ToTable("InventariosCranio");
                });

            modelBuilder.Entity("ForensicBones3.Models.InventarioEsqueleto", b =>
                {
                    b.Property<int>("InventarioEsqueletoId")
                        .HasColumnType("int");

                    b.Property<string>("FotoEsqueleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatorioId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventarioEsqueletoId");

                    b.ToTable("InventariosEsqueleto");
                });

            modelBuilder.Entity("ForensicBones3.Models.Relatorio", b =>
                {
                    b.Property<int>("RelatorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RelatorioId"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("RelatorioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("ForensicBones3.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ForensicBones3.Models.DescricaoCranio", b =>
                {
                    b.HasOne("ForensicBones3.Models.InventarioCranio", "InventarioCranio")
                        .WithMany()
                        .HasForeignKey("DescricaoCranioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventarioCranio");
                });

            modelBuilder.Entity("ForensicBones3.Models.InventarioCranio", b =>
                {
                    b.HasOne("ForensicBones3.Models.InventarioEsqueleto", "InventarioEsqueleto")
                        .WithMany()
                        .HasForeignKey("InventarioCranioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventarioEsqueleto");
                });

            modelBuilder.Entity("ForensicBones3.Models.InventarioEsqueleto", b =>
                {
                    b.HasOne("ForensicBones3.Models.Relatorio", "Relatorio")
                        .WithMany()
                        .HasForeignKey("InventarioEsqueletoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relatorio");
                });

            modelBuilder.Entity("ForensicBones3.Models.Relatorio", b =>
                {
                    b.HasOne("ForensicBones3.Models.Usuario", "Usuario")
                        .WithMany("Relatorios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ForensicBones3.Models.Usuario", b =>
                {
                    b.Navigation("Relatorios");
                });
#pragma warning restore 612, 618
        }
    }
}
