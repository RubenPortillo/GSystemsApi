﻿// <auto-generated />
using System;
using GSystemsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GSystemsApi.Migrations
{
    [DbContext(typeof(GSystemsApiContext))]
    partial class GSystemsApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GSystemsApi.Models.Empleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.ToTable("Empleado");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Apellido1 = "González",
                            Apellido2 = "Pérez",
                            EmpresaID = 1,
                            Mail = "jgonzalezp@empresa1.com",
                            Nombre = "Juan",
                            Perfil = 0,
                            Turno = 0
                        },
                        new
                        {
                            ID = 2,
                            Apellido1 = "Guitiérrez",
                            Apellido2 = "Fonseca",
                            EmpresaID = 1,
                            Mail = "jgutierrezf@empresa1.com",
                            Nombre = "José",
                            Perfil = 0,
                            Turno = 1
                        },
                        new
                        {
                            ID = 3,
                            Apellido1 = "San Román",
                            Apellido2 = "Calvo",
                            EmpresaID = 1,
                            Mail = "jsanromanc@empresa1.com",
                            Nombre = "Julián",
                            Perfil = 0,
                            Turno = 2
                        });
                });

            modelBuilder.Entity("GSystemsApi.Models.EmpleadoLogin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EmpleadoLogin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Mail = "jgonzalezp@empresa1.com",
                            Password = "1234"
                        },
                        new
                        {
                            ID = 2,
                            Mail = "jgutierrezf@empresa1.com",
                            Password = "1234"
                        },
                        new
                        {
                            ID = 3,
                            Mail = "jsanromanc@empresa1.com",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("GSystemsApi.Models.Empresa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FActivo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("Empresa");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Activo = true,
                            Direccion = "Calle falsa 123",
                            FActivo = new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Empresa1"
                        });
                });

            modelBuilder.Entity("GSystemsApi.Models.Incidencia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpleadoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FIncidencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("IncidenciaDesc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Prioridad")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmpleadoID");

                    b.ToTable("Incidencia");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EmpleadoID = 1,
                            FIncidencia = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncidenciaDesc = "Avería en llanta izquierda",
                            Prioridad = 0,
                            Ubicacion = "Calle falsa 123"
                        },
                        new
                        {
                            ID = 2,
                            EmpleadoID = 2,
                            FIncidencia = new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncidenciaDesc = "No arranca el motor, fallo motor",
                            Prioridad = 2,
                            Ubicacion = "Calle falsa 4556"
                        },
                        new
                        {
                            ID = 3,
                            EmpleadoID = 3,
                            FIncidencia = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncidenciaDesc = "Se enciende luz de 'Check motor' en el cuadro",
                            Prioridad = 1,
                            Ubicacion = "Calle falsa 789"
                        },
                        new
                        {
                            ID = 4,
                            EmpleadoID = 1,
                            FIncidencia = new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncidenciaDesc = "Incidencia Random",
                            Prioridad = 1,
                            Ubicacion = "Avenida de las Avenidas 12"
                        },
                        new
                        {
                            ID = 5,
                            EmpleadoID = 1,
                            FIncidencia = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncidenciaDesc = "Incidencia Random2",
                            Prioridad = 0,
                            Ubicacion = "Calle de las calles 1"
                        });
                });

            modelBuilder.Entity("GSystemsApi.Models.Tarea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescTarea")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpleadoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FTarea")
                        .HasColumnType("datetime2");

                    b.Property<int>("Prioridad")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmpleadoID");

                    b.ToTable("Tarea");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DescTarea = "Revisar llantas autobús 5248LMF",
                            Duracion = "4h",
                            EmpleadoID = 1,
                            FTarea = new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prioridad = 0
                        },
                        new
                        {
                            ID = 2,
                            DescTarea = "Revisar fallo de arranque en el autobús 7896GHF, el conductor indica que sale humo blanco.",
                            Duracion = "24h",
                            EmpleadoID = 2,
                            FTarea = new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prioridad = 2
                        },
                        new
                        {
                            ID = 3,
                            DescTarea = "Revisar 'Check Motor' encendido en autobús 1258HMR",
                            Duracion = "16h",
                            EmpleadoID = 3,
                            FTarea = new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prioridad = 1
                        });
                });

            modelBuilder.Entity("GSystemsApi.Models.Empleado", b =>
                {
                    b.HasOne("GSystemsApi.Models.Empresa", "Empresa")
                        .WithMany("Empleados")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GSystemsApi.Models.Incidencia", b =>
                {
                    b.HasOne("GSystemsApi.Models.Empleado", null)
                        .WithMany("Incidencias")
                        .HasForeignKey("EmpleadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GSystemsApi.Models.Tarea", b =>
                {
                    b.HasOne("GSystemsApi.Models.Empleado", null)
                        .WithMany("Tareas")
                        .HasForeignKey("EmpleadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GSystemsApi.Models.Empleado", b =>
                {
                    b.Navigation("Incidencias");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("GSystemsApi.Models.Empresa", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
