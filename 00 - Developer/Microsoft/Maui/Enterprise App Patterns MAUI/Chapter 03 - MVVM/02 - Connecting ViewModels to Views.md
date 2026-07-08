## Parágrafo 1

### "ViewModels can be connected to Views by using the data-binding capabilities of .NET MAUI."

- *O que é data-binding capabilities of .NET MAUI?*

  - É o mecanismo que conecta a View (interface em XAML) aos dados e à lógica de negócios da ViewModel (código em C#). 
  
  - Ele sincroniza os dados de forma automática. Se uma informação muda na ViewModel, a View é atualizada imediatamente, e vice-versa.
  
  - Vantagem:
    
    - *Código limpo*: Sem o data-binding, você precisaria dar um nome para cada componente da tela e escrever códigos manuais de atribuição (ex: *meuInput.Text = meuObjeto.Nome;*) para cada atualização.

    - Padrão MVVM: Mantém o projeto organizado, separando estritamente a interface da lógica de código.

### There are many approaches that can be used to construct Views and ViewModels and associate them at runtime. 

- *Quantas abordagens existem para construir View e View Models e associa-las em runtime? Faça uma lista simples de abordagens*
		[[BindingContext]]
* No ecossistema .NET MAUI existem 4 abordagens, que são:

  1. Declarativa (Via XAML)
  2. Via Código (Code-Behind)
  3. Injeção de Dependência (DI)
  4. Abordagem por Localizador (View Model Locator)

- *Então View e View Model tem duas etapas, a primeira a de construção e a segunda a associação entre elas? Poderia explicar melhor isso?*

  1. *Etapa 1: Construção (Instanciação)*
   
    Nesta fase, o framework renderiza os componentes visuais da View (XAML) e instancia a classe da ViewModel (C#), colocando ambas na memória de forma isolada.

  2. *Etapa 2: Associação (Vinculação)*

    Após serem criadas de forma isolada, a View e a ViewModel são conectadas através do BindingContext. A partir desse momento, o data-binding entra em ação, mantendo os dados de ambas sincronizados automaticamente.

### These approaches fall into two categories, known as view first composition, and ViewModel first composition.

Independentemente da abordagem escolhida, o processo de construção e associação sempre se encaixará em uma destas duas categorias:

  1. *View First Composition*

    É na View (XAML ou Code-Behind) que se toma iniciativa de solicitar a sua ViewModel para se conectar a ela.

  2. *ViewModel First Composition*
  
    A lógica de negócios determina qual ViewModel deve entrar em cena e, em seguida, o framework (ou um serviço de navegação) localiza e constrói a View correspondente para ela.

###  Choosing between View first composition and ViewModel first composition is an issue of preference and complexity. 

Por que escolher entre View First Composition e ViewModel First Composition é uma questão de preferencia e complexidade?

- *Preferência* - Depende do estilo de trabalho da equipe
- *Complexidade* - Depende do tamanho do projeto
### However, all approaches share the same aim, which is for the View to have a ViewModel assigned to its BindingContext property.

## Parágrafo 2

 **With View First composition the app is conceptually composed of Views that connect to the ViewModels they depend on. The primary benefit of this approach is that it makes it easy to construct loosely coupled, unit testable apps because the ViewModels have no dependence on the Views themselves.  It’s also easy to understand the structure of the app by following its visual structure, rather than having to track code execution to understand how classes are created and associated. In addition, view first construction aligns with the Microsoft Maui’s navigation system that’s responsible for constructing pages when navigation occurs, which makes a ViewModel first composition complex and misaligned with the platform.**

Na abordagem **View-First**, o app é focado nas Views. Cada View toma a iniciativa de se conectar à sua respectiva ViewModel para obter os dados de que precisa. Os benefícios dessa abordagem são:

1. **Baixo acoplamento**: Permite construir aplicativos desacoplados, já que as *ViewModels* não possuem nehuma dependência da *Views*.
2. **Facilidade em Testes Unitários**: Como as *ViewModels* são independentes das interfaces gráficas, elas se tornam fácil de testar isoladamente.
3. **Estrutura mais Intuitiva**: É fácil entender a organização do App apenas seguindo sua estrutura visual, eliminando a necessidade de rastrear a execução do código para entender como as classes são criadas e assossiadas ente si.
4. **Alinhamento nativo com o .NET MAUI**: O modelo se alinha perfeitamente ao sistema de navegação padrão da plataforma, que é responsável por construir as páginas de forma automática no momento que a navegação ocorre.

## Parágrafo 3

**With ViewModel first composition, the app is conceptually composed of ViewModels, with a service responsible for locating the View for a ViewModel. ViewModel first composition feels more natural to some developers, since the View creation can be abstracted away, allowing them to focus on the logical non-UI structure of the app. In addition, it allows ViewModels to be created by other ViewModels. However, this approach is often complex, and it can become difficult to understand how the various parts of the app are created and associated.**

Na abordagem **ViewModel-First** , o aplicativo é estruturado a partir de *ViewModels*, utilizando um serviço responsável por localizar a *View* correspondente para cada *ViewModel*

Os principais pontos dessa abordagem são:

- **Foco na lógica**: Para alguns desenvolvedores, esse modelo parece mais natural, pois a criação da interface (UI) é abstrata, permitindo focar exclusivamente na estrutura lógica do app.
- **Criação em cadeia**: Permite que uma ViewModel seja criada por outra ViewModel.
- **Complexidade elevada**: Essa abordagem é complexa, dificulta o entendimento de como diversas partes do aplicativo são criadas e associadas entre si.