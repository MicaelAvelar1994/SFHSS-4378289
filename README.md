# SGHSS - Sistema de Gestão Hospitalar e de Serviços de Saúde

Este projeto tem como objetivo desenvolver um sistema completo para a gestão hospitalar, incluindo o controle de pacientes, profissionais, prescrições, leitos, e mais. O sistema foi desenvolvido como parte de um projeto acadêmico, utilizando tecnologias modernas e boas práticas de desenvolvimento de software.

## 🚀 Tecnologias Utilizadas

- C#
- Entity Framework Core
- MySQL
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

MySQL instalado

Postman (para testes)

🔐 Segurança
Autenticação com JWT

Proteção de endpoints com [Authorize]

✍️ Autor
Micael Avelar
GitHub: @MicaelAvelar1994
RU 4378289

