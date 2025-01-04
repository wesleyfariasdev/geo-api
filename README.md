# API REST em .NET com PostgreSQL, PostGIS e Docker
Este projeto implementa uma API REST desenvolvida em .NET (C#) com ASP.NET Core. A API gerencia locais geoespaciais, armazenando as informações de localização em um banco de dados PostgreSQL com a extensão PostGIS para dados geoespaciais (SRID 4326).

## Funcionalidades
- Cadastro de locais: Permite cadastrar locais com nome, categoria e coordenadas geográficas (latitude e longitude).
- Listagem de locais: Endpoint para listar todos os locais cadastrados.
- Busca por ID: Endpoint para buscar um local específico pelo seu ID.
- GeoJSON: Endpoint que retorna os locais cadastrados em formato GeoJSON para apresentar as localizações de forma estruturada.
- Atualização e exclusão: Funcionalidades para atualizar e excluir locais.

## Tecnologias
- .NET (C#) com ASP.NET Core: Framework para desenvolvimento da API REST.
- PostgreSQL com PostGIS: Banco de dados relacional com suporte a dados geoespaciais.
- Docker: Containerização da aplicação e do banco de dados PostgreSQL.
- Docker Compose: Orquestração dos containers para facilitar o desenvolvimento e a execução do projeto.

## Como Executar
- Clone este repositório:
```
https://github.com/wesleyfariasdev/geo-api.git
```

- Configure o Docker e Docker Compose (Opcional)
```
Não é necessário configurar o docker-compose ou docker, apenas se tiver conflito de portas
```

- Suba o banco de dados PostgreSQL com PostGIS e .NET utilizando o comando:
```
docker-compose up --build
```

###  A API estará disponível em http://localhost:5000.

