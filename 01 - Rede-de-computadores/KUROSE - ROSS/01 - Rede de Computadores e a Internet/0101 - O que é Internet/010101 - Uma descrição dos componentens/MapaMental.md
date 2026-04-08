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

## Nomenclatura Técnica

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

# Rede de Computadores Kurose - Ross
## Rede de Computadores e a Internet
### Uma descrição dos componentes

1. O que é um ISP?
Definição: Uma rede própria composta por comutadores de pacotes e enlaces de comunicação.
Papel Principal: Atuar como o ponto de acesso para sistemas finais (usuários) e provedores de conteúdo (sites) chegarem à Internet.
Gerenciamento: Cada ISP é independente, mas todos falam a "mesma língua" (Protocolo IP) e seguem regras globais de nomes e endereços.

# Rede de Computadores Kurose - Ross
## Rede de Computadores e a Internet
### Uma descrição dos componentes

2. Tipos de Provedores (Exemplos)
Residenciais: Empresas de telefonia (DSL) ou TV a Cabo.
Corporativos/Acadêmicos: Universidades e empresas.
Acesso Móvel/Público: Wi-Fi em hotéis, cafés e aeroportos.

# Rede de Computadores Kurose - Ross
## Rede de Computadores e a Internet
### Uma descrição dos componentes

3. Tecnologias de Acesso (Como você se conecta)
Banda Larga: Modem a cabo ou DSL.
Redes Locais: LAN de alta velocidade.
Sem Fio: Wi-Fi e redes móveis.
Legado: Modem discado (56 kbits/s).

# Rede de Computadores Kurose - Ross
## Rede de Computadores e a Internet
### Uma descrição dos componentes

4. Hierarquia e Interconexão (A "Rede de Redes")
Nível Inferior (Acesso): São os ISPs locais que você contrata.
Nível Superior (Espinha Dorsal/Backbone): ISPs nacionais e internacionais (ex: AT&T, Sprint, NTT).
Infraestrutura: Roteadores de altíssima velocidade e fibra ótica.
Necessidade: Como a Internet é sobre conectar todos os sistemas finais, os ISPs precisam se interconectar entre si para que um dado saia de uma rede e chegue em outra.
************************



----------------------------------------------------------------------------
## Importância dos protocolos

- Protocolos padronizados e aprovados todos concordam com que ele faz.
- Assim é possível criar sistemas e produtos que operem entre si.
- Padrões da Internet são desenvolvidos pela IETF (Internet Engineering Task Force).
- Documentos padronizados pela IETF são denominados RFCs (Request For Comments).
- RFCs servem para definir e resolver problemas técnicos de arquitetura.
- Alguns protocolos definidos pelas RFCs: TCP, IP, HTTP, SMTP, etc.
- Além da IETF, há outros orgãos que padronizam componentes para Internet.