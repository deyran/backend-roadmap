var builder = WebApplication.CreateBuilder(args);

// Registro do servi�o Razor Pages
builder.Services.AddRazorPages();
// -------------------------------

var app = builder.Build();

// Definindo Rotas
app.UseRouting();
app.MapRazorPages();
// ---------------

app.Run();