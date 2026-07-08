# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View - MP

### Responsabilidade Principal

- Estrutura, layout e aparência.
- Visualização do usuário
- View não deve conter lógica de negócio
- Code-behind (.xaml.cs): Deve ser usado o mínimo possível, como auxílio para animações mais complexas.

### Implementação Técnica

- Projeção de Interface do Usuário (UI) é feita pela linguagem de marcação XAML.
- Páginas View tem dois tipos: 1. ContentPage (Páginas completas); 2. ContentView (Componentes reutilizáveis).
- Views também podem ser representadas por Data Templates:
  
  - Representa objetos visualmente.
  - Sem code-behind.
  - Vinculado a View Model. 

### Estado e Comportamento (Interação com a ViewModel)

- Mudanças de estado de exibição do View é realizado no View Model.
- Manipulação no code-behinde deve ser evitado.
- Dois tipos de execução de código: 1. Commands (ICommand); 2. Behaviors.