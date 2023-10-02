﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _18_CLUD_BD.Context;

#nullable disable

namespace _18_CLUD_BD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231002131617_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("_18_CLUD_BD.Models.Jogo", b =>
                {
                    b.Property<int>("jogoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Descricao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Imafem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.HasKey("jogoId");

                    b.ToTable("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
