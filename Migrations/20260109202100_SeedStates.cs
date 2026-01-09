using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandmarkApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Acronym", "IbgeCode", "Name" },
                values: new object[,]
                {
                    { 1, "AC", "12", "Acre" },
                    { 2, "AL", "27", "Alagoas" },
                    { 3, "AP", "16", "Amapá" },
                    { 4, "AM", "13", "Amazonas" },
                    { 5, "BA", "29", "Bahia" },
                    { 6, "CE", "23", "Ceará" },
                    { 7, "DF", "53", "Distrito Federal" },
                    { 8, "ES", "32", "Espírito Santo" },
                    { 9, "GO", "52", "Goiás" },
                    { 10, "MA", "21", "Maranhão" },
                    { 11, "MT", "51", "Mato Grosso" },
                    { 12, "MS", "50", "Mato Grosso do Sul" },
                    { 13, "MG", "31", "Minas Gerais" },
                    { 14, "PA", "15", "Pará" },
                    { 15, "PB", "25", "Paraíba" },
                    { 16, "PR", "41", "Paraná" },
                    { 17, "PE", "26", "Pernambuco" },
                    { 18, "PI", "22", "Piauí" },
                    { 19, "RJ", "33", "Rio de Janeiro" },
                    { 20, "RN", "24", "Rio Grande do Norte" },
                    { 21, "RS", "43", "Rio Grande do Sul" },
                    { 22, "RO", "11", "Rondônia" },
                    { 23, "RR", "14", "Roraima" },
                    { 24, "SC", "42", "Santa Catarina" },
                    { 25, "SP", "35", "São Paulo" },
                    { 26, "SE", "28", "Sergipe" },
                    { 27, "TO", "17", "Tocantins" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
