﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inscripcioness.Migrations
{
    /// <inheritdoc />
    public partial class agregamosaniocarrera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aniosCarreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aniosCarreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aniosCarreras_carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_CarreraId",
                table: "Inscripciones",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_aniosCarreras_CarreraId",
                table: "aniosCarreras",
                column: "CarreraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_carreras_CarreraId",
                table: "Inscripciones",
                column: "CarreraId",
                principalTable: "carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_carreras_CarreraId",
                table: "Inscripciones");

            migrationBuilder.DropTable(
                name: "aniosCarreras");

            migrationBuilder.DropIndex(
                name: "IX_Inscripciones_CarreraId",
                table: "Inscripciones");
        }
    }
}
