# DevKit.Common

> Um kit de ferramentas para acelerar o desenvolvimento de APIs .NET — com padrões prontos, consistentes e prontos para produção.

## 💡 Sobre o projeto

Desenvolver APIs robustas exige repetir uma série de decisões de arquitetura: como tratar erros sem lançar exceções, como padronizar respostas, como lidar com validações, autenticação, paginação, logs e muito mais.

O **DevKit.Common** nasceu para eliminar esse retrabalho. A ideia é reunir em uma única biblioteca os **blocos de construção fundamentais** que toda API .NET precisa, permitindo que o desenvolvedor foque no que realmente importa: a lógica de negócio.

## 🎯 Objetivo

Ser uma biblioteca de referência para projetos .NET que precisam de:

- ✅ Tratamento de erros padronizado (sem exceções para fluxos de negócio)
- ✅ Respostas de API consistentes
- ✅ Erros de domínio organizados e reutilizáveis
- ✅ Utilitários comuns prontos para uso (em breve)
- ✅ Facilitadores para autenticação e autorização (em breve)
- ✅ Helpers de validação e paginação (em breve)

## 🚀 Tecnologias

- [.NET 10](https://dotnet.microsoft.com/)
- C# com Nullable Reference Types habilitado

## 📦 O que já tem

### Result Pattern

Permite que operações retornem **sucesso ou falha de forma explícita**, sem depender de exceções para controle de fluxo.

```csharp
// Sucesso
Result<User> result = Result<User>.Success(user);

// Falha
Result<User> result = Result<User>.Failure(UserErrors.UserNotFound);

// Verificando
if (result.IsFailure)
    return BadRequest(result.Error.Message);

return Ok(result.Value);
```

### Erros predefinidos

Erros organizados por domínio, com código e mensagem padronizados.

```csharp
AuthErrors.InvalidCredentials   // AUTH.INVALID_CREDENTIALS
AuthErrors.TokenExpired         // AUTH.TOKEN_EXPIRED

UserErrors.UserNotFound         // USER.NOT_FOUND
UserErrors.EmailAlreadyExists   // USER.EMAIL_EXISTS

CommonErrors.NotFound           // COMMON.NOT_FOUND
CommonErrors.Unauthorized       // COMMON.UNAUTHORIZED
```

## 🗺️ Roadmap

- [ ] Paginação genérica (`PagedResult<T>`)
- [ ] Middleware de tratamento global de erros
- [ ] Extensions para `IServiceCollection`
- [ ] Helpers de validação com FluentValidation
- [ ] Utilitários para autenticação JWT
- [ ] Documentação detalhada por módulo

## 📄 Licença

Este projeto está sob a licença MIT.
