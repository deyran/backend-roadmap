## Sem MVVM

- **Gatilho**: Invocado em resposta a uma ação do usuário (ex: clique de um botão)
- **Implementação**: Feita através de um manipulador de eventos (event handler)
- **Localização**: Código de suporte (Code-behind)

## Padrão MVVM

- **Regra de ouro**: Evitar código estrutural no *Code-behind*
- **Responsabilidade**: A lógica de ação deve residir estritamente na *View Model*
- **Benefício Principal**: Desacoplamento entre lógica da ação e a representação visual
- **Portabilidade**: Facilita levar as *View Models* para novas plataformas, pois remove a dependência direta dos eventos de UI específicos do framework

## Elementos de conexão (UI → View Model)

- Para conectar a View à View Model sem quebrar o padrão, utiliza-se duas ferramentas: **Commands** e **Behaviors**

- **Commands**

	1. Representa ações que podem ser vinculadas (bound) a controles UI.
	2. **Encapsulamento**: Guardam código de ação, mantendo-o isolado da parte visual.
	3. **Suporte Nativo**: O .Net Maui possui controles que se conectam declarativamente a um comando e o invocam automaticamente na interação do usuário

- **Behaviors**

	1. São extensões que também permitem conectar controles a comandos de forma declarativa

	2. **Vantagem sobre Commands**: Podem invocar ações associadas a uma ampla gama de eventos gerados por controle, não apenas o clique padrão

	3. **Flexibilidade**: Maior controle e flexibilidade que os comandos nativos.

	4. **Compatibilidade**: Permitem associar comandos ou métodos a controles que não foram originalmente projetados para interagir com comandos

