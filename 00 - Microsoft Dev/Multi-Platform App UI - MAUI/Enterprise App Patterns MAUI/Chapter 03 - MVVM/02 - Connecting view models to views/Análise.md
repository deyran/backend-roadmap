# Connecting ViewModels to Views - Análise

## Parágrafo 1

### "ViewModels can be connected to Views by using the data-binding capabilities of .NET MAUI."

- *O que é data-binding capabilities of .NET MAUI?*

  - É o mecanismo que conecta a View (interface em XAML) aos dados e à lógica de negócios da ViewModel (código em C#). 
  
  - Ele sincroniza os dados de forma automática. Se uma informação muda na ViewModel, a View é atualizada imediatamente, e vice-versa.
  
  - Vantagem:
    
    - *Código limpo*: Sem o data-binding, você precisaria dar um nome para cada componente da tela e escrever códigos manuais de atribuição (ex: *meuInput.Text = meuObjeto.Nome;*) para cada atualização.

    - Padrão MVVM: Mantém o projeto organizado, separando estritamente a interface da lógica de código.

### There are many approaches that can be used to construct views and view models and associate them at runtime. 

- *Quantas abordagens existem para construir View e ViewModels e associa-las em runtime? Faça uma lista simples de abordagens*

* No ecossistema .NET MAUI existem 4 abordagens, que são:

  1. Declarativa (Via XAML)
  2. Via Código (Code-Behind)
  3. Injeção de Dependência (DI)
  4. Abordagem por Localizador (ViewModel Locator)

- *Então View e ViewModel tem duas etapas, a primeira a de construção e a segunda a associação entre elas? Poderia explicar melhor isso?*

  1. *Etapa 1: Construção (Instanciação)*
   
    Nesta fase, o framework renderiza os componentes visuais da View (XAML) e instancia a classe da ViewModel (C#), colocando ambas na memória de forma isolada.

  2. *Etapa 2: Associação (Vinculação)*

    Após serem criadas de forma isolada, a View e a ViewModel são conectadas através do BindingContext. A partir desse momento, o data-binding entra em ação, mantendo os dados de ambas sincronizados automaticamente.

### These approaches fall into two categories, known as view first composition, and view model first composition.

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

### With View First composition the app is conceptually composed of Views that connect to the ViewModels they depend on. 

### The primary benefit of this approach is that it makes it easy to construct loosely coupled, unit testable apps because the ViewModels have no dependence on the Views themselves. 

### It’s also easy to understand the structure of the app by following its visual structure, rather than having to track code execution to understand how classes are created and associated. 

### In addition, view first construction aligns with the Microsoft Maui’s navigation system that’s responsible for constructing pages when navigation occurs, which makes a view model first composition complex and misaligned with the platform.

- Na abordagem **View-First**, o app é focado nas Views. Cada View toma a iniciativa de se conectar à sua respectiva ViewModel para obter os dados de que precisa.
