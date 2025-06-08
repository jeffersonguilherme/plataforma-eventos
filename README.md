# 🎫 Plataforma de Gestão de Eventos Comunitários

Este projeto é uma API desenvolvida com ASP.NET Core para gerenciamento de eventos comunitários. Ele tem como objetivo permitir a criação, inscrição, controle e acompanhamento de eventos organizados por diferentes perfis de usuários (administradores, organizadores e participantes).

## 🔧 Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server (ou SQLite para dev)
- ASP.NET Identity + JWT (autenticação)
- Swagger (documentação da API)

## 📌 Funcionalidades (MVP - Mínimo Produto Viável)

- CRUD de Eventos
- CRUD de Participantes
- Inscrição de participantes em eventos
- Autenticação e Autorização com perfis de usuário
- Documentação da API com Swagger

## 🚀 Funcionalidades Futuras

- Geração de Incresso com QR Code
- Check-in via QR Code
- Envio de e-mails de confirmação e lembrete
- Geração de certificados em PDF
- Integração com Google Calendar
- Sistema de avaliação de eventos
- Front-end com Blazor ou React
- Integração com sistemas de pagamento (Stripe/PayPal)

## 📅 Entidade: Evento

| Propriedade           | Tipo                        | Descrição                                      |
| --------------------- | --------------------------- | ---------------------------------------------- |
| `Id`                  | `Guid`                      | Identificador único do evento.                 |
| `Titulo`              | `string`                    | Título ou nome do evento.                      |
| `Descricao`           | `string`                    | Descrição detalhada sobre o evento.            |
| `Local`               | `string`                    | Local onde o evento será realizado.            |
| `Tipo`                | `Enum`                      | Tipo do evento (ex: Workshop, Palestra, etc.). |
| `DataDeCriacao`       | `DateTime`                  | Data em que o evento foi criado.               |
| `DataInicioInscricao` | `DateTime`                  | Data de início das inscrições.                 |
| `DataFinalIsncricao`  | `DateTime`                  | Data de término das inscrições.                |
| `Participantes`       | `ICollection<Participante>` | Lista de participantes inscritos no evento.    |

## 👤 Entidade: Participante

| Propriedade                  | Tipo                     | Descrição                                        |
| ---------------------------- | ------------------------ | ------------------------------------------------ |
| `Id`                         | `Guid`                   | Identificador único do participante.             |
| `Name`                       | `string`                 | Primeiro nome do participante.                   |
| `Sobrenome`                  | `string`                 | Sobrenome do participante.                       |
| `Telefone`                   | `string`                 | Número de telefone do participante.              |
| `Email`                      | `string`                 | Endereço de e-mail do participante.              |
| `DataNascimento`             | `DateTime`               | Data de nascimento.                              |
| `Username`                   | `string`                 | Nome de usuário para login.                      |
| `PasswordHash`               | `string`                 | Hash da senha (armazenamento seguro).            |
| `RefreshToken`               | `string`                 | Token de atualização para autenticação contínua. |
| `RefreshTokenExpirationTime` | `DateTime`               | Expiração do refresh token.                      |
| `Inscricoes`                 | `ICollection<Inscricao>` | Lista de inscrições do participante em eventos.  |


## 📝 Entidade: Inscricao

| Propriedade      | Tipo           | Descrição                                                        |
| ---------------- | -------------- | ---------------------------------------------------------------- |
| `Id`             | `Guid`         | Identificador único da inscrição.                                |
| `EventoId`       | `Guid`         | ID do evento relacionado à inscrição (chave estrangeira).        |
| `Evento`         | `Evento`       | Navegação para o evento vinculado.                               |
| `ParticipanteId` | `Guid`         | ID do participante que realizou a inscrição (chave estrangeira). |
| `Participante`   | `Participante` | Navegação para o participante que se inscreveu.                  |
| `DataInscricao`  | `DateTime`     | Data e hora em que a inscrição foi realizada.                    |
