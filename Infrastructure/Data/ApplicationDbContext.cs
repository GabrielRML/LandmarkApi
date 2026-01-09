using LandmarkApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LandmarkApi.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public DbSet<TouristPoint> TouristPoints { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<State> States { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Seed de Estados
        modelBuilder.Entity<State>().HasData(
            new State { Id = 1, Acronym = "AC", Name = "Acre", IbgeCode = "12" },
            new State { Id = 2, Acronym = "AL", Name = "Alagoas", IbgeCode = "27" },
            new State { Id = 3, Acronym = "AP", Name = "Amapá", IbgeCode = "16" },
            new State { Id = 4, Acronym = "AM", Name = "Amazonas", IbgeCode = "13" },
            new State { Id = 5, Acronym = "BA", Name = "Bahia", IbgeCode = "29" },
            new State { Id = 6, Acronym = "CE", Name = "Ceará", IbgeCode = "23" },
            new State { Id = 7, Acronym = "DF", Name = "Distrito Federal", IbgeCode = "53" },
            new State { Id = 8, Acronym = "ES", Name = "Espírito Santo", IbgeCode = "32" },
            new State { Id = 9, Acronym = "GO", Name = "Goiás", IbgeCode = "52" },
            new State { Id = 10, Acronym = "MA", Name = "Maranhão", IbgeCode = "21" },
            new State { Id = 11, Acronym = "MT", Name = "Mato Grosso", IbgeCode = "51" },
            new State { Id = 12, Acronym = "MS", Name = "Mato Grosso do Sul", IbgeCode = "50" },
            new State { Id = 13, Acronym = "MG", Name = "Minas Gerais", IbgeCode = "31" },
            new State { Id = 14, Acronym = "PA", Name = "Pará", IbgeCode = "15" },
            new State { Id = 15, Acronym = "PB", Name = "Paraíba", IbgeCode = "25" },
            new State { Id = 16, Acronym = "PR", Name = "Paraná", IbgeCode = "41" },
            new State { Id = 17, Acronym = "PE", Name = "Pernambuco", IbgeCode = "26" },
            new State { Id = 18, Acronym = "PI", Name = "Piauí", IbgeCode = "22" },
            new State { Id = 19, Acronym = "RJ", Name = "Rio de Janeiro", IbgeCode = "33" },
            new State { Id = 20, Acronym = "RN", Name = "Rio Grande do Norte", IbgeCode = "24" },
            new State { Id = 21, Acronym = "RS", Name = "Rio Grande do Sul", IbgeCode = "43" },
            new State { Id = 22, Acronym = "RO", Name = "Rondônia", IbgeCode = "11" },
            new State { Id = 23, Acronym = "RR", Name = "Roraima", IbgeCode = "14" },
            new State { Id = 24, Acronym = "SC", Name = "Santa Catarina", IbgeCode = "42" },
            new State { Id = 25, Acronym = "SP", Name = "São Paulo", IbgeCode = "35" },
            new State { Id = 26, Acronym = "SE", Name = "Sergipe", IbgeCode = "28" },
            new State { Id = 27, Acronym = "TO", Name = "Tocantins", IbgeCode = "17" }
        );

        SeedCities(modelBuilder);
    }

    private static void SeedCities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Porto Velho", IbgeCode = "1100205", StateId = 22 },
            new City { Id = 2, Name = "Ji-Paraná", IbgeCode = "1100122", StateId = 22 },
            new City { Id = 3, Name = "Ariquemes", IbgeCode = "1100023", StateId = 22 },
            new City { Id = 4, Name = "Rio Branco", IbgeCode = "1200401", StateId = 1 },
            new City { Id = 5, Name = "Cruzeiro do Sul", IbgeCode = "1200203", StateId = 1 },
            new City { Id = 6, Name = "Manaus", IbgeCode = "1302603", StateId = 4 },
            new City { Id = 7, Name = "Parintins", IbgeCode = "1303403", StateId = 4 },
            new City { Id = 8, Name = "Itacoatiara", IbgeCode = "1301902", StateId = 4 },
            new City { Id = 9, Name = "Boa Vista", IbgeCode = "1400100", StateId = 23 },
            new City { Id = 10, Name = "Rorainópolis", IbgeCode = "1400472", StateId = 23 },
            new City { Id = 11, Name = "Belém", IbgeCode = "1501402", StateId = 14 },
            new City { Id = 12, Name = "Ananindeua", IbgeCode = "1500800", StateId = 14 },
            new City { Id = 13, Name = "Santarém", IbgeCode = "1506807", StateId = 14 },
            new City { Id = 14, Name = "Marabá", IbgeCode = "1504208", StateId = 14 },
            new City { Id = 15, Name = "Macapá", IbgeCode = "1600303", StateId = 3 },
            new City { Id = 16, Name = "Santana", IbgeCode = "1600600", StateId = 3 },
            new City { Id = 17, Name = "Palmas", IbgeCode = "1721000", StateId = 27 },
            new City { Id = 18, Name = "Araguaína", IbgeCode = "1702109", StateId = 27 },
            new City { Id = 19, Name = "Gurupi", IbgeCode = "1709500", StateId = 27 },
            new City { Id = 20, Name = "São Luís", IbgeCode = "2111300", StateId = 10 },
            new City { Id = 21, Name = "Imperatriz", IbgeCode = "2105302", StateId = 10 },
            new City { Id = 22, Name = "Caxias", IbgeCode = "2103000", StateId = 10 },
            new City { Id = 23, Name = "Teresina", IbgeCode = "2211001", StateId = 18 },
            new City { Id = 24, Name = "Parnaíba", IbgeCode = "2207702", StateId = 18 },
            new City { Id = 25, Name = "Picos", IbgeCode = "2208007", StateId = 18 },
            new City { Id = 26, Name = "Fortaleza", IbgeCode = "2304400", StateId = 6 },
            new City { Id = 27, Name = "Caucaia", IbgeCode = "2303709", StateId = 6 },
            new City { Id = 28, Name = "Juazeiro do Norte", IbgeCode = "2307304", StateId = 6 },
            new City { Id = 29, Name = "Sobral", IbgeCode = "2312908", StateId = 6 },
            new City { Id = 30, Name = "Natal", IbgeCode = "2408102", StateId = 20 },
            new City { Id = 31, Name = "Mossoró", IbgeCode = "2408003", StateId = 20 },
            new City { Id = 32, Name = "Parnamirim", IbgeCode = "2403251", StateId = 20 },
            new City { Id = 33, Name = "João Pessoa", IbgeCode = "2507507", StateId = 15 },
            new City { Id = 34, Name = "Campina Grande", IbgeCode = "2504009", StateId = 15 },
            new City { Id = 35, Name = "Santa Rita", IbgeCode = "2513703", StateId = 15 },
            new City { Id = 36, Name = "Recife", IbgeCode = "2611606", StateId = 17 },
            new City { Id = 37, Name = "Jaboatão dos Guararapes", IbgeCode = "2607901", StateId = 17 },
            new City { Id = 38, Name = "Olinda", IbgeCode = "2609600", StateId = 17 },
            new City { Id = 39, Name = "Caruaru", IbgeCode = "2604106", StateId = 17 },
            new City { Id = 40, Name = "Maceió", IbgeCode = "2704302", StateId = 2 },
            new City { Id = 41, Name = "Arapiraca", IbgeCode = "2700300", StateId = 2 },
            new City { Id = 42, Name = "Aracaju", IbgeCode = "2800308", StateId = 26 },
            new City { Id = 43, Name = "Nossa Senhora do Socorro", IbgeCode = "2804607", StateId = 26 },
            new City { Id = 44, Name = "Salvador", IbgeCode = "2927408", StateId = 5 },
            new City { Id = 45, Name = "Feira de Santana", IbgeCode = "2910800", StateId = 5 },
            new City { Id = 46, Name = "Vitória da Conquista", IbgeCode = "2933307", StateId = 5 },
            new City { Id = 47, Name = "Camaçari", IbgeCode = "2905701", StateId = 5 },
            new City { Id = 48, Name = "Belo Horizonte", IbgeCode = "3106200", StateId = 13 },
            new City { Id = 49, Name = "Uberlândia", IbgeCode = "3170206", StateId = 13 },
            new City { Id = 50, Name = "Contagem", IbgeCode = "3118601", StateId = 13 },
            new City { Id = 51, Name = "Juiz de Fora", IbgeCode = "3136702", StateId = 13 },
            new City { Id = 52, Name = "Vitória", IbgeCode = "3205309", StateId = 8 },
            new City { Id = 53, Name = "Vila Velha", IbgeCode = "3205200", StateId = 8 },
            new City { Id = 54, Name = "Serra", IbgeCode = "3205002", StateId = 8 },
            new City { Id = 55, Name = "Rio de Janeiro", IbgeCode = "3304557", StateId = 19 },
            new City { Id = 56, Name = "São Gonçalo", IbgeCode = "3304904", StateId = 19 },
            new City { Id = 57, Name = "Duque de Caxias", IbgeCode = "3301702", StateId = 19 },
            new City { Id = 58, Name = "Niterói", IbgeCode = "3303302", StateId = 19 },
            new City { Id = 59, Name = "São Paulo", IbgeCode = "3550308", StateId = 25 },
            new City { Id = 60, Name = "Guarulhos", IbgeCode = "3518800", StateId = 25 },
            new City { Id = 61, Name = "Campinas", IbgeCode = "3509502", StateId = 25 },
            new City { Id = 62, Name = "São Bernardo do Campo", IbgeCode = "3548708", StateId = 25 },
            new City { Id = 63, Name = "Curitiba", IbgeCode = "4106902", StateId = 16 },
            new City { Id = 64, Name = "Londrina", IbgeCode = "4113700", StateId = 16 },
            new City { Id = 65, Name = "Maringá", IbgeCode = "4115200", StateId = 16 },
            new City { Id = 66, Name = "Florianópolis", IbgeCode = "4205407", StateId = 24 },
            new City { Id = 67, Name = "Joinville", IbgeCode = "4209102", StateId = 24 },
            new City { Id = 68, Name = "Blumenau", IbgeCode = "4202404", StateId = 24 },
            new City { Id = 69, Name = "Porto Alegre", IbgeCode = "4314902", StateId = 21 },
            new City { Id = 70, Name = "Caxias do Sul", IbgeCode = "4305108", StateId = 21 },
            new City { Id = 71, Name = "Pelotas", IbgeCode = "4314407", StateId = 21 },
            new City { Id = 72, Name = "Campo Grande", IbgeCode = "5002704", StateId = 12 },
            new City { Id = 73, Name = "Dourados", IbgeCode = "5003702", StateId = 12 },
            new City { Id = 74, Name = "Cuiabá", IbgeCode = "5103403", StateId = 11 },
            new City { Id = 75, Name = "Várzea Grande", IbgeCode = "5108402", StateId = 11 },
            new City { Id = 76, Name = "Rondonópolis", IbgeCode = "5107602", StateId = 11 },
            new City { Id = 77, Name = "Goiânia", IbgeCode = "5208707", StateId = 9 },
            new City { Id = 78, Name = "Aparecida de Goiânia", IbgeCode = "5201405", StateId = 9 },
            new City { Id = 79, Name = "Anápolis", IbgeCode = "5201108", StateId = 9 },
            new City { Id = 80, Name = "Brasília", IbgeCode = "5300108", StateId = 7 }
        );
    }

}
