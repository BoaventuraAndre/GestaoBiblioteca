﻿// <auto-generated />
using System;
using Biblioteca.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.DAL.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20220622164353_Adicionado Modelos de EntidadeCorrigidos")]
    partial class AdicionadoModelosdeEntidadeCorrigidos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.DAL.Models.AtivoBiblioteca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("NumberoDeCopias")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("AtivosBiblioteca");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AtivoBiblioteca");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.BibliotecaSurcusal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HoraAbertura")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BibliotecaSurcusais");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.CartaoMembro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cotas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Registo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CartoesMembro");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AtivoBibliotecaId")
                        .HasColumnType("int");

                    b.Property<int?>("CartaoMembroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Desde")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AtivoBibliotecaId");

                    b.HasIndex("CartaoMembroId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Espera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AtivoBibliotecaId")
                        .HasColumnType("int");

                    b.Property<int?>("CartaoMembroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EsperaPedida")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AtivoBibliotecaId");

                    b.HasIndex("CartaoMembroId");

                    b.ToTable("Esperas");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.HistoricoCheckout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtivoBibliotecaId")
                        .HasColumnType("int");

                    b.Property<int>("CartaoMembroId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Entrou")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Saiu")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AtivoBibliotecaId");

                    b.HasIndex("CartaoMembroId");

                    b.ToTable("HistoricosCheckout");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.HorasSurcusal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("int");

                    b.Property<int>("HoraAbertura")
                        .HasColumnType("int");

                    b.Property<int>("HoraFecho")
                        .HasColumnType("int");

                    b.Property<int?>("SurcusalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurcusalId");

                    b.ToTable("HorasSurcusais");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Membro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BibliotecaSurcusalPrincipalId")
                        .HasColumnType("int");

                    b.Property<int?>("CartaoMembroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimeiroNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UltimoNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("BibliotecaSurcusalPrincipalId");

                    b.HasIndex("CartaoMembroId");

                    b.ToTable("Membros");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Livro", b =>
                {
                    b.HasBaseType("Biblioteca.DAL.Models.AtivoBiblioteca");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeweyIndex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Livro");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Video", b =>
                {
                    b.HasBaseType("Biblioteca.DAL.Models.AtivoBiblioteca");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.AtivoBiblioteca", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.DAL.Models.BibliotecaSurcusal", "Localizacao")
                        .WithMany("AtivoBibliotecas")
                        .HasForeignKey("LocalizacaoId");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Checkout", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.AtivoBiblioteca", "AtivoBiblioteca")
                        .WithMany()
                        .HasForeignKey("AtivoBibliotecaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.DAL.Models.CartaoMembro", "CartaoMembro")
                        .WithMany("Checkouts")
                        .HasForeignKey("CartaoMembroId");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Espera", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.AtivoBiblioteca", "AtivoBiblioteca")
                        .WithMany()
                        .HasForeignKey("AtivoBibliotecaId");

                    b.HasOne("Biblioteca.DAL.Models.CartaoMembro", "CartaoMembro")
                        .WithMany()
                        .HasForeignKey("CartaoMembroId");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.HistoricoCheckout", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.AtivoBiblioteca", "AtivoBiblioteca")
                        .WithMany()
                        .HasForeignKey("AtivoBibliotecaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.DAL.Models.CartaoMembro", "CartaoMembro")
                        .WithMany()
                        .HasForeignKey("CartaoMembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.HorasSurcusal", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.BibliotecaSurcusal", "Surcusal")
                        .WithMany()
                        .HasForeignKey("SurcusalId");
                });

            modelBuilder.Entity("Biblioteca.DAL.Models.Membro", b =>
                {
                    b.HasOne("Biblioteca.DAL.Models.BibliotecaSurcusal", "BibliotecaSurcusalPrincipal")
                        .WithMany("Membros")
                        .HasForeignKey("BibliotecaSurcusalPrincipalId");

                    b.HasOne("Biblioteca.DAL.Models.CartaoMembro", "CartaoMembro")
                        .WithMany()
                        .HasForeignKey("CartaoMembroId");
                });
#pragma warning restore 612, 618
        }
    }
}
