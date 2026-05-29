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

* Independentemente da abordagem escolhida, o processo de construção e associação sempre se encaixará em uma destas duas categorias:

  1. *View First Composition*

    É na View (XAML ou Code-Behind) que se toma iniciativa de solicitar a sua ViewModel para se conectar a ela.

  2. *ViewModel First Composition*
  
    A lógica de negócios determina qual ViewModel deve entrar em cena e, em seguida, o framework (ou um serviço de navegação) localiza e constrói a View correspondente para ela.

### AAAAAAA

 Choosing between view first composition and view model first composition is an issue of preference and complexity. However, all approaches share the same aim, which is for the view to have a view model assigned to its BindingContext property.