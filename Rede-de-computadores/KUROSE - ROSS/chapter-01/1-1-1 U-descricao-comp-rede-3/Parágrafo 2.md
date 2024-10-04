# 1.1.1 Uma descrição dos componentes da rede - Parágrafo 2

> Sistemas finais são conectados entre si por enlaces (links) de comunicação e comutadores (switches) de pacotes. Na Seção 1.2, veremos que há muitos tipos de enlaces de comunicação, que são constituídos de diferentes tipos de meios físicos, entre eles cabos coaxiais, fios de cobre, fibras óticas e ondas de rádio. Enlaces diferentes podem transmitir dados em taxas diferentes, sendo a taxa de transmissão de um enlace medida em bits por segundo. Quando um sistema final possui dados para enviar a outro sistema final, o sistema emissor segmenta esses dados e adiciona bytes de cabeçalho a cada segmento. Os pacotes de informações resultantes, conhecidos como pacotes no jargão de rede de computadores, são enviados através da rede ao sistema final de destino, onde são remontados para os dados originais.

# Resumo

> Os sistemas finais são interconectados por enlaces de comunicação e comutadores de pacotes. Existem diversos tipos de enlaces (cabos coaxiais, fiba óticas, ondas de rádio, etc), cada um com diferentes taxas de transmissão. Quando um sistema final envia dados a outro, ele segmenta os dados e adiciona cabeçalhos, formando pacotes. Esses pacotes são transmitidos pela rede e remontados no destino para recuperar os dados originais.

# Pontos importantes

## Conexão se Sistemas Finais

Sistemas finais são conectados por **enlaces de comunicação** e **comutadores de pacotes**.

1. O que são "enlaces de comunicação"?

Enlaces de comunicação são conexões que permitem a transmissão de dados entre dois ou mais pontos

2. O que são "comutadores de pacotes"?

Comutadores de pacotes (switches) são dispositivos que encaminham pacotes de dados entre dispositivos, isto é, recebem pacotes de dados de sistemas finais de origem e os direcionam para o sistema final de destino.

3. Por quê se diz que Sistemas finais são conectados por enlaces de comunicação e comutadores de pacotes?

Porque os enlaces de comunicação fornecem os meios físicos e lógicos para transmitir os dados entre os sistemas finais. Já os comutadores gerenciam e direcionam os pacotes de dados através da rede, garantindo a chegada dos mesmos de forma correta e eficiente.

## Tipos de Enlaces

Existem vários tipos de enlaces de comunicação, como cabos coaxiais, fios de cobre, fibra ótica e ondas de rádio.

## Taxas de transmissão

"Diferentes enlaces podem transmitir dados em diferentes taxas, medidas em bits por segundo (bps)"

*Porquê diferentes enlaces podem transmitir dados em diferentes taxas?*

Existem vários fatores para diferentes taxas de transmissão de dados, entre eles:

1. *Tipo de meio físico:*

Por exemplo, cabos coaxiais têm taxas de transmissão mais baixas comparadas às fibras óticas.

2. *Tecnologia de transmissão:*

Por exemplo, DSL (Digital Subscriber Line) usa fios de cobre.

3. *Interferência e ruído*

Enlaces que utilizam ondas de rádio podem ser mais suscetíveis a interferências e ruídos, o que pode reduzir a taxa de transmissão.
   
4. *Largura de banda*
   
- Largura de banda refere-se a quantidade de dados que podem ser transmitidos por um enlace em um determinado período de tempo. 
- A largura de banda é medida em bits por sengundo (bps).
- A taxa de largura de banda pode variar dependendo do tipo de meio físico, por exemplo, fibras óticas geralmente têm largura de banda maio do que cabos de cobre.   

## Envio de dados

O sistema emissor segmenta os dados e adiciona cabeçalhos a cada segmento.

- Por que os dados têm que ser segmentados?

Os dados são segmentados pelas seguintes razões:

1. Facilitar a transmissão pela rede.
2. Permitir o envio de forma eficiente e confiável.
3. Evitar congestionamento na rede.
4. Facilitar a detecção e correção de erros.
5. Evitar retransmissões desnecessárias em caso de falhas

## Pacotes de informação

Os segmentos formam pacotes, que são enviados pela rede ao sistema final de destino.

## Remotagem dos dados

No destino, os pacotes são remontados para recuperar os dados originais.