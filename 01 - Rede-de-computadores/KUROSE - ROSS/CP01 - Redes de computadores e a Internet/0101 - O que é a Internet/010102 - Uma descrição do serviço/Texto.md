# O que é a Internet?
## Uma descrição do serviço

A discussão anterior identificou muitos dos componentes que compõem a Internet. Mas também podemos descrevê-la partindo de um ângulo completamente diferente — ou seja, como uma infraestrutura que provê serviços a aplicações. Tais aplicações incluem correio eletrônico, navegação na Web, redes sociais, mensagem instantânea, Voz sobre IP (VoIP), vídeo em tempo real, jogos distribuídos, compartilhamento de arquivos peer-to-peer (P2P), televisão pela Internet, login remoto e muito mais. Essas aplicações são conhecidas como aplicações distribuídas, uma vez que envolvem diversos sistemas finais que trocam informações mutuamente. De forma significativa, as aplicações da Internet são executadas em sistemas finais — e não em comutadores de pacote no núcleo da rede. Embora os comutadores de pacotes facilitem a troca de dados entre os sistemas finais, eles não estão relacionados com a aplicação, que é a origem ou o destino dos dados.

Vamos explorar um pouco mais o significado de uma infraestrutura que fornece serviços a aplicações. Nesse
sentido, suponha que você tenha uma grande ideia para uma aplicação distribuída para a Internet, uma que possa
beneficiar bastante a humanidade ou que simplesmente o enriqueça e o torne famoso. Como transformar essa
ideia em uma aplicação real da Internet? Como as aplicações são executadas em sistemas finais, você precisará
criar programas que sejam executados em sistemas finais. Você poderia, por exemplo, criar seus programas em
Java, C ou Python. Agora, já que você está desenvolvendo uma aplicação distribuída para a Internet, os programas executados em diferentes sistemas finais precisarão enviar dados uns aos outros. E, aqui, chegamos ao assunto principal — o que leva ao modo alternativo de descrever a Internet como uma plataforma para aplicações.
De que modo um programa, executado em um sistema final, orienta a Internet a enviar dados a outro programa
executado em outro sistema final?

Os sistemas finais ligados à Internet oferecem uma Interface de Programação de Aplicação (API) que especifica como o programa que é executado no sistema final solicita à infraestrutura da Internet que envie dados
a um programa de destino específico, executado em outro sistema final. Essa API da Internet é um conjunto de
regras que o software emissor deve cumprir para que a Internet seja capaz de enviar os dados ao programa de
destino. Discutiremos a API da Internet mais detalhadamente no Capítulo 2. Agora, vamos traçar uma simples
comparação, que será utilizada com frequência neste livro. Suponha que Alice queria enviar uma carta para Bob
utilizando o serviço postal. Alice, é claro, não pode apenas escrever a carta (os dados) e atirá-la pela janela. Em vez disso, o serviço postal necessita que ela coloque a carta em um envelope; escreva o nome completo de Bob, endereço e CEP no centro do envelope; feche; coloque um selo no canto superior direito; e, por fim, leve o envelope a uma agência de correio oficial. Dessa maneira, o serviço postal possui sua própria “API de serviço postal”, ou conjunto de regras, que Alice deve cumprir para que sua carta seja entregue a Bob. De um modo semelhante, a Internet possui uma API que o software emissor de dados deve seguir para que a Internet envie os dados para o software receptor.

O serviço postal, claro, fornece mais de um serviço a seus clientes: entrega expressa, aviso de recebimento,
carta simples e muito mais. De modo semelhante, a Internet provê diversos serviços a suas aplicações. Ao desenvolver uma aplicação para a Internet, você também deve escolher um dos serviços que a rede oferece. Uma
descrição dos serviços será apresentada no Capítulo 2.

Acabamos de apresentar duas descrições da Internet: uma delas diz respeito a seus componentes de hardware e software, e a outra, aos serviços que ela oferece a aplicações distribuídas. Mas talvez você ainda esteja confuso sobre o que é a Internet. O que é comutação de pacotes e TCP/IP? O que são roteadores? Que tipos de
enlaces de comunicação estão presentes na Internet? O que é uma aplicação distribuída? Como uma torradeira
ou um sensor de variações meteorológicas podem ser ligados à Internet? Se você está um pouco assustado com
tudo isso agora, não se preocupe — a finalidade deste livro é lhe apresentar os mecanismos da Internet e também
os princípios que determinam como e por que ela funciona. Explicaremos esses termos e questões importantes
nas seções e nos capítulos subsequentes.