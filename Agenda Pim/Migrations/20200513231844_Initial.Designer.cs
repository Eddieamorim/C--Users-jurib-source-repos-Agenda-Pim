﻿// <auto-generated />
using System;
using Agenda_Pim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agenda_Pim.Migrations
{
    [DbContext(typeof(UsuarioContext))]
    [Migration("20200513231844_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agenda_Pim.Models.Agendamento", b =>
                {
                    b.Property<int>("IdAgendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoEvento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HorarioFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicial")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdAuditorio1")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario1")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoAgendamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Proprietario")
                        .HasColumnType("int");

                    b.Property<bool>("SttsTrigger")
                        .HasColumnType("bit");

                    b.HasKey("IdAgendamento");

                    b.HasIndex("IdAuditorio1");

                    b.HasIndex("IdUsuario1");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Agenda_Pim.Models.Auditorios", b =>
                {
                    b.Property<int>("IdAuditorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("NomeAuditorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObeservacaoAuditorio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAuditorio");

                    b.ToTable("Auditorios");
                });

            modelBuilder.Entity("Agenda_Pim.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TipoUsuario")
                        .HasColumnType("bit");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Agenda_Pim.Models.Agendamento", b =>
                {
                    b.HasOne("Agenda_Pim.Models.Auditorios", "IdAuditorio")
                        .WithMany()
                        .HasForeignKey("IdAuditorio1");

                    b.HasOne("Agenda_Pim.Models.Usuario", "IdUsuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario1");
                });
#pragma warning restore 612, 618
        }
    }
}
