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

## Objetivo Final

- **Escalabilidade**: Crescimento em tamanho e escopo de forma sutentável.
- **Eficiência**: Redução de custos de modificação e melhora.