# 1.1.1 Uma descrição dos componentes da rede - Parágrafos 1, 2 e 3

A Internet é uma rede de computadores que interconecta centenas de milhões de dispositivos de computação ao redor do mundo. Há pouco tempo, esses dispositivos eram basicamente PCs de mesa, estações de trabalho Linux, e os assim chamados servidores que armazenam e transmitem informações, como páginas da Web e mensagens de e-mail. No entanto, cada vez mais sistemas finais modernos da Internet, como TVs, laptops, consoles para jogos, telefones celulares, webcams, automóveis, dispositivos de sensoriamento ambiental, quadros de imagens, e sistemas internos elétricos e de segurança, estão sendo conectados à rede. Na verdade, o termo rede de computadores está começando a soar um tanto desatualizado, dados os muitos equipamentos não tradicionais que estão sendo ligados à Internet. No jargão da rede, todos esses equipamentos são denominados hospedeiros ou sistemas finais. Em julho de 2011, havia cerca de 850 milhões de sistemas finais ligados à Internet [ISC,2012], sem contar os smartphones, laptops e outros dispositivos que são conectados à rede de maneira intermitente. No todo, estima-se que haja 2 bilhões de usuários na Internet [ITU, 2011].

Sistemas finais são conectados entre si por enlaces (links) de comunicação e comutadores (switches) de pacotes. Na Seção 1.2, veremos que há muitos tipos de enlaces de comunicação, que são constituídos de diferentes tipos de meios físicos, entre eles cabos coaxiais, fios de cobre, fibras óticas e ondas de rádio. Enlaces diferentes podem transmitir dados em taxas diferentes, sendo a taxa de transmissão de um enlace medida em bits por segundo. Quando um sistema final possui dados para enviar a outro sistema final, o sistema emissor segmenta esses dados e adiciona bytes de cabeçalho a cada segmento. Os pacotes de informações resultantes, conhecidos como pacotes no jargão de rede de computadores, são enviados através da rede ao sistema final de destino, onde são remontados para os dados originais.

Um comutador de pacotes encaminha o pacote que está chegando em um de seus enlaces de comunicação de entrada para um de seus enlaces de comunicação de saída. Há comutadores de pacotes de todos os tipos e formas, mas os dois mais proeminentes na Internet de hoje são roteadores e comutadores de camada de enlace. Esses dois tipos de comutadores encaminham pacotes a seus destinos finais. Os comutadores de camada de enlace geralmente são utilizados em redes de acesso, enquanto os roteadores são utilizados principalmente no núcleo da rede. A sequência de enlaces de comunicação e comutadores de pacotes que um pacote percorre desde o sistema final remetente até o sistema final receptor é conhecida como rota ou caminho através da rede. É difícil de estimar a exata quantidade de tráfego na Internet, mas a Cisco [Cisco VNI, 2011] estima que o tráfego global da Internet esteve perto do 40 exabytes por mês em 2012.

# Dispositivos conectados

A Internet é uma rede de computadores que interconecta dispositivos de computação ao redor do mundo. Exemplos de dispositivos que estão internectados por meio da Internet: Servidores, Tvs, laptops, consoles de jogos, celulares, webcams e sistemas diversos.

Esses dispositivos são chamados Hospedeiros ou Sistemas finais.

# Enlaces de comunicação

Sistemas finais são conectados por enlaces de comunicação, que podem ser cabos coaxiais, fios de cobres, fibras óticas ou ondas de rádio, transmitindo dados em diferentes taxas.

# Pacotes de dados

Dados são segmentados e encapsulados em pacotes com cabeçalhos, enviados através de rede e remontados no destino.

# Comutadores de pacotes

Roteadores e comutadores de camada de enlace encaminham pacotes a seus destinos finais, com roteadores no núcleo da rede e comutadores em redes de acesso.

# Rota ou caminho

A sequência de enlaces e comutadores que um pacote percorre é chamada de rota ou caminho. O tráfego global da Internet foi estimada em 40 exabytes por mês em 2012.