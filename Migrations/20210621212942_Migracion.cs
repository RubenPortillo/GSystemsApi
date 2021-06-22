using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSystemsApi.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpleadoLogin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoLogin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FActivo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmpresaID = table.Column<int>(type: "int", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Turno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Empleado_Empresa_EmpresaID",
                        column: x => x.EmpresaID,
                        principalTable: "Empresa",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidencia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidenciaDesc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIncidencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    Prioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Incidencia_Empleado_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescTarea = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FTarea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    Prioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tarea_Empleado_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmpleadoLogin",
                columns: new[] { "ID", "Mail", "Password" },
                values: new object[,]
                {
                    { 1, "jgonzalezp@empresa1.com", "1234" },
                    { 2, "jgutierrezf@empresa1.com", "1234" },
                    { 3, "jsanromanc@empresa1.com", "1234" }
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "ID", "Activo", "Direccion", "FActivo", "Nombre" },
                values: new object[] { 1, true, "Calle falsa 123", new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empresa1" });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "ID", "Apellido1", "Apellido2", "EmpresaID", "Mail", "Nombre", "Perfil", "Turno" },
                values: new object[] { 1, "González", "Pérez", 1, "jgonzalezp@empresa1.com", "Juan", 0, 0 });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "ID", "Apellido1", "Apellido2", "EmpresaID", "Mail", "Nombre", "Perfil", "Turno" },
                values: new object[] { 2, "Guitiérrez", "Fonseca", 1, "jgutierrezf@empresa1.com", "José", 0, 1 });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "ID", "Apellido1", "Apellido2", "EmpresaID", "Mail", "Nombre", "Perfil", "Turno" },
                values: new object[] { 3, "San Román", "Calvo", 1, "jsanromanc@empresa1.com", "Julián", 0, 2 });

            migrationBuilder.InsertData(
                table: "Incidencia",
                columns: new[] { "ID", "EmpleadoID", "FIncidencia", "IncidenciaDesc", "Prioridad", "Ubicacion" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avería en llanta izquierda", 0, "Calle falsa 123" },
                    { 4, 1, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidencia Random", 1, "Avenida de las Avenidas 12" },
                    { 5, 1, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidencia Random2", 0, "Calle de las calles 1" },
                    { 2, 2, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "No arranca el motor, fallo motor", 2, "Calle falsa 4556" },
                    { 3, 3, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se enciende luz de 'Check motor' en el cuadro", 1, "Calle falsa 789" }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "ID", "DescTarea", "Duracion", "EmpleadoID", "FTarea", "Prioridad" },
                values: new object[,]
                {
                    { 1, "Revisar llantas autobús 5248LMF", "4h", 1, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, "Revisar fallo de arranque en el autobús 7896GHF, el conductor indica que sale humo blanco.", "24h", 2, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Revisar 'Check Motor' encendido en autobús 1258HMR", "16h", 3, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_EmpresaID",
                table: "Empleado",
                column: "EmpresaID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Mail",
                table: "Empleado",
                column: "Mail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incidencia_EmpleadoID",
                table: "Incidencia",
                column: "EmpleadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_EmpleadoID",
                table: "Tarea",
                column: "EmpleadoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadoLogin");

            migrationBuilder.DropTable(
                name: "Incidencia");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
