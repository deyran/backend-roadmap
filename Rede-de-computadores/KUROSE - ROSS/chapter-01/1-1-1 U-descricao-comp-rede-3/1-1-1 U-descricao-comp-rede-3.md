# 1.1.1 Uma descrição dos componentes da rede

# Parágrafo 1

> A Internet é uma rede de computadores que interconecta centenas de milhões de dispositivos de computação ao redor do mundo. Há pouco tempo, esses dispositivos eram basicamente PCs de mesa, estações de trabalho Linux, e os assim chamados servidores que armazenam e transmitem informações, como páginas da Web e mensagens de e-mail. No entanto, cada vez mais sistemas finais modernos da Internet, como TVs, laptops, consoles para jogos, telefones celulares, webcams, automóveis, dispositivos de sensoriamento ambiental, quadros de imagens, e sistemas internos elétricos e de segurança, estão sendo conectados à rede. Na verdade, o termo rede de computadores está começando a soar um tanto desatualizado, dados os muitos equipamentos não tradicionais que estão sendo ligados à Internet. No jargão da rede, todos esses equipamentos são denominados hospedeiros ou sistemas finais. Em julho de 2011, havia cerca de 850 milhões de sistemas finais ligados à Internet [ISC, 2012], sem contar os smartphones, laptops e outros dispositivos que são conectados à rede de maneira intermitente. No todo, estima-se que haja 2 bilhões de usuários na Internet [ITU, 2011].

## Resumo

> A internet é uma vasta rede que conecta centenas de milhões de dispositivos ao redor do mundo. Inicialmente. esses dispositivos eram principalmente PCs, estações de trabalho linux e servidores. Atualmente, a rede inclui uma variedade de sistemas modernos, como TVs, laptops, console de jogos, celulares, webcams, automóveis e dispositivos de sensoriamento. Esses dispositivos são chamados hospedeiros ou sistemas finais. Em 2011, havia cerca de 850 milhões de sistemas finais conectados à internet, com uma estimativa de 2 bilhões de usuários no total.

## Pontos importantes

1. **Definição**

A internet é uma rede de computadores que conecta centenas de milhões de dispositivos globalmente.

2. **Dispositivos iniciais**
   
Originalmente, incluia principalmente PCs de mesa, estações de trabalho linux e servidoress   

3. **Dispositivos Modernos** 

Atualmente, a rede abrange TVs, laptops, consoles de jogos, celulares, webcams, automóveis e dispositivos de sensoriamento ambiental.

4. **Terminologia**

Esses dispositivos são chamados de hospedeiros ou sistemas finais.

5. **Estatística de 2011**

Em julho de 2011, havia cerca de 850 milhões de sistemas finais conectados à internet.
   
6. **Usuários totais**

Estima-se que havia 2 bilhões de usuários na Internet em 2011.

## Períodos

### Período 1

> "A Internet é uma rede de computadores que interconecta centenas de milhões de dispositivos de computação ao redor do mundo."

1. O que você quer dizer com interconecta?
  
"Interconexão" implica dizer que a Internet conecta dispositivos entre si, permitindo que se comuniquem e compartilhem informações.

2. Qual a diferença entre "dispositivo de computação" e computadores?
   
*Dispositivo de computação*: É um termo amplo que inclui qualquer dispositivo com capacidade de processar dados, indo além dos computadores tradicionais, tais como: smartphones, tablets, smart TVs, consoles de jogos, dispositivos IoT, etc.

*Computadores*: PCs de mesa, laptops e servidores

Em resumo, todos os computadores são dispositivos de computação, mas nem todos os dispositivos de computação são computadores no sentido tradicional

### Período 2

> Há pouco tempo, esses dispositivos eram basicamente PCs de mesa, estações de trabalho Linux, e os assim chamados servidores que armazenam e transmitem informações, como páginas da Web e mensagens de e-mail. No entanto, cada vez mais sistemas finais modernos da Internet, como TVs, laptops, consoles para jogos, telefones celulares, webcams, automóveis, dispositivos de sensoriamento ambiental, quadros de imagens, e sistemas internos elétricos e de segurança, estão sendo conectados à rede.

* Houve alguma mudança nos dipositivos de armazenamento e transmição de informação?

Dispositivos de armazenamento e transmissão de informação ainda são operados por computadores. A mudança ocorreu nos sistemas finais; hoje, não são apenas os computadores que acessam a Internet, mas qualquer dispositivo eletrônico com capacidade de se conectar à Internet, como TVs, consoles de jogos, etc

### Período 4

> Na verdade, o termo rede de computadores está começando a soar um tanto desatualizado, dados os muitos equipamentos não tradicionais que estão sendo ligados à Internet.

* Como o termo "Rede de computadores" já soa desatualizado, alguém já sugeriu um novo termo?

Embora não seja oficial, termos como **Internet das Coisas (IoT)** e **Redes de Dispositivos** têm sido utilizados tanto na academia quanto na indústria para refletir a nova realidade de dispositivos conectados.

# Parágrafo 2

> Sistemas finais são conectados entre si por enlaces (links) de comunicação e comutadores (switches) de pacotes. Na Seção 1.2, veremos que há muitos tipos de enlaces de comunicação, que são constituídos de diferentes tipos de meios físicos, entre eles cabos coaxiais, fios de cobre, fibras óticas e ondas de rádio. Enlaces diferentes podem transmitir dados em taxas diferentes, sendo a taxa de transmissão de um enlace medida em bits por segundo. Quando um sistema final possui dados para enviar a outro sistema final, o sistema emissor segmenta esses dados e adiciona bytes de cabeçalho a cada segmento. Os pacotes de informações resultantes, conhecidos como pacotes no jargão de rede de computadores, são enviados através da rede ao sistema final de destino, onde são remontados para os dados originais.

