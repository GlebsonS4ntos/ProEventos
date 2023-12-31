﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProEventos.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNovasPropriedadesaclasseEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Eventos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAtivo",
                table: "Eventos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "IsAtivo",
                table: "Eventos");
        }
    }
}
