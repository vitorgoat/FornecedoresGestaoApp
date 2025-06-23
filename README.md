# FornecedoresGestaoApp

Trata-se de uma aplicação desktop desenvolvida em C# (.NET 8, WinForms, MySql), projetada para cadastro, consulta, edição e exclusão de fornecedores.

O sistema permite consultar via API CNPJ`S existentes e validos e gerenciar informações detalhadas dos fornecedores, como razão social, CNPJ, endereço, telefone, e-mail e nome do responsável.

## Arquitetura
O projeto segue os princípios da Clean Architecture, inspirado em conceitos da Onion Architecture e na estruturação proposta pelo Domain-Driven Design (DDD), além de aplicar os princípios SOLID.

- App.Domain
Contém as entidades de domínio (Fornecedor) e as interfaces de repositório (IFornecedorRepository).
Responsável por regras de negócio e contratos, independente de UI ou infraestrutura.

- App.Infrastructure
Implementa a persistência de dados (FornecedorRepository) usando MySQL.
Depende apenas dos contratos definidos no Domain.

- App.Application
Contém os serviços de aplicação (FornecedorService, CnpjApiService).
Faz a orquestração das regras de negócio e integrações externas, sem depender de infraestrutura ou UI.

- App.WinForms
Responsável pela interface gráfica com o usuário, utilizando WinForms.

## Funcionalidades
- Cadastro de novos fornecedores

- Edição e exclusão de fornecedores existentes

- Consulta de fornecedores por CNPJ

- Visualização de todos os fornecedores em uma lista

- Interface intuitiva e fácil de usar
#
⚙️ Como configurar o projeto?
1. Pré-requisitos:
- .NET 8 SDK instalado.
- MySQL Server instalado e em execução.

3. Configuração do Banco de Dados:
```
-- Crie a base de dados:

CREATE DATABASE IF NOT EXISTS fornecedoresdb;

-- Selecione a base:

USE fornecedoresdb;

-- Crie a tabela de Fornecedores:

CREATE TABLE IF NOT EXISTS fornecedores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    razao_social VARCHAR(100) NOT NULL,
    cnpj VARCHAR(20) NOT NULL UNIQUE,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(10) NOT NULL,
    telefone VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    nome_responsavel VARCHAR(100) NOT NULL
);
```

Ajuste o usuário no campo (SEU_USUARIO) e senha no campo (SUA_SENHA) de acesso ao MySQL no arquivo:
App.WinForms\App.config
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<connectionStrings>
		<add name="MySqlConnection"
			 connectionString="Server=localhost;Database=fornecedoresdb;Uid=SEU_USUARIO;Pwd=SUA_SENHA;"
			 providerName="MySql.Data.MySqlClient" />
	</connectionStrings>
</configuration>
```

3. Executando o Projeto:
   
Abra a solução no Visual Studio 2022 ou superior
Restaure os pacotes NuGet (caso não sejam restaurados automaticamente)
Compile e execute, o projeto de inicializacao deve ser (App.WinForms)

📷 Screenshots
#
Tela Inicial:

![image](https://github.com/user-attachments/assets/109bc8d2-c9ea-4157-8738-873a7cde9f37)
#

Tela Novo Fornecedor:

![image](https://github.com/user-attachments/assets/09d9992d-07f1-453c-8303-63bb02554528)
#

Tela de Grid/Listagem de Fornecedores:

![image](https://github.com/user-attachments/assets/87a28bc4-9c29-462a-81d7-23f0819868ec)
#

## Vídeo

O vídeo de demonstração está disponível na plataforma Vimeo:

[![Assista ao vídeo](https://img.shields.io/badge/Vimeo-Assista%20ao%20vídeo-blue?logo=vimeo)](https://vimeo.com/1095475240/28e630bb50?share=copy)