# Parágrafo 3

> Um comutador de pacotes encaminha o pacote que está chegando em um de seus enlaces de comunicação de entrada para um de seus enlaces de comunicação de saída. Há comutadores de pacotes de todos os tipos e formas, mas os dois mais proeminentes na Internet de hoje são roteadores e comutadores de camada de enlace. Esses dois tipos de comutadores encaminham pacotes a seus destinos finais. Os comutadores de camada de enlace geralmente são utilizados em redes de acesso, enquanto os roteadores são utilizados principalmente no núcleo da rede. A sequência de enlaces de comunicação e comutadores de pacotes que um pacote percorre desde o sistema final remetente até o sistema final receptor é conhecida como rota ou caminho através da rede. É difícil de estimar a exata quantidade de tráfego na Internet, mas a Cisco [Cisco VNI, 2011] estima que o tráfego global da Internet esteve perto do 40 exabytes por mês em 2012.

# Parágrafo 4

> As redes comutadas por pacotes (que transportam pacotes) são, de muitas maneiras, semelhantes às redes de transporte de rodovias, estradas e cruzamentos (que transportam veículos). Considere, por exemplo, uma fábrica que precise transportar uma quantidade de carga muito grande a algum depósito localizado a milhares de quilômetros. Na fábrica, a carga é dividida e carregada em uma frota de caminhões. Cada caminhão viaja, de modo independente, pela rede de rodovias, estradas e cruzamentos ao depósito de destino. No depósito, a carga é descarregada e agrupada com o resto da carga pertencente à mesma remessa. Deste modo, os pacotes se assemelham aos caminhões, os enlaces de comunicação representam rodovias e estradas, os comutadores de pacote seriam os cruzamentos e cada sistema final se assemelha aos depósitos. Assim como o caminhão faz o percurso pela rede de transporte, o pacote utiliza uma rede de computadores.

# Parágrafo 5

> Sistemas finais acessam a Internet por meio de Provedores de Serviços de Internet (Internet Service Providers — ISPs), entre eles ISPs residenciais como empresas de TV a cabo ou empresas de telefonia; corporativos, de universidades e ISPs que fornecem acesso sem fio em aeroportos, hotéis, cafés e outros locais públicos. Cada ISP é uma rede de comutadores de pacotes e enlaces de comunicação. ISPs oferecem aos sistemas finais uma variedade de tipos de acesso à rede, incluindo acesso residencial de banda larga como modem a cabo ou DSL (linha digital de assinante), acesso por LAN de alta velocidade, acesso sem fio e acesso por modem discado de 56 kbits/s. ISPs também fornecem acesso a provedores de conteúdo, conectando sites diretamente à Internet. Esta se interessa pela conexão entre os sistemas finais, portanto os ISPs que fornecem acesso a esses sistemas também devem se interconectar. Esses
ISPs de nível mais baixo são interconectados por meio de ISPs de nível mais alto, nacionais e internacionais, como Level 3 Communications, AT&T, Sprint e NTT. Um ISP de nível mais alto consiste em roteadores de alta velocidade interconectados com enlaces de fibra ótica de alta velocidade. Cada rede ISP, seja de nível mais alto ou mais baixo, é gerenciada de forma independente, executa o protocolo IP (ver adiante) e obedece a certas convenções de nomeação e endereço. Examinaremos ISPs e sua interconexão mais em detalhes na Seção 1.3.

# Parágrafo 6

> Os sistemas finais, os comutadores de pacotes e outras peças da Internet executam protocolos que controlam o envio e o recebimento de informações. O TCP (Transmission Control Protocol — Protocolo de Controle de Transmissão) e o IP (Internet Protocol — Protocolo da Internet) são dois dos mais importantes da Internet. O protocolo IP especifica o formato dos pacotes que são enviados e recebidos entre roteadores e sistemas finais. Os principais protocolos da Internet são conhecidos como TCP/IP. Começaremos a examinar protocolos neste capítulo de introdução. Mas isso é só um começo — grande parte deste livro trata de protocolos de redes de computadores!

# Parágrafo 7

> Dada a importância de protocolos para a Internet, é adequado que todos concordem sobre o que cada um deles faz, de modo que as pessoas possam criar sistemas e produtos que operem entre si. É aqui que os padrões entram em ação. Padrões da Internet são desenvolvidos pela IETF (Internet Engineering Task Force — Força de Trabalho de Engenharia da Internet) [IETF, 2012]. Os documentos padronizados da IETF são denominados RFCs (Request For Comments — pedido de comentários). Os RFCs começaram como solicitações gerais de comentários (daí o nome) para resolver problemas de arquitetura que a precursora da Internet enfrentava [Allman, 2011]. Os RFCs costumam ser bastante técnicos e detalhados. Definem protocolos como TCP, IP, HTTP (para a Web) e SMTP (para e-mail). Hoje, existem mais de 6.000 RFCs. Outros órgãos também especificam padrões para componentes de rede, principalmente para enlaces. O IEEE 802 LAN/MAN Standards Committee [IEEE 802, 2009], por exemplo, especifica os padrões Ethernet e Wi-Fi sem fio.