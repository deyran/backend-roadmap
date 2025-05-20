# [Curso ASP.NET Razor Pages](https://www.youtube.com/live/uEc4DRQyPYY?si=4EtcfqES4h1cgJwf)

## [Como funciona a web?](https://youtu.be/uEc4DRQyPYY?t=1493)

## [Backend e Frontend](https://youtu.be/uEc4DRQyPYY?t=1916)

## [ASP.NET](https://youtu.be/uEc4DRQyPYY?t=2181)

## [Criar projeto](https://youtu.be/uEc4DRQyPYY?t=3202)

1. Asp Core Empty
2. AulaRazorPages
   
## [Estrutura do projeto](https://youtu.be/uEc4DRQyPYY?t=3348)

1. Dependecies
2. Properties
3. appsettings.json
4. Program.cs

## [Configurar para usar Razor pages](https://youtu.be/uEc4DRQyPYY?t=3658)

No arquivo **Program.cs**, adicione o serviço Razor Pages e definir rotas.

```
var builder = WebApplication.CreateBuilder(args);

// Registro do serviço Razor Pages
builder.Services.AddRazorPages();
// -------------------------------

var app = builder.Build();

// Definindo Rotas
app.UseHttpsRedirection();
app.UseRouting();
app.MapRazorPages();
// ---------------

app.Run();
```

## [Razor Pages e MVC](https://youtu.be/uEc4DRQyPYY?t=3799)

Para as páginas do Razor Pages funcionarem, é necessário criar a pasta **Pages** no diretório raiz e coloca-las dentro desta pasta

## [Index.cshtml | Snippets | Bloco de código](https://youtu.be/uEc4DRQyPYY?t=3891)

- Na pasta Pages, crie o arquivo **Index.cshtml**. 
- Index por padrão é a primeira página, caso queira outra é necessário o roteamento.
- Usando o Visual Studio, para criar estrutura padrão de página é só digitar **html5**.

## [C# | Bloco de código | Acesso as varáveis](https://youtu.be/uEc4DRQyPYY?t=4069)

- Para acessar o C# na página basta usar o **@**
- Para criar um se faz assim **@{}**
- Código abaixo mostra o exemplo

```
@{
    var MyFullName = "Deyvid Rannyere de Moraes Costa";
}

...
 <h1>@MyFullName</h1>
...
```

## [Acessando o Index.cshtml.cs](https://youtu.be/uEc4DRQyPYY?t=4413)

- In the Index.cshtml.cs file

```
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string MyFullName { get; set; }

        public void OnGet()
        {
            MyFullName = "Deyvid Rannyere de Moraes Costa - it comes from code behind";
        }
    }
}
```

- - In the Index.cshtml file

```
@page
@model AulaRazorPages.Pages.IndexModel

@{
    var mTitle = Model.MyFullName;
}

<!DOCTYPE html>
<html>
<head>
    <title>@mTitle</title>
</head>
<body>
    <h1>@mTitle</h1>
</body>
</html>
```

## [Directiva @page](https://youtu.be/uEc4DRQyPYY?t=4572)

A directiva @page serve para facilitar o roteamento da página.

## [Conteúdo dinâmico](https://youtu.be/uEc4DRQyPYY?t=4931)

1. Bibliotecas

- Entity Framework Core
- Entity Framework Core InMemory
- Slugify

2. Criar a pasta Data

- Movie.cs
- MoviesContent.cs

3. Esse código está rodando em SSR. Razor Page não é SPA
   
- SPA (Sinlge Pages Application) não tem a necessidade de carregar tudo 

## [Layout](https://youtu.be/uEc4DRQyPYY?t=6225)

O Layout define a estrutura padrão das páginas do site

1. Na pasta **Pages**, crie uma pasta chamada **Shared**
2. Adicione uma view vazia (Razor View - Empty), chamada _Layout.cshtml, gere o seguinte código:

```
<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<body>
    @RenderBody()
</body>
</html>
```

4. Atualize a página Index.cshtml da seguinte forma:
   
```
@page
@model AulaRazorPages.Pages.IndexModel

@{
    var mTitle = Model.MyTitleTest;
    Layout = "~/Pages/Shared/_Layout.cshtml";
}

<h1>@mTitle</h1>
<a href="/movies">The best 10 movies in 2024</a>
```

5. https://youtu.be/uEc4DRQyPYY?t=6511
