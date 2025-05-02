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