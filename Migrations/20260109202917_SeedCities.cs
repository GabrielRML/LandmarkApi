using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandmarkApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "IbgeCode", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "1100205", "Porto Velho", 22 },
                    { 2, "1100122", "Ji-Paraná", 22 },
                    { 3, "1100023", "Ariquemes", 22 },
                    { 4, "1200401", "Rio Branco", 1 },
                    { 5, "1200203", "Cruzeiro do Sul", 1 },
                    { 6, "1302603", "Manaus", 4 },
                    { 7, "1303403", "Parintins", 4 },
                    { 8, "1301902", "Itacoatiara", 4 },
                    { 9, "1400100", "Boa Vista", 23 },
                    { 10, "1400472", "Rorainópolis", 23 },
                    { 11, "1501402", "Belém", 14 },
                    { 12, "1500800", "Ananindeua", 14 },
                    { 13, "1506807", "Santarém", 14 },
                    { 14, "1504208", "Marabá", 14 },
                    { 15, "1600303", "Macapá", 3 },
                    { 16, "1600600", "Santana", 3 },
                    { 17, "1721000", "Palmas", 27 },
                    { 18, "1702109", "Araguaína", 27 },
                    { 19, "1709500", "Gurupi", 27 },
                    { 20, "2111300", "São Luís", 10 },
                    { 21, "2105302", "Imperatriz", 10 },
                    { 22, "2103000", "Caxias", 10 },
                    { 23, "2211001", "Teresina", 18 },
                    { 24, "2207702", "Parnaíba", 18 },
                    { 25, "2208007", "Picos", 18 },
                    { 26, "2304400", "Fortaleza", 6 },
                    { 27, "2303709", "Caucaia", 6 },
                    { 28, "2307304", "Juazeiro do Norte", 6 },
                    { 29, "2312908", "Sobral", 6 },
                    { 30, "2408102", "Natal", 20 },
                    { 31, "2408003", "Mossoró", 20 },
                    { 32, "2403251", "Parnamirim", 20 },
                    { 33, "2507507", "João Pessoa", 15 },
                    { 34, "2504009", "Campina Grande", 15 },
                    { 35, "2513703", "Santa Rita", 15 },
                    { 36, "2611606", "Recife", 17 },
                    { 37, "2607901", "Jaboatão dos Guararapes", 17 },
                    { 38, "2609600", "Olinda", 17 },
                    { 39, "2604106", "Caruaru", 17 },
                    { 40, "2704302", "Maceió", 2 },
                    { 41, "2700300", "Arapiraca", 2 },
                    { 42, "2800308", "Aracaju", 26 },
                    { 43, "2804607", "Nossa Senhora do Socorro", 26 },
                    { 44, "2927408", "Salvador", 5 },
                    { 45, "2910800", "Feira de Santana", 5 },
                    { 46, "2933307", "Vitória da Conquista", 5 },
                    { 47, "2905701", "Camaçari", 5 },
                    { 48, "3106200", "Belo Horizonte", 13 },
                    { 49, "3170206", "Uberlândia", 13 },
                    { 50, "3118601", "Contagem", 13 },
                    { 51, "3136702", "Juiz de Fora", 13 },
                    { 52, "3205309", "Vitória", 8 },
                    { 53, "3205200", "Vila Velha", 8 },
                    { 54, "3205002", "Serra", 8 },
                    { 55, "3304557", "Rio de Janeiro", 19 },
                    { 56, "3304904", "São Gonçalo", 19 },
                    { 57, "3301702", "Duque de Caxias", 19 },
                    { 58, "3303302", "Niterói", 19 },
                    { 59, "3550308", "São Paulo", 25 },
                    { 60, "3518800", "Guarulhos", 25 },
                    { 61, "3509502", "Campinas", 25 },
                    { 62, "3548708", "São Bernardo do Campo", 25 },
                    { 63, "4106902", "Curitiba", 16 },
                    { 64, "4113700", "Londrina", 16 },
                    { 65, "4115200", "Maringá", 16 },
                    { 66, "4205407", "Florianópolis", 24 },
                    { 67, "4209102", "Joinville", 24 },
                    { 68, "4202404", "Blumenau", 24 },
                    { 69, "4314902", "Porto Alegre", 21 },
                    { 70, "4305108", "Caxias do Sul", 21 },
                    { 71, "4314407", "Pelotas", 21 },
                    { 72, "5002704", "Campo Grande", 12 },
                    { 73, "5003702", "Dourados", 12 },
                    { 74, "5103403", "Cuiabá", 11 },
                    { 75, "5108402", "Várzea Grande", 11 },
                    { 76, "5107602", "Rondonópolis", 11 },
                    { 77, "5208707", "Goiânia", 9 },
                    { 78, "5201405", "Aparecida de Goiânia", 9 },
                    { 79, "5201108", "Anápolis", 9 },
                    { 80, "5300108", "Brasília", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);
        }
    }
}
