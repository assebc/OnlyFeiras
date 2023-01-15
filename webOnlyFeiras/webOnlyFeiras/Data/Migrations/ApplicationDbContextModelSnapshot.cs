﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webOnlyFeiras.Data;

#nullable disable

namespace webOnlyFeiras.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Banca", b =>
                {
                    b.Property<int>("BancaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BancaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathFotografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BancaId");

                    b.ToTable("Bancas");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CandidaturaParaBanca", b =>
                {
                    b.Property<int>("IdCandidaturaBanca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCandidaturaBanca"));

                    b.Property<int>("BancaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<bool>("PatrocinaFeira")
                        .HasColumnType("bit");

                    b.HasKey("IdCandidaturaBanca");

                    b.HasIndex("BancaId");

                    b.ToTable("CandidaturaParaBanca");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CandidaturaParaMarca", b =>
                {
                    b.Property<int>("IdCandidaturaMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCandidaturaMarca"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("MarcaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ResponsavelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdCandidaturaMarca");

                    b.HasIndex("MarcaNome");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("CandidaturaParaMarca");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UtilizadorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FeiraId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeiraId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CodigoPromocional", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<int>("PromocaoAplicada")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("CarrinhoId");

                    b.ToTable("CodigoPromocional");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Encomenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEncomenda")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("MoradaEnvio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Encomenda");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Feira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathFotografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Feira");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Marca", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataFundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePathLogotipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mercado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIPC")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepresentanteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Verificada")
                        .HasColumnType("bit");

                    b.HasKey("Nome");

                    b.HasIndex("RepresentanteId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EncomendaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EncomendaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AdicionadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Utilizador", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contacto")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PathFotografiaPerfil")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webOnlyFeiras.Model.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CandidaturaParaBanca", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Banca", "Banca")
                        .WithMany()
                        .HasForeignKey("BancaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banca");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CandidaturaParaMarca", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaNome")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webOnlyFeiras.Model.Utilizador", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Carrinho", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Utilizador", "Utilizador")
                        .WithMany()
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Categoria", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Feira", null)
                        .WithMany("Categorias")
                        .HasForeignKey("FeiraId");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.CodigoPromocional", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Carrinho", null)
                        .WithMany("CodigosPromocionais")
                        .HasForeignKey("CarrinhoId");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Marca", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Utilizador", "Representante")
                        .WithMany()
                        .HasForeignKey("RepresentanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Representante");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Produto", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Encomenda", null)
                        .WithMany("Produtos")
                        .HasForeignKey("EncomendaId");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Produtos", b =>
                {
                    b.HasOne("webOnlyFeiras.Model.Carrinho", null)
                        .WithMany("Produtos")
                        .HasForeignKey("CarrinhoId");

                    b.HasOne("webOnlyFeiras.Model.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Carrinho", b =>
                {
                    b.Navigation("CodigosPromocionais");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Encomenda", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("webOnlyFeiras.Model.Feira", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
