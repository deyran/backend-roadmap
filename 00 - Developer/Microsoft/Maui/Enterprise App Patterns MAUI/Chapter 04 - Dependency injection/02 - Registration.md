## Conceito

- Processo de registrar serviços no contêiner de injeção de dependência.
- Deve ser executado uma única vez no início do ciclo de vida do aplicativo.
## Objetivos

- Controlar o ciclo de vida dos objetos.
- Garantir consistência e eficiência no uso de recursos.
## Tipos de registros

- **Singleton** → Criado uma vez, compartilhado por toda a aplicação.
- **Scoped** → Criado uma vez por escopo (Ex.: Requisição HTTP).
- **Transient** → Criado toda vez que é solicitado.

- *Obs* → Um vez que o método `Build (MauiAppBuilder.Build())` é chamado, o container torna-se imutável e não pode ser mas atualizado ou modificado.