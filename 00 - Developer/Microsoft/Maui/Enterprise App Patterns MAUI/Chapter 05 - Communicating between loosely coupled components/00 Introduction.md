### Publisher-Subscribe (Padrão de Mensageria)

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
- **Publisher (Publicador)**
	- Dispara e envia mensagens para o intermediário.
	- Desconhece a existência dos assinantes (_Subscribers_).
	- Totalmente desacoplado do processamento do receptor.
- **Subscriber (Assinante)**
	- Inscreve-se para receber tipos ou tópicos específicos de mensagens.
	- Desconhece a identidade do emissor (_Publisher_).
	- Processa e reage ao conteúdo da mensagem recebida.
### Eventos no .NET

- Implementação nativa e direta do padrão Observer / Pub-Sub.
- Abordagem simples e leve para comunicação entre componentes em memória.
- Promove o `baixo acoplamento (Loose Coupling) comportamental`, embora ainda exija `referência direta em memória` entre os objetos.
	- **Baixo Acoplamento Comportamental**
		- O Button não sabe o que a MainPage vai fazer quando for clicado, apenas avisa "Fui clicado".
		- O emissor não sabe nem se importa com que trata o evento ou o que será executado.
		- Múltiplos receptores podem escutar o mesmo evento sem alterar o código do emissor.
	- **Referência direta em memória**
		- **Conexão por ponteiro**: A inscrição faz o emissor guardar um `ponteiro direto` para o método do receptor na RAM.
		- **Vínculo de Ciclo de Vida**: Se o receptor não se desinscrever, o Garbage Collector não consegue limpá-lo da memória (Memory Leak).
		- **Dependência de Tipo**: O receptor precisa ter acesso à instância do emissor para conseguir assinar o evento.
- Indicado para cenários intra-aplicação (onde emissor e receptor rodam no mesmo processo).
- Exemplo: Comunicação entre um controle gráfico (botão) e a página/janela que o contém.
