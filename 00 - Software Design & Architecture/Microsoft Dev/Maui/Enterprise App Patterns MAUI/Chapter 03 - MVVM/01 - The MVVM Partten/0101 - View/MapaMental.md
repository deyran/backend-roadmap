# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View - MP

### Responsabilidade Principal

- Estrutura, layout e aparência.
- Visualização do usuário
- View não deve conter lógica de negócio
- Code-behind: Deve ser usado o mínimo possível, como auxílio para animações mais complexas.

### Implementação Técnica

- Projeção de Interface do Usuário (UI) é feita pela linguagem de marcação XAML.
- Páginas View tem dois tipos: 1. ContentPage (Páginas completas); 2. ContentView (Componentes reutilizáveis).
- Views também podem ser representadas por Data Templates:
  
  - Representa objetos visualmente.
  - Sem code-behind.
  - Vinculado a View Model. 

# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View

### 3. O Papel do Code-Behind (`.xaml.cs`)
* **Uso Limitado:** Não deve conter lógica de negócios.
* **Casos Específicos:** Apenas para lógica de UI complexa (ex: animações difíceis de expressar em XAML).


# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View

### 4. Estado e Comportamento (Interação com a ViewModel)
* **Estado Lógico:** Definido pela View Model (ex: se uma operação está pendente).
* **Controle de Elementos:**
    * Habilitar/Desabilitar botões via **Data Binding**.
    * Evitar manipulação direta no code-behind.
* **Execução de Código:**
    * **Commands (`ICommand`):** Vinculação direta de propriedades do controle (ex: `Button.Command`) à ViewModel.
    * **Behaviors:** Escutam eventos ou comandos e disparam métodos/comandos na ViewModel.