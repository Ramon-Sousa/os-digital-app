# Sistema de gestão de ordens de serviço

Este projeto é um MVP de criação de ordens de serviço para estudos em **.Net 10** e **Blazor Server**. A solução foca em alta performance, usabilidade técnica e conformidade com as evoluções fiscais do mercado brasileiro.

## Stack

- **.NET 10**: Utilização do runtime mais recente para explorar ganhos de performance e novas funcionalidades de linguagem.
- **Blazor Server**: Interface reativa construída com C#, utilizando SignalR para atualizações em tempo real e gerenciamento de estado no servidor.
- **Entity Framework Core**: Camada de abstração de dados para garantir integridade e agilidade nas consultas.
- **SQL Server (Docker)**: Ambiente conteinerizado para persistência de dados, garantindo portabilidade e isolamento da infraestrutura.

## Conceitos de engenharia e design

### Arquitetura de dados e persistência
O sistema utiliza o padrão **Code-First** com Entity Framework Core para a modelagem do domínio. A infraestrutura é provisionada via **Docker**, permitindo que o banco de dados SQL Server 2022 opere de forma isolada e consistente em diferentes ambientes de desenvolvimento (incluindo arquiteturas ARM64/x64).

### Conformidade fiscal (CNPJ 2026)
Uma das prioridades técnicas foi a implementação de suporte ao **CNPJ Alfanumérico**, padrão que entrará em vigor no Brasil em 2026. O sistema utiliza máscaras e validações que suportam caracteres alfanuméricos sem comprometer a integridade dos dados históricos.

### Integração de APIs externas
Implementação de consumo de serviços REST via **HttpClient Factory** para integração com a API do ViaCEP.

## Instruções de configuração

### 1. Banco de dados (Docker)
Suba o container do SQL Server utilizando o comando abaixo:

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SenhaOsDigital123" -p 1433:1433 --name sql_os -d [mcr.microsoft.com/mssql/server:2022-latest](https://mcr.microsoft.com/mssql/server:2022-latest)
```

### 2. Execução da aplicação
A aplicação utiliza o recurso de Hot Reload para agilizar o desenvolvimento:

```bash
dotnet watch run
```

---
Desenvolvido por [Ramon Sousa](https://ramonsousa.com)

