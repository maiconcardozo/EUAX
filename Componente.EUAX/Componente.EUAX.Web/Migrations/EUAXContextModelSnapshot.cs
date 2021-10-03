﻿// <auto-generated />
using System;
using Componente.Agisyst.Web.WebUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Componente.EUAX.Web.Migrations
{
    [DbContext(typeof(EUAXContext))]
    partial class EUAXContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Componente.EUAX.Acao.Atividade", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataFim");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataInicio");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<bool>("Finalizada")
                        .HasColumnType("bit")
                        .HasColumnName("Finalizada");

                    b.Property<int?>("ProjetoCodigo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("ProjetoCodigo");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("Componente.EUAX.Acao.Projeto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataFim");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataInicio");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.HasKey("Codigo");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("Componente.EUAX.Acao.Atividade", b =>
                {
                    b.HasOne("Componente.EUAX.Acao.Projeto", "Projeto")
                        .WithMany("ListaAtividade")
                        .HasForeignKey("ProjetoCodigo");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("Componente.EUAX.Acao.Projeto", b =>
                {
                    b.Navigation("ListaAtividade");
                });
#pragma warning restore 612, 618
        }
    }
}
