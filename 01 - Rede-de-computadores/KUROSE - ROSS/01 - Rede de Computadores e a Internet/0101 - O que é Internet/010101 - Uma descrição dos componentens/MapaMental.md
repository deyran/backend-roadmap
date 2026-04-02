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







----------------------------------------------------------------------------
## Importância dos protocolos

- Protocolos padronizados e aprovados todos concordam com que ele faz.
- Assim é possível criar sistemas e produtos que operem entre si.
- Padrões da Internet são desenvolvidos pela IETF (Internet Engineering Task Force).
- Documentos padronizados pela IETF são denominados RFCs (Request For Comments).
- RFCs servem para definir e resolver problemas técnicos de arquitetura.
- Alguns protocolos definidos pelas RFCs: TCP, IP, HTTP, SMTP, etc.
- Além da IETF, há outros orgãos que padronizam componentes para Internet.