# LandmarkApi

API RESTful para gerenciamento de pontos turísticos desenvolvida com ASP.NET Core.

## Arquitetura

O projeto utiliza **Domain-Driven Design (DDD)** como padrão arquitetural, organizando o código em camadas bem definidas:

- **Domain**: Contém as entidades e interfaces de repositório (núcleo da aplicação)
- **Application**: Contém os serviços, DTOs e interfaces de aplicação
- **Infrastructure**: Implementação de repositórios e contexto do banco de dados
- **Controllers**: Camada de apresentação com os endpoints da API

### Princípios SOLID Aplicados

- **Single Responsibility Principle (SRP)**: Cada classe tem uma única responsabilidade
- **Dependency Inversion Principle (DIP)**: Uso de interfaces para desacoplar as camadas
- **Interface Segregation Principle (ISP)**: Interfaces específicas para cada contexto

## Tecnologias

- .NET 10.0
- Entity Framework Core 10.0.1
- SQL Server
- Swagger/OpenAPI

## Pré-requisitos

- .NET 10.0 SDK
- SQL Server (LocalDB ou instância completa)

## Como Rodar o Projeto

### 1. Clone o repositório

```bash
git clone <url-do-repositorio>
cd LandmarkApi
```

### 2. Configure a Connection String

Edite o arquivo `appsettings.json` e ajuste a connection string conforme seu ambiente:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LandmarkDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

### 3. Execute as Migrations

```bash
dotnet ef database update
```

### 4. Execute o projeto

```bash
dotnet run
```

A API estará disponível em:
- HTTP: `http://localhost:5131`

### 5. Acesse o Swagger

Abra o navegador e acesse:
```
http://localhost:5131/swagger
```