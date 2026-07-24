## Inversion of Control - `IoC`

- **Normalmente**, uma classe cria suas dependências usando `New`
- **Com o Controle Invertido**, um componente externo (**Container**) fornece essas dependências.
- A classe apenas declara o que precisa, e o Container injeta os objetos necessários em tempo de execução
- O objetivo é **reduzir o acoplamento entre classes**, tornando o código mais flexível e fácil de manter
## DI Container

- **Automatiza a criação de instâncias** junto com suas respectivas dependências.
- Reduz o acoplamento entre classes.
- Gerencia ciclo de vida dos objetos
- No **.NET MAUI**, utiliza `Microsoft.Extensions.DependencyInjection` por meio do `MauiAppBuilder`.
## Benefícios

- **Reutilização de código**, evitando duplicação desnecessária.
- **Testabilidade**, com suporte a _mocking_ em testes unitários.
- **Manutenção facilitada**, tornando o código mais simples de evoluir.
- **Flexibilidade para trocar implementações**, sem alterar a lógica principal da aplicação.
## Aplicação em .NET MAUI

- **Configuração** realizada no arquivo `MauiProgram.cs`.
- **Registro de serviços** com `builder.Services.AddTransient`, `AddSingleton` ou `AddScoped`.
- **Injeção automática** de dependências nos construtores de `ViewModels` e `Services`.
```
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppDI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>();

            // Registro de serviços
            builder.Services.AddSingleton<IMensagemService, MensagemService>();
            builder.Services.AddTransient<MainViewModel>();

            return builder.Build();
        }
    }
}
```
## MVVM + DI

- O **ViewModel** recebe suas dependências via construtor.
- Os **Services** são resolvidos pelo container de injeção.
- Facilita a **separação de responsabilidades**, tornando o código mais organizado e testável.