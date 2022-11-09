using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaContratos.Migrations
{
    /// <inheritdoc />
    public partial class addedAll2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Area",
                table: "Area");

            migrationBuilder.RenameTable(
                name: "Area",
                newName: "area");

            migrationBuilder.AddPrimaryKey(
                name: "PK_area",
                table: "area",
                column: "id");

            migrationBuilder.CreateTable(
                name: "contrato",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechainicio = table.Column<DateTime>(name: "fecha_inicio", type: "datetime2", nullable: false),
                    fechafin = table.Column<DateTime>(name: "fecha_fin", type: "datetime2", nullable: false),
                    fechacontrato = table.Column<DateTime>(name: "fecha_contrato", type: "datetime2", nullable: false),
                    fechadictamen = table.Column<DateTime>(name: "fecha_dictamen", type: "datetime2", nullable: false),
                    tareas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    remuneracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    financiamientoespecial = table.Column<string>(name: "financiamiento_especial", type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechainactividad = table.Column<DateTime>(name: "fecha_inactividad", type: "datetime2", nullable: false),
                    motivobaja = table.Column<string>(name: "motivo_baja", type: "nvarchar(max)", nullable: false),
                    paso = table.Column<int>(type: "int", nullable: false),
                    personaid = table.Column<int>(name: "persona_id", type: "int", nullable: false),
                    estadocontratoid = table.Column<int>(name: "estado_contrato_id", type: "int", nullable: false),
                    areaid = table.Column<int>(name: "area_id", type: "int", nullable: false),
                    retribucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sujetoa = table.Column<string>(name: "sujeto_a", type: "nvarchar(max)", nullable: false),
                    traslado = table.Column<int>(type: "int", nullable: false),
                    nroexpediente = table.Column<string>(name: "nro_expediente", type: "nvarchar(max)", nullable: false),
                    pagaderos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nroresolucion = table.Column<string>(name: "nro_resolucion", type: "nvarchar(max)", nullable: false),
                    ejercicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grupopresupuestario = table.Column<string>(name: "grupo_presupuestario", type: "nvarchar(max)", nullable: false),
                    unidadpresupuestaria = table.Column<string>(name: "unidad_presupuestaria", type: "nvarchar(max)", nullable: false),
                    subunidadpresupuestaria = table.Column<string>(name: "subunidad_presupuestaria", type: "nvarchar(max)", nullable: false),
                    fuente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contrato", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "leyenda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leyenda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    fechanacimiento = table.Column<DateTime>(name: "fecha_nacimiento", type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roles = table.Column<JsonElement>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contrato");

            migrationBuilder.DropTable(
                name: "leyenda");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_area",
                table: "area");

            migrationBuilder.RenameTable(
                name: "area",
                newName: "Area");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Area",
                table: "Area",
                column: "id");
        }
    }
}
