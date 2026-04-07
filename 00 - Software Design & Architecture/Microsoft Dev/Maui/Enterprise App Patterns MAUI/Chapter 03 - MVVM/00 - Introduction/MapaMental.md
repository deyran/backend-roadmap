# Introduction - MP

## O Problema

- **Problema central**: Programar a Interface do Usuário (XAML) funto a Lógica de negócio no code-behind.
- **Consequências Negativa**:
  
  - Forte acoplamento
  - Maior complexidade na manutenção.
  - Dificultade nos testes unitários
  - Mudanças tornam-se caras e demoradas.

## Padrão MVVM

- MVVM (Model-View-ViewModel) é um padrão de arquitetura de software que separa a lógica de negócio da internface do usuário (UI) em três camadas distintas.
- Model: Dados e lógica de negócio.
- View: Interface do usuário.
- ViewModel: Coletas dos dados do Model, prepara, gerencia e os converte e entrega para view.

## Benefícios da Separação

- **Manutenibilidade**: Facilita a evolução do código e correções.
- **Testabilidade**: Permite a criação de Testes Unitários de forma isolada.
- **Reuso de Código**: Reaproveitamento de código em diferentes partes ou projetos.
- **Colaboração Otimizada**: Permite que desenvolvedores (lógica) e designers (UI) trabalhem simultaneamente sem interferências.

# BackEnd-RoadMap -> Software Design & Architecture
## Maui - Enterprise App -> CH03 MVVM
### Introduction ->

### 4. Objetivo Final
* **Escalabilidade:** Criar aplicações que podem crescer em tamanho e escopo de forma sustentável.
* **Eficiência:** Reduzir o custo de modificações e melhorar o ciclo de vida do software.