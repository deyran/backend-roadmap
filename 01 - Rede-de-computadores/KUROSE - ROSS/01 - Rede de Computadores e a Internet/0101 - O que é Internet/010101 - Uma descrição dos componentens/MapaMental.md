# Uma descrição dos componentes - MP

## Definição de Internet

- Rede global de computadores.
- Interconecta centenas de milhões de dispositivos.

## Evolução dos Dispositivos

- Passado (Tradicionais):
    
  - PCs de mesa.
  - Estações de trabalho Linux.
  - Servidores: Armazenam e Transmitem informações (Página web e mensagens web).

- Presente -> Sistemas finais modernos (Equipamentos não tradicionais)
  
  - Entretenimento: TVs, Consoles de jogos.
  - Mobilidade: Laptops, Smartphones, Automóveis.
  - Monitoramento: Webcams, Sensores ambientais.
  - Automação residencial (Domótica): Sistemas elétricos e de segurança.

- Nomenclatura Técnica

- **Hospedeiros (Hosts) ou Sistemas Finais**: Equipamentos ligados a Internet, tradicionais ou não.
- Obs: O termo "rede de computadores" é considerado desatualizado pela diversidade de equipamentos.

## Infraestrutura de Conexão

- Sistemas finais são conectados entre si por *enlaces (links) de comunicação* e *comutadores (switches) de pacotes*.
- Os enlaces podem ser constituído de diversos materiais:
  
  - **Cabeanento**: Cabos Coaxiais, Fios de Cobre e Fibras óticas.
  - **Sem fio (Wireless)**: Ondas de rádio.

- Taxa de transmissão medida em bits por segundo (bps).

## Processo de Transmissão de Dados

- Sistema Final Emissor

  1. **Segmentação**: O dado original é divido em partes menores.
  2. **Encapsulamento**: *Bytes de Cabeçalho* são adicionados a cada segmento.
  3. **Pacote**: O resultado final (Segmento + Cabeçalho) é chamado de pacote.

- Rede: Os pacotes são enviados através da rede.
- Sistema Final de Destino: Os pacotes recebidos são agrupados para restaurar os dados originais.

## Comutação de Pacotes na Internet

- O comutador encaminha pacotes de um enlace de entrada para um de saída.
- Tem por objetivo levar os dados até o destino final.

## Principais Tipos de Comutadores

- Roteadores: São utilizados no Núcleo da Rede.
- Comutadores de camada de enlace: Utilizados em Redes de Acesso.

## O Percurso dos Dados

- Rota ou Caminho: É a sequência completa de enlaces e comutadores entre o remetente (origem) e o receptor (destino).
- Extensão: Vai do sistema final de quem envia até o sistema final de quem recebe.


*************************

## Internet Service Provider - ISP

- Sistemas finais acessam a Internet por meio de ISPs.
- Casa ISP é uma rede de comutadores de pacotes e enlaces de comunicação.
- Tipos de acesso a rede:

  - Acesso residencial de banda larga (Modem a cabo ou DLS).
  - Acesso por LAN de alta velocidade.
  - Acesso sem fio.
  - Acesso por modem discado de 56 kbits/s.
  
- ISPs fornecem acesso a provedores de conteúdo (Google, Youtube, Facebook e etc).
- Existem dois tipos de ISP: 
  
  - Nível mais alto: Roteadores de alta velocidade interconectados com enlaces de fibra ótica de alta velocidade.
  - Nível mais baixo: São interconectados por meio de ISPs de nível mais alto, nacionais e internacionais.

- ISPs (baixo ou alto) são gerenciados de forma independente e executa o protocolo IP.

## Protocolos

- Protocolos são regras que controlam o envio e recebimento de informações.
- Sistemas finais, Comutadores de pacotes, e outras peças da Internet executam protocolos para envio e recebimento de informações.

## Principais protocolos

- IP (Internet Protocol)

  - Especifica o formato dos pacotes.
  - Atua entre roteadores e sistemas finais.

- TCP (Transmission Control Protocol): Controle de transmissão com garantia de entrega.
- HTTP (Hypertext Transfer Protocol): Utilizado para Web.
- SMTP (Simple Mail Transfer Protocol): Utilizado para correio eletrônico (e-mail).

# Rede de Computadores e a Internet
## O que é Internet - Uma descrição dos componentens

### 3. Padronização (O papel das Normas)
* **Objetivo:** Garantir que diferentes sistemas e produtos operem entre si (interoperabilidade).
* **IETF (Internet Engineering Task Force):**
    * Principal órgão de desenvolvimento de padrões da Internet.
* **RFCs (Request For Comments):**
    * Documentos técnicos e detalhados.
    * Existem mais de 6.000 documentos atualmente.

# Rede de Computadores e a Internet
## O que é Internet - Uma descrição dos componentens

### 4. Outros Órgãos Normatizadores
* **IEEE (802 LAN/MAN Standards Committee):**
    * Focado em padrões para enlaces (conexões físicas/locais).
    * **Exemplos:** Ethernet e Wi-Fi.
