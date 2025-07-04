# SGHSS - Sistema de Gestão Hospitalar e de Serviços de Saúde

Este projeto tem como objetivo desenvolver um sistema completo para a gestão hospitalar, incluindo o controle de pacientes, profissionais, prescrições, leitos, e mais. O sistema foi desenvolvido como parte de um projeto acadêmico, utilizando tecnologias modernas e boas práticas de desenvolvimento de software.

## 🚀 Tecnologias Utilizadas

- C#
- ASP.NET Core
- Entity Framework Core
- SQL Server / PostgreSQL
- FastAPI (em fases futuras, se aplicável)
- JWT (autenticação)
- Postman (testes de API)

## 📁 Estrutura do Projeto

```bash
SGHSS/
├── .vs
├── SHGSS
├── Shared
   └──
├── SGHSS.sln
   └──
└── README.md


⚙️ Funcionalidades
 Cadastro e listagem de pacientes

 Autenticação via JWT

 CRUD de profissionais da saúde

 Prescrições médicas

 Controle de leitos

 Agendamentos (em desenvolvimento)

 Dashboard com gráficos (futuro)

📦 Como Rodar o Projeto
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/MicaelAvelar1994/SFHSS-4378289.git
cd SFHSS-4378289
Restaure os pacotes:

bash
Copiar
Editar
dotnet restore
Execute as migrações do banco:

bash
Copiar
Editar
dotnet ef database update
Rode o projeto:

bash
Copiar
Editar
dotnet run
✅ Requisitos
.NET SDK 6.0 ou superior

SQL Server ou PostgreSQL

Postman (para testes)

🔐 Segurança
Autenticação com JWT

Proteção de endpoints com [Authorize]

✍️ Autor
Micael Avelar
GitHub: @MicaelAvelar1994

✅ Conteúdo do README.md
markdown
Copiar
Editar
# SGHSS - Sistema de Gestão Hospitalar e de Serviços de Saúde

O SGHSS é um sistema de gestão hospitalar desenvolvido para facilitar o controle e administração de instituições de saúde, incluindo hospitais, clínicas, laboratórios e equipes de home care.

Este projeto foi desenvolvido como parte de um trabalho acadêmico, com foco em boas práticas de desenvolvimento back-end e segurança de dados conforme a LGPD.

## 🚀 Tecnologias Utilizadas

- C# com .NET 6+
- ASP.NET Core
- Entity Framework Core (EF Core)
- SQL Server ou PostgreSQL
- JWT para autenticação
- Postman para testes de API

## 📁 Estrutura do Projeto

SGHSS/
├── Controllers/
├── Models/
├── Services/
├── DTOs/
├── Migrations/
├── appsettings.json
├── Program.cs
└── README.md

markdown
Copiar
Editar

## ⚙️ Funcionalidades

- [x] Cadastro, edição, listagem e exclusão de Pacientes
- [x] CRUD de Profissionais da Saúde
- [x] Prescrições médicas
- [x] Controle de leitos hospitalares
- [x] Autenticação com JWT
- [ ] Agendamento de consultas e internações (em desenvolvimento)
- [ ] Relatórios e gráficos (em planejamento)

## 🧪 Como Executar o Projeto

1. Clone este repositório:

```bash
git clone https://github.com/MicaelAvelar1994/SFHSS-4378289.git
cd SFHSS-4378289
Restaure os pacotes:

bash
Copiar
Editar
dotnet restore
Atualize o banco de dados:

bash
Copiar
Editar
dotnet ef database update
Execute a aplicação:

bash
Copiar
Editar
dotnet run
🔐 Segurança
Autenticação baseada em JWT

Rotas protegidas com [Authorize]

Dados sensíveis conforme a LGPD

🛠️ Requisitos
.NET SDK 6.0 ou superior

SQL Server ou PostgreSQL instalado

Postman ou Insomnia (para testes de endpoints)

📫 Contato
Micael Avelar
GitHub: @MicaelAvelar1994
