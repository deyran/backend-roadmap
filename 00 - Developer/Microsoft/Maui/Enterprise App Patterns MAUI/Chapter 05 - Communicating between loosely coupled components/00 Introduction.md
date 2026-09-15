### Publish-Subscribe (Padrão de Mensageria)

- **Messaging pattern**
	- Troca indireta de dados entre componentes ou sistemas.

	- **Uso de um intermediário (Message Broker ou Messenger):**
		- Centraliza e canaliza o tráfego de mensagens.
		- Gerencia as inscrições/registros dos assinantes (subscribers).
		- Isola produtores e consumidores (o emissor não precisa conhecer o receptor).

		- **Messenger (Intermediário In-Memory):**
			- Roda internamente na memória RAM da própria aplicação.
			- Usado em arquiteturas de UI (como .NET MAUI e WPF) para conectar ViewModels e exibições sem acoplamento direto.
			- Exemplo: `WeakReferenceMessenger` (CommunityToolkit.Mvvm).

		- **Message Broker (Intermediário Distribuído):**
			- Roda em um serviço/servidor externo ou na nuvem.
			- Conecta sistemas distribuídos, microsserviços e aplicações distintas.
			- Exemplo: RabbitMQ, Apache Kafka, Azure Service Bus.

	- Promove o desacoplamento fraco (Loose Coupling).
		- Elimina dependências diretas entre classes, módulos ou serviços.
		- Facilita a manutenção, a escrita de testes unitários e a evolução do código.
		- Permite alterar ou substituir um componente sem impactar os demais.

- **Publish (Publicador)**
	- Envia mensagem
	- Não conhece quem recebe.
	- Totalmente independente.
- **Subscriber (Assinante)**
	- Escuta mensagens específicas.
	- Não conhece quem enviou
	- Reage ao conteúdo da mensagem
### Eventos no .NET

- Implementação simples do padrão Pub/Sub.
-  Abordagem mais simples para comunicação entre componentes.
- Indicado quando `loose coupling` não é requerido.
- Exemplo: Comunicação entre um controle (botão) e sua página que o contém.
### Problemas e Riscos dos Eventos no .NET

- **Coupling Lifetime**: Risco alto em cenários com objetos de ciclo de vida misto.
- *Risco no gerenciamento de memória*
	- Em um cenário crítico, objeto de vida curta assina evento de objeto estático ou de vida longa
	- Sem remoção do manipulador (`Event Handler`), o publicador impede a ação do Garbage Collector (GC) sobre o assinante.