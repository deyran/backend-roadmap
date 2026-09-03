### Publish-Subscribe (Padrão de Mensageria)

- **Messaging pattern**
	- Troca indireta de dados.
	- Uso de um intermediário (Message Broker/Messenger).
		- Centraliza e canaliza o tráfego de mensagens.
		- Gerencia as inscrições/registros dos assinantes.
		- Garante a entrega sem expor quem enviou ou que recebe.
		- *Tipos de intermediário*:
			- *Intermediário Doméstico (Messenger / In-Memory)*
				- Roda internamente na RAM do próprio app.
				- Usado no .NET MAUI para conectar ViewModels e telas.
				- Exemplo: WeakReferenceMessenger.
			- *Intermediário Global (Message Broker / Servidor)*
				- Roda externamente em um servidor ou na nuvem.
				- Usados para conectar sistemas distribuídos e microsserviços.
				- Exemplo: RabbitMQ, Apache Kafka, Azure Service Bus.
	- Promove o desacoplamento fraco (Loose Coupling).
		- Elimina dependências diretas entre classes/módulos.
		- Facilita manutenção, testes unitários e evolução.
		- Permite alterar um componente sem quebrar os outros.
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