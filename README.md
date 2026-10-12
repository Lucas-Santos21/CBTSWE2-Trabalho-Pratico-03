# TP03 - Sistemas Web II

## 📚 Sobre o projeto

Sistema de cadastro e gerenciamento de produtos, desenvolvido como parte do Trabalho Prático 03 da disciplina de Sistemas Web II, utilizando:

- ASP.NET Core MVC
- .NET 10
- Entity Framework Core
- SQLite
- Bootstrap

## 💻 Requisitos

- Visual Studio 2026
- SDK .NET 10

## 🛠️ Executar

1. Abra `TP03Produtos.sln` ou `TP03Produtos.csproj` no Visual Studio.
2. Restaure os pacotes NuGet.
3. Execute o projeto com `Ctrl + F5` ou `F5`.
4. Na primeira execução, crie ou atualize o banco de dados utilizando as migrations do Entity Framework Core:
   ```powershell
   dotnet ef database update
   ```
5. A aplicação utilizará o banco de dados SQLite configurado no projeto para armazenar os produtos.

## 🚀 Funcionalidades

- Cadastro de produtos.
- Listagem dos produtos cadastrados na página inicial.
- Edição de produtos existentes.
- Exclusão de produtos com confirmação.
- Página de detalhes de cada produto.
- Cadastro de produtos com nome, descrição, preço e quantidade em estoque.
- Validação dos campos obrigatórios e dos valores informados.
- Persistência dos dados utilizando Entity Framework Core e SQLite.
- Interface estilizada com Bootstrap.
- Roteamento de URLs para as diferentes ações da aplicação.

## 🏗️ Estrutura principal

- `Models/` — entidade `Produto` e suas regras de validação.
- `Data/` — contexto do Entity Framework Core para acesso ao banco de dados.
- `Controllers/` — controle das requisições HTTP e das operações de gerenciamento de produtos.
- `Views/` — páginas Razor para listagem, cadastro, edição, detalhes e exclusão de produtos.
- `Migrations/` — migrações do Entity Framework Core para criação e atualização da estrutura do banco.
- `wwwroot/` — arquivos CSS, JavaScript e recursos estáticos da aplicação.
- `Program.cs` — configuração dos serviços, do Entity Framework Core e do roteamento.
- `appsettings.json` — configurações da aplicação e conexão com o banco de dados.

## 📦 Entregáveis

- Código-fonte completo da aplicação.
- Vídeo demonstrando o funcionamento do sistema e suas funcionalidades.

## 👥 Autores (Dupla)

- **Lucas Santos** — [GitHub/Lucas-Santos21](https://github.com/Lucas-Santos21)
- **Kaueh Farias** — [GitHub/KauehF](https://github.com/KauehF)

---

**Curso:** Análise e Desenvolvimento de Sistemas – ADS  
**Instituição:** Instituto Federal de São Paulo – IFSP  
**Campus:** Cubatão – SP  
**Disciplina:** Sistemas Web II  
**Trabalho:** Trabalho Prático 03 — Sistema de Gerenciamento de Produtos
