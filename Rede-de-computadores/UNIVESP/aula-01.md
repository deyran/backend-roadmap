# [Introdução às Redes de Computadores](https://youtu.be/1csTmCZj-io?si=WirPF8dRXxcipPit)

## Objetivo da disciplina

1. Aprender os conceitos e aplicação de rede computadores
2. Apresentar os modelos de rede
3. Principios e técnicas
4. Responder: como funciona uma rede de computador?

## O que são redes de computadores?

**Redes de computadores** são sistemas que permitem a comunicação e o compartilhamento de informações entre dispositivos eletrônicos, como computadores, servidores, roteadores e switches. Essas redes podem ser cabeadas (usando cabos) ou sem fio (Wi-Fi), e são essenciais para a troca de dados e recursos em escala global.

## Rede - Componentes

1. Hardware
   
Computadores, smartphones, roteadores, switches, servidores, etc.

2. Software

TCP/IP, OpenFlow, Http, E-mail, Browsers, etc.

3. Rede computadores são formados por hardware e software

## Internet

A **internet** é uma rede global de computadores interconectados. Ela permite a troca de informações, serviços e recursos entre dispositivos em todo o mundo.

## Protocolos de rede

**Protocolos de rede** são como uma linguagem universal que permite que computadores se comuniquem entre si, independentemente das diferenças em seus softwares e hardwares.

*Toda atividade de comunicação na Internet é governada por protocolos*. Aqui estão alguns **protocolos de rede** comuns e suas aplicações:

1. **IP (Internet Protocol)**: Responsável pela elaboração e transporte de pacotes de dados na internet, mas não garante a entrega. O endereço IP determina o destinatário da mensagem.
2. **TCP/IP (Transmission Control Protocol/Internet Protocol)**: Combinação de dois protocolos essenciais para a comunicação na web.
3. **HTTP/HTTPS (Hypertext Transfer Protocol/Secure)**: Usado para transferir páginas da web e recursos associados.
4. **FTP (File Transfer Protocol)**: Facilita a transferência de arquivos entre computadores.
5. **SMTP (Simple Mail Transfer Protocol)**: Envia e-mails.
6. **POP3 (Post Office Protocol version 3)**: Recebe e-mails.
7. **SSH (Secure Shell)**: Permite acesso seguro a servidores remotos.
8. **ICMP (Internet Control Message Protocol)**: Usado para diagnóstico de rede e gerenciamento¹⁴.

Protocolos definem regras que:

1. Estabelecem os formatos e a ordem das mensagens.
2. Definem ações a serem tomadas na transmissão e recepção das mensagens

## Estrutura da Rede

A internet é estruturada da seguinte forma:

1. **Borda da rede**: Aplicações e hospedeiros.
2. **Núcleo da rede**: Roteadores e rede de redes
3. **Redes de acesso, meio físico**: Enlaces de comunicação

### Borda da rede: Serviço orientado a conexão

Serviço orientado a conexão estabelece uma conexão dedicada antes de transferir dados, exemplo TCP (Transmission Control Protocol), que garante a entrega confiável dos dados na ordem correta. Algunas características:

1. **Estabelecimento de conexão**: Processo de handshake
2. **Confiabilidade**: Dados chegam ao destino corretamente
3. **Sequenciamento**: Pacotes recebidos na ordem correta
4. **Controle de fluxo**: Gerencia a quantidade de dados enviados evitando assim congestionamento

#### Aplicações usando TCP

1. HTTP (Hypertext Transfer Protocol).
2. FTP (File Transfer Protocol)
3. SMTP (Simple Mail Transfer Protocol)

### Borda da rede: Serviço Sem Conexão

Serviço Sem Conexão não estabele uma conexão dedicada antes de enviar os dados, exemplo UDP (User Datagram Protocol), que é rápido mas não garante entrega. Algumas características:

1. Estabelecimento de conexão: Dados enviados sem processo de handshake.
2. Menor confiabilidade: Não há garantia que os dados cheguem ao destino.
3. Se sequenciamento: Os pacotes pode chegar fora de ordem.
4. Menor sobrecarga: Menos controle e, portanto, menor latência.

#### Aplicações usando UDP

1. Streaming media: Aplicações de streaming ao vivo, como Twitch e YouTube Live,
2. Jogos Online: Fortnite e League of Legends.
3. VoIP (Voice over IP): Serviços de chamadas de voz pela internet, como Skype e WhatsApp