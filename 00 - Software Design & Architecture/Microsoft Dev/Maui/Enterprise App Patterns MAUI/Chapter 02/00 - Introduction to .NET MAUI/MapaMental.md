# CH02 - Introduction do .Net Maui - MM

## Desafios do Desenvolvimento Enterprise

- Mudanças Constantes: Requisitos que evoluem e novos desafios de negócios.
- Feedback Contínuo: Alterações de escopo durante o desenvolvimento.
- Complexidade de Equipe: Necessidade de múltiplos desenvolvedores trabalhando simultaneamente em partes diferentes.
- Adaptabilidade: Exigência de uma arquitetura que permita modificações sem quebrar o sistema.

## O Problema: Apps Monolíticos

- Acoplamento Forte: Componentes dependentes entre si, sem separação clara.
- Dificuldade de Manutenção: Corrigir um erro pode gerar novos bugs em outras partes.
- Escalabilidade Baixa: Difícil adicionar ou substituir funcionalidades.

## A Solução: Componentes Desacoplados

- Particionamento: Divisão em componentes discretos e independentes.
- Separação de Preocupações (SoC):
- Horizontal: Autenticação, acesso a dados.
- Vertical: Funcionalidades de negócio específicas.
- Benefícios:

    - Testabilidade isolada.
    - Reuso de código.
    - Especialização de papéis (UI vs. Lógica de Negócio).


# BackEnd-RoadMap - Software Design & Architecture
## Maui - Enterprise App
### CH02 - Introduction do .Net Maui
#### Pilares de Implementação no .NET MAUI

- MVVM (Model-View-ViewModel): Separação essencial entre a interface (UI) e a lógica de apresentação.
- Injeção de Dependência (DI): Reduz o acoplamento e gerencia o ciclo de vida dos objetos.
- Comunicação: Uso de mensagens entre componentes para evitar referências diretas.
- Navegação: Definição de onde reside a lógica de transição entre telas.
- Validação: Estratégias para validar inputs e notificar o usuário.
- Segurança: Implementação de Autenticação e Autorização.
- Dados Remotos: Acesso a Web Services e estratégias de cache.
- Testes Unitários: Foco em criar código testável desde o início.