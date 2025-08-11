# Criar Projeto ASP.NET Core MVC com .NET CLI

Este guia mostra como criar, executar e integrar um projeto ASP.NET Core MVC com Entity Framework Core usando o .NET CLI.


## 1. Criar o Projeto MVC

Para criar um projeto ASP.NET Core MVC com a estrutura básica (controllers, views, modelos), execute:

```bash
dotnet new mvc -n MinhaAppMvc
cd MinhaAppMvc
````

Isso criará uma pasta `MinhaAppMvc` com o projeto dentro.

Se quiser criar na pasta atual (sem criar subpasta), rode apenas:

```bash
dotnet new mvc
```


## 2. Executar o Projeto

Para executar a aplicação, use:

```bash
dotnet run
```

Por padrão, o projeto estará disponível em:

* `https://localhost:5001` (HTTPS)
* `http://localhost:5000` (HTTP)


## 3. Adicionar Entity Framework Core (EF Core)

Para usar EF Core com banco de dados SQL Server, adicione o pacote:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

E para usar as ferramentas de migração do EF Core:

```bash
dotnet tool install --global dotnet-ef
```

Confirme que o `dotnet-ef` está instalado:

```bash
dotnet ef --version
```


## 4. Criar um DbContext e Modelos

Exemplo básico de modelo:

```csharp
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```

DbContext:

```csharp
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
```

No `Startup.cs` ou `Program.cs`, registre o contexto:

```csharp
services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
```


## 5. Criar e Aplicar Migrações com EF Core

Para criar uma migração inicial com o nome `InitialCreate`:

```bash
dotnet ef migrations add InitialCreate
```

Para aplicar as migrações e atualizar o banco de dados:

```bash
dotnet ef database update
```


## Referências

* [dotnet new - Templates](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [dotnet ef CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
