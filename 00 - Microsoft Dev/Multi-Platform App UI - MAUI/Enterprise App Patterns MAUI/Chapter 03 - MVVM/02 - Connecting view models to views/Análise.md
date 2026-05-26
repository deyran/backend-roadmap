# Connecting ViewModels to Views - Análise

## "ViewModels can be connected to Views by using the data-binding capabilities of .NET MAUI."

- O que é data-binding capabilities of .NET MAUI?

  - É o mecanismo que conecta a View (interface em XAML) aos dados e à lógica de negócios da ViewModel (código em C#). 
  
  - Ele sincroniza os dados de forma automática. Se uma informação muda na ViewModel, a View é atualizada imediatamente, e vice-versa.
  
  - Vantagem:
    
    - *Código limpo*: Sem o data-binding, você precisaria dar um nome para cada componente da tela e escrever códigos manuais de atribuição (ex: *meuInput.Text = meuObjeto.Nome;*) para cada atualização.

    - Padrão MVVM: Mantém o projeto organizado, separando estritamente a interface da lógica de código.

## There are many approaches that can be used to construct views and view models and associate them at runtime. 

Então View e ViewModel tem duas etapas, a primeira a de construção e a segunda a associação entre elas?


## AAAAAAAA
These approaches fall into two categories, known as view first composition, and view model first composition. 

Choosing between view first composition and view model first composition is an issue of preference and complexity. 

However, all approaches share the same aim, which is for the view to have a view model assigned to its BindingContext property.