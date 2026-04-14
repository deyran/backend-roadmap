# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View - MP

# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View
### Responsabilidade Principal

- Estrutura, layout e aparência.
- Visualização do usuário
- View não deve conter lógica de negócio
- Code-behind: Deve ser usado o mínimo possível, como auxílio para animações mais complexas.

# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View

### 2. Implementação Técnica
* **Linguagem:** Preferencialmente definida em **XAML**.
* **Tipos de Classes:**
    * `ContentPage` (Páginas completas).
    * `ContentView` (Componentes reutilizáveis).
* **Data Templates:**
    * Usados para representar objetos visualmente.
    * **Sem code-behind.**
    * Vinculados a tipos específicos de View Model.


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