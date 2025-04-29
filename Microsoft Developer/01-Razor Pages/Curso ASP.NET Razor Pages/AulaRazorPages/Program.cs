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