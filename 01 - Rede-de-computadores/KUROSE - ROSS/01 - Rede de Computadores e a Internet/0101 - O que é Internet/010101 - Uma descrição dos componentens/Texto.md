# Uma descrição dos componentes

A Internet é uma rede de computadores que interconecta centenas de milhões de dispositivos de computação ao redor do mundo. Há pouco tempo, esses dispositivos eram basicamente PCs de mesa, estações de trabalho Linux, e os assim chamados servidores que armazenam e transmitem informações, como páginas da Web e mensagens de e-mail. No entanto, cada vez mais sistemas finais modernos da Internet, como TVs, laptops, consoles para jogos, telefones celulares, webcams, automóveis, dispositivos de sensoriamento ambiental, quadros de imagens, e sistemas internos elétricos e de segurança, estão sendo conectados à rede. Na verdade, o termo rede de computadores está começando a soar um tanto desatualizado, dados os muitos equipamentos não tradicionais que estão sendo ligados à Internet. No jargão da rede, todos esses equipamentos são denominados hospedeiros ou sistemas finais. Em julho de 2011, havia cerca de 850 milhões de sistemas finais ligados à Internet [ISC, 2012], sem contar os smartphones, laptops e outros dispositivos que são conectados à rede de maneira intermitente. No todo, estima-se que haja 2 bilhões de usuários na Internet [ITU, 2011].

Sistemas finais são conectados entre si por enlaces (links) de comunicação e comutadores (switches) de pacotes. Na Seção 1.2 , veremos que há muitos tipos de enlaces de comunicação, que são constituídos de diferentes tipos de meios físicos, entre eles cabos coaxiais, fios de cobre, fibras óticas e ondas de rádio. Enlaces diferentes podem transmitir dados em taxas diferentes, sendo a taxa de transmissão de um enlace medida em bits por segundo. Quando um sistema final possui dados para enviar a outro sistema final, o sistema emissor segmenta esses dados e adiciona bytes de cabeçalho a cada segmento. Os pacotes de informações resultantes, conhecidos como pacotes no jargão de rede de computadores, são enviados através da rede ao sistema final de destino, onde são remontados para os dados originais.


------------------------------------------------
Um comutador de pacotes encaminha o pacote que está chegando em um de seus enlaces de comunicação de entrada para um de seus enlaces de comunicação de saída. Há comutadores de pacotes de todos os tipos e formas, mas os dois mais proeminentes na Internet de hoje são roteadores e comutadores de camada de enlace. Esses dois tipos de comutadores encaminham pacotes a seus destinos finais. Os comutadores de camada de enlace geralmente são utilizados em redes de acesso, enquanto os roteadores são utilizados principalmente no núcleo da rede. 


A sequência de enlaces de comunicação e comutadores de pacotes que um pacote percorre desde o sistema final remetente até o sistema final receptor é conhecida como rota ou caminho através da rede. 


É difícil de estimar a exata quantidade de tráfego na Internet, mas a Cisco [Cisco VNI, 2011] estima que o tráfego global da Internet esteve perto do 40 exabytes por mês em 2012.
------------------------------------------------





Dada a importância de protocolos para a Internet, é adequado que todos concordem sobre o que cada um deles faz, de modo que as pessoas possam criar sistemas e produtos que operem entre si.É aqui que os padrões entram em ação. Padrões da Internet são desenvolvidos pela IETF (Internet Engineering Task Force — Força de Trabalho de Engenharia da Internet) [IETF, 2012]. Os documentos padronizados da IETF são denominados RFCs (Request For Comments — pedido de comentários).Os RFCs começaram como solicitações gerais de comentários (daí o nome) para resolver problemas de arquitetura que a precursora da Internet enfrentava [Allman, 2011]. Os RFCs costumam ser bastante técnicos e detalhados. Definem protocolos como TCP, IP, HTTP (para a Web) e SMTP (para e-mail). Hoje, existem mais de 6.000 RFCs. Outros órgãos também especificam padrões para componentes de rede, principalmente para enlaces. O IEEE 802 LAN/MAN Standards Committee [IEEE 802, 2009], por exemplo, especifica os padrões Ethernet e Wi-Fi sem fio.