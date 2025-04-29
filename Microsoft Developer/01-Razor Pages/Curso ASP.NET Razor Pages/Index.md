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
