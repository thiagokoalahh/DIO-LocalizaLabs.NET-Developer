# Introdução a APIs

## O que é API?

- Application Program Interface
- Camada que esconde as regras e possibilita uma comunicação externa
- Facilita muito a integração
- Existem várias metodologias (ou arquiteturas), como: SOA, REST, uso por meio de SDK

## Rest / Restful

- Rest: Metodologia / Arquitetura
- Restful: API que faz uso do Rest
- Características:
  - Trafego dos dados por JSON (antigos usam xml)
  - Padronização dos endpoint's
  - Uso de HTTP Methods (Get, Post, Put, Delete)
  - Fácil entendimento ao iniciar uma integração

## HTTP Methods

- Get:
  - Sempre obtém os dados
  - Padrão Rest: /api/dev/user
  - GetByID: /api/dev/user/{id}
- Post:
  - Cria um registro ou recurso
  - /api/dev/user
- Put:
  - Atualiza um registro existente
  - /api/dev/user/{id}
- Delete:
  - Remove um registro existente
  - /api/dev/user/{id}

## Status Codes

- Geralmente:
  - 2xx = Sucesso
  - 4xx = Erro no cliente
  - 5xx = Erro server side
- Status comuns:
  - 200 = OK
  - 401 = Unauthorized
  - 403 = Forbidden
  - 404 = Not Found
  - 500 = Internal server error
  - 504 = Gateway Timeout
