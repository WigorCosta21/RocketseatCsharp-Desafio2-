# Gerenciador de Tarefas - API

Este projeto é uma API para um sistema de gerenciamento de tarefas, permitindo que os usuários criem, visualizem, editem e excluam tarefas.

## Funcionalidades

- Criar uma tarefa
- Visualizar todas as tarefas
- Visualizar uma tarefa pelo ID
- Editar uma tarefa
- Excluir uma tarefa

## Estrutura do Projeto

A aplicação foi dividida em camadas para manter uma arquitetura organizada:

- **Camada de Comunicação**: Responsável por receber e responder às requisições HTTP.
- **Camada de Regras de Negócio**: Onde estão as lógicas de validação e manipulação de dados.

## Modelos de Dados

### Tarefa (`TaskItem`)

- **Id**: Identificador único
- **Nome**: Nome da tarefa
- **Descrição**: Detalhes da tarefa
- **Prioridade**: Pode ser `Low`, `Medium` ou `High`
- **Data Limite**: Data até a qual a tarefa deve ser concluída
- **Status**: Pode ser `Pending`, `InProgress` ou `Completed`

## Endpoints

### Criar uma Tarefa

```
POST /api/task
```

**Request Body:**

```json
{
  "id": 1,
  "name": "Nome da Tarefa",
  "description": "Descrição da tarefa",
  "priority": "Medium",
  "dateline": "2025-03-30T23:59:59",
  "status": "Pending"
}
```

**Response:**

```json
{
  "id": 1,
  "name": "Nome da Tarefa",
  "description": "Descrição da tarefa",
  "priority": "Medium",
  "dateline": "2025-03-30T23:59:59",
  "status": "Pending"
}
```

### Visualizar Todas as Tarefas

```
GET /api/task
```

**Response:**

```json
[
  {
    "id": 1,
    "name": "Nome da Tarefa",
    "description": "Descrição da tarefa",
    "priority": "Medium",
    "dateline": "2025-03-30T23:59:59",
    "status": "Pending"
  }
]
```

### Visualizar Tarefa por ID

```
GET /api/task/{id}
```

**Response:**

```json
{
  "id": 1,
  "name": "Nome da Tarefa",
  "description": "Descrição da tarefa",
  "priority": "Medium",
  "dateline": "2025-03-30T23:59:59",
  "status": "Pending"
}
```

### Atualizar Tarefa

```
PUT /api/task/{id}
```

**Request Body:**

```json
{
  "name": "Nome Atualizado",
  "description": "Descrição Atualizada",
  "priority": "High",
  "dateline": "2025-04-05T23:59:59",
  "status": "InProgress"
}
```

**Response:**

```json
{
  "id": 1,
  "name": "Nome Atualizado",
  "description": "Descrição Atualizada",
  "priority": "High",
  "dateline": "2025-04-05T23:59:59",
  "status": "InProgress"
}
```

### Excluir Tarefa

```
DELETE /api/task/{id}
```

**Response:**

```json
{
  "id": 1
}
```

## Como Executar o Projeto

1. Clone o repositório:

```
git clone https://github.com/seu-usuario/todo-list-api.git
```

2. Navegue até o diretório do projeto:

```
cd todo-list-api
```

3. Execute a aplicação:

```
dotnet run
```

## Considerações Finais

Este projeto foi desenvolvido para fins educacionais e pode ser expandido para incluir autenticação, persistência em banco de dados e outras funcionalidades.

Contribuições e sugestões são bem-vindas!

---

**Desenvolvido por:** [Wigor]
