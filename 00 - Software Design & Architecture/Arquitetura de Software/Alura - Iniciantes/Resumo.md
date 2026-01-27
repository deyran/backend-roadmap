# ARQUITETURA DE SOFTWARE para INICIANTES: as principais dúvidas em 10 minutos - Resumo

## Definição de Arquitetura de Software

- Define o comportamento e características fundamentais do Sistema.
- Solução estruturada para as necessidades técnicas ou operacionais baseado no domício do negócio.
- Alinha o desenvolvimento ao roadmap da empresa já prevendo eventuais mudanças.

## Fatores de Decisões Arquiteturais

- *Características do Sistema*: Escalabilidade, Manutenabilidade e Confiabilidade.
- *Restrições (Constraints)*: O que pode ou não ser feito num sistema e de que forma

    - Quais partes de um sistem podem se comunicar com outras.
    - Quais partes de um sistem podem acesso a determinada base de dados.
    - Etc.

- *Trade-offs (Compromissos)*: É uma equilibrio entre **Benefícios** e **Pontos negativos**

    - Benefícios de uma tecnologia para o que precisa ser feito
    - Pontos negativos da tecnologia

        - Resolve um problema de escalabilidade, mas tem um custo alto.
        - Tempo de desenvolvimento.
        - A equipe está madura para implementar e manter essa tecnologia?
        - O Domínio de negocio precisa dessa tecnologia?
        - Existem questões legais?

- *Fatores de Decisão*: Inclui o tempo de desenvolvimento, maturidade do time e questões legais.

## O Papel do Arquiteto de Software

- *Decisões de arquitetura*: Para uma equipe ou várias equipes; Produto; Empresa.

- *Visão Macro*: Como os dados são armazenados; Como o sistema se comunica; Estrutura do sistema.

- *Bala de Prata*: 
    
    - Não existe solução para todos os problemas. 
    - Cada produto, negócio, sistema e momento são únicos.
    - Portanto decisões são únicas.

- *Análise de Impacto*: Um mudança em uma camada pode afetar o ecossistema do software.

- *trade-off*: 

    - Tudo em arquitetura é um trade-off.
    - Tempo, time, custos, etc.
    - A ferramenta que resolve é cara.
    - A ferramenta que aumenta a eficiência é difícil de implementar. 
    - Toda arquitetura que parece não ter trade-off é porque não foi identificado.

- *Arquitetura estabelecida*: 

    - É necessário assegurar que a equipe esteja seguindo as decisões de arquitetura e design.
    - Qualquer solução improvisada pode comprometer toda a estrutura do sistema.

## Habilidades Essenciais Além do Técnico

- *Domínio de Negócio*: Conhecimento do negócio é a base para implementação de uma solução sólida.
- *Comunicação e negociação*: Explicação e validação para parte técnica, Stakeholders, Usuários, Clientes, etc.

## Padrões e Características Técnicas

- **Modelos de Arquitetura**: 

    - Arquitetura em camadas.
    - Arquitetura baseada em eventos.
    - Monolito e Monolito distribuído.
    - Arquitetura Servless.
    - Arquitetura Baseada em Nuvem.
    - Arquitetura de Microsserviço.
    - Etc.

- **Escolha do melhor padrão de arquitetura**:

    - **Performance**: Como o sistema utiliza os recursos que tem.
    - **Usabilidade**: Facilidade com que seus usuários podem alcançar seus objetivos.
    - **Confiabilidade**: Disponibilidade; Tolerância a falhas; Como se recupera após uma falha.
    - **Segurança**: Integridade; Confidencialidade dos dados.
    - **Manutenabilidade**: Modularidade; Reutilização desses módulos; Testabilidade.
    - **Escalabilidade**: Crescimento de forma sustentável.
    - Etc.

## Trilha de Estudos para Iniciantes

- Paradigmas de programação.
- Padrões de qualidade de código.
- Princípios de design de código.
- Algoritmos e Estrutura de dados.
- Bancos de dados.
- APIs.
- Cloud.
- Conteinerização.
- Princípios de Devops.

- Padrões de design.
- Refatoração.
- Padrões de arquitetura de Software.
- Domínio de Negócio e Produto.