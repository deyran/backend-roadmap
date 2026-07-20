## Inversion of Control - `IoC`

- Controle de obtenção de dependência é invertido
- Um componente externo (*Container*) é responsável  por injetar dependências necessárias em um objeto em tempo de execução
- Tem como objetivo reduzir o acoplamento entre classes
## DI Container

- **Função**: 

	1. Reduz o acoplamento
	2. Gerencia ciclo de vida dos objetos
	3. Automatiza a criação de instâncias com suas respectivas dependências

- `.NET MAUI` utiliza *`Microsoft.Extensions.DependencyInjection`* via *`MauiAppBuilder`*
## Benefícios

- Reutilização de código
- Testabilidade (mocking em testes unitários)
- Manutenção facilitada
- Flexibilidade para trocar implementações
## Aplicação em .NET MAUI

- Configuração no `MauiProgram.cs`
- Registro de serviços com `builder.Services.AddTransient`, `AddSingleton`, `AddScoped`
- Injeção automática em construtores `ViewModels` e `Services`
## MVVM + DI

- `ViewModel` recebe dependências via construtor
- `Services` são resolvidos pelo container
- Facilita separação de responsabilidades