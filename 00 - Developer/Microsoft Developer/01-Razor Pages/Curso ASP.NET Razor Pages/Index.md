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

- In the Index.cshtml file

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
2. Adicione uma view vazia (Razor View - Empty), chamada **_Layout.cshtml**, gere o seguinte código:

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

## [_ViewStart](https://youtu.be/uEc4DRQyPYY?t=6511)

- O arquivo *_ViewStart.cshtml* tem como principal objetivo definir o layout padrão que será utilizados em todas as páginas Razor do mesmo diretório (e seus subdiretórios) onde o arquivo *_ViewStart.cshtml* está localizado.

- Essa abordagem centraliza a configuração do Layout para várias páginas, evitando que você precise defini-lo individualmente em cada uma. Dessa forma, se o Layout mudar, a alteração é feita em apenas um local, no **_ViewStart.cshtml**, e se aplica automaticamente a todas as páginas

- Na prática, funciona da seguinte forma:

1. No diretório *Pages*, crie o arquivo *_ViewStart.cshtml*.
2. Para centralizar a configuração do Layout escreva o seguinte código no arquivo *_ViewStart.cshtml*:

```
@{
    Layout = "~/Pages/Shared/_Layout.cshtml";
}
```

3. Feito isso, basta eliminar qualquer referência de Layout nas demais páginas.

## [ViewData](https://youtu.be/uEc4DRQyPYY?t=6617)

Resumidamente é usado para transporte de dados.

1. No arquivo *_Layout.cshtml*

```
<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData["Title"]</title>
</head>
<body>
    @RenderBody()
</body>
</html>
```

2. No arquivo *Index.cshtml*

```
@page
@model AulaRazorPages.Pages.IndexModel

@{
    ViewData["Title"] = "Novo título";

}

<h1>Teste do ViewData</h1>
```

## [Modarização das páginas](https://youtu.be/uEc4DRQyPYY?t=6853)

1. **Estrutura de páginas**
   
- Razor pages é baseado em pastas. Por padrão, todas as páginas estão na pasta **Pages**
- É possível criar subpastas para agrupar páginas relacionadas por funcionalidades

```
/Pages
    /Produtos
        Index.cshtml
        Create.cshtml
        Edit.cshtml
    /Clientes
        Index.cshtml
        Details.cshtml
    /Pedidos
        Index.cshtml
```

2. **Áreas (Areas)**

**Areas** permite que a aplicação seja divida em seções funcionais indepententes, como pode ser visto no exemplo abaixo:

```
/Areas
    /Admin
        /Pages
            _ViewImports.cshtml
            _ViewStart.cshtml
            Index.cshtml
            Users.cshtml
    /Marketing
        /Pages
            _ViewImports.cshtml
            _ViewStart.cshtml
            Campaigns.cshtml
            Leads.cshtml
/Pages (páginas globais, não pertencentes a uma área específica)
    Index.cshtml
    Privacy.cshtml
```

https://youtu.be/uEc4DRQyPYY?t=6856