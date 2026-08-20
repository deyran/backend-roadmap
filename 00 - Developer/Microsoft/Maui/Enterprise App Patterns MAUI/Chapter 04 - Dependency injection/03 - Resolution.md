## Registro de Serviços

- Registrar tipos e serviços no container para que o framework possa instanciá‑los e gerenciá‑los

- **Exemplo**: ```builder.Services.AddSingleton<IMyService, MyService>();```
## Resolução de Tipos

- A resolução ocorre após o registro; o container retorna instâncias conforme o escopo configurado: 
	- **Não registrado** → Tentativa de resolução lança exceção.
	- **Singleton** → Mesma instância; criada na primeira resolução; container mantém a mesma referência.
	- **Transient** → Nova instância a cada resolução; sem referência mantida.

- - **Exemplo**: ```var svc = serviceProvider.GetService<IMyService>();``` 
## Injeção em Views e ViewModels

- *Durante a navegação Shell*
	- O Shell procura registro da View (ex.: `FiltersView`) e cria a View.
	- Construtor da View pode receber um ViewModel via DI.
	
- **Exemplo:**  
	```
	public FilteresView(CataloViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
	```
- **Dica**: Registrar ViewModels e dependências em `CreateMauiApp` (`MauiProgram`)	
## Navegação de Rotas

- **Registro de Rota**
```
Routing.RegisterRouter("Filter", typeof(FiltersView));
```
- **Comportamento**: Ao navegar para rota, Maui cria a View e injeta dependências registradas.
## Cuidados e Boas Práticas

- *Handler pode ser null*
	- Sempre tratar `this.Handler` possivelmente nulo antes de acessar `MauiContext`.
	- Verificar ciclos de vida do `Handler`.
- *Registrar todas as dependências necessárias*
	- ViewModels que dependem de serviços devem ter esse serviços registrados.
- *Escolher escopo correto*
	- Usar `singleton` para serviços compartilhados/estado global.
	- Usar `Transient` para objetos sem estado ou curtos.