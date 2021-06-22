using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GSystemsApi.Models;

namespace GSystemsApi.Data
{
    public class GSystemsApiContext : DbContext
    {
        public GSystemsApiContext (DbContextOptions<GSystemsApiContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleado { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Tarea> Tarea { get; set; }

        public DbSet<Incidencia> Incidencia { get; set; }

        public DbSet<EmpleadoLogin> EmpleadoLogin { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>(empleado =>
            {
                empleado.HasKey(s => s.ID);
                empleado.Property(s => s.Nombre).IsRequired();
                empleado.Property(s => s.Apellido1).IsRequired();
                empleado.Property(s => s.Apellido2).IsRequired();
                empleado.HasIndex(s => s.Mail).IsUnique();
            });


            modelBuilder.Entity<Empleado>().HasData
            (
                new Empleado
                {
                    ID = 1,
                    Nombre = "Juan",
                    Apellido1 = "González",
                    Apellido2 = "Pérez",
                    Mail = "jgonzalezp@empresa1.com",
                    EmpresaID = 1,
                    Perfil = Models.enums.Perfil.Admin,
                    Turno = Models.enums.Turno.Manhana
                },
                new Empleado
                {
                    ID = 2,
                    Nombre = "José",
                    Apellido1 = "Guitiérrez",
                    Apellido2 = "Fonseca",
                    Mail = "jgutierrezf@empresa1.com",
                    EmpresaID = 1,
                    Perfil = Models.enums.Perfil.Admin,
                    Turno = Models.enums.Turno.Tarde
                },
                new Empleado
                {
                    ID = 3,
                    Nombre = "Julián",
                    Apellido1 = "San Román",
                    Apellido2 = "Calvo",
                    Mail = "jsanromanc@empresa1.com",
                    EmpresaID = 1,
                    Perfil = Models.enums.Perfil.Admin,
                    Turno = Models.enums.Turno.Noche
                }
            );
            modelBuilder.Entity<Empresa>().HasData
            (
                new Empresa
                {
                    ID = 1,
                    Nombre = "Empresa1",
                    Direccion = "Calle falsa 123",
                    Activo = true,
                    FActivo = DateTime.Parse("01/10/2015")
                }
            );

            modelBuilder.Entity<Incidencia>().HasData
           (
               new Incidencia
               {
                   ID = 1,
                   IncidenciaDesc = "Avería en llanta izquierda",
                   Ubicacion = "Calle falsa 123",
                   FIncidencia = DateTime.Parse("01/05/2021"),
                   EmpleadoID = 1,
                   Prioridad = Models.enums.Prioridad.Baja
               },
               new Incidencia
               {
                   ID = 2,
                   IncidenciaDesc = "No arranca el motor, fallo motor",
                   Ubicacion = "Calle falsa 4556",
                   FIncidencia = DateTime.Parse("20/06/2021"),
                   EmpleadoID = 2,
                   Prioridad = Models.enums.Prioridad.Alta
               },
               new Incidencia
               {
                   ID = 3,
                   IncidenciaDesc = "Se enciende luz de 'Check motor' en el cuadro",
                   Ubicacion = "Calle falsa 789",
                   FIncidencia = DateTime.Parse("01/05/2021"),
                   EmpleadoID = 3,
                   Prioridad = Models.enums.Prioridad.Media
               },

               new Incidencia
               {
                   ID = 4,
                   IncidenciaDesc = "Incidencia Random",
                   Ubicacion = "Avenida de las Avenidas 12",
                   FIncidencia = DateTime.Parse("23/05/2021"),
                   EmpleadoID = 1,
                   Prioridad = Models.enums.Prioridad.Media
               },

               new Incidencia
               {
                   ID = 5,
                   IncidenciaDesc = "Incidencia Random2",
                   Ubicacion = "Calle de las calles 1",
                   FIncidencia = DateTime.Parse("01/06/2021"),
                   EmpleadoID = 1,
                   Prioridad = Models.enums.Prioridad.Baja
               }
           );
            modelBuilder.Entity<Tarea>().HasData
          (
              new Tarea
              {
                  ID = 1,
                  DescTarea = "Revisar llantas autobús 5248LMF",
                  Duracion = "4h",
                  FTarea = DateTime.Parse("20/06/2021"),
                  EmpleadoID = 1,
                  Prioridad = Models.enums.Prioridad.Baja
              },
              new Tarea
              {
                  ID = 2,
                  DescTarea = "Revisar fallo de arranque en el autobús 7896GHF, el conductor indica que sale humo blanco.",
                  Duracion = "24h",
                  FTarea = DateTime.Parse("21/06/2021"),
                  EmpleadoID = 2,
                  Prioridad = Models.enums.Prioridad.Alta
              },
              new Tarea
              {
                  ID = 3,
                  DescTarea = "Revisar 'Check Motor' encendido en autobús 1258HMR",
                  Duracion = "16h",
                  FTarea = DateTime.Parse("21/06/2021"),
                  EmpleadoID = 3,
                  Prioridad = Models.enums.Prioridad.Media
              }
          );

            modelBuilder.Entity<EmpleadoLogin>().HasData
         (
             new EmpleadoLogin
             {
                 ID = 1,
                 Mail = "jgonzalezp@empresa1.com",
                 Password = "1234"
             },
             new EmpleadoLogin
             {
                 ID = 2,
                 Mail = "jgutierrezf@empresa1.com",
                 Password = "1234"
             },
             new EmpleadoLogin
             {
                 ID = 3,
                 Mail = "jsanromanc@empresa1.com",
                 Password = "1234"
             }
         );
        }
    }
}
