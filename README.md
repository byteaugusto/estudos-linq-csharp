# Estudos de LINQ com C#

Projeto de estudos desenvolvido em C# com foco na manipulação e análise de dados utilizando LINQ.

## 🎯 Objetivo

Praticar consultas LINQ para processar pedidos de usuários, calcular indicadores de compras e classificar clientes de acordo com a média de gastos.

## 🛠️ Tecnologias utilizadas

- C#
- .NET
- LINQ
- .NET 10

## 📚 Conceitos praticados

- `SelectMany`: transforma os pedidos de cada usuário em uma única sequência, mantendo a associação com o cliente.
- `GroupBy`: agrupa os pedidos por cliente.
- `Sum`: calcula o total gasto por cliente.
- `Average`: calcula a média de valor por pedido.
- `Count`: contabiliza a quantidade de pedidos.
- `Where`: filtra clientes com total gasto superior a R$ 1.000.
- `OrderByDescending`: ordena os clientes pelo total gasto, do maior para o menor.
- `Select`: projeta os dados para o modelo `ResumoCliente`.
- `ToList`: materializa o resultado em uma lista.

## 🧱 Organização do projeto

- **Program.cs:** contém os dados de exemplo, a consulta LINQ e a exibição dos resultados.
- **Usuario.cs:** define as classes `Usuario` e `Pedidos`.
- **ResumoCliente.cs:** representa o resumo calculado de cada cliente.

## ⚙️ Funcionalidades

- Agrupamento de pedidos por cliente.
- Cálculo do total gasto.
- Cálculo da média por pedido.
- Contagem de pedidos.
- Classificação dos clientes:
  - **Premium:** média igual ou superior a R$ 2.000.
  - **Normal:** média igual ou superior a R$ 1.000 e inferior a R$ 2.000.
  - **Econômico:** média inferior a R$ 1.000.
- Filtro de clientes com total gasto superior a R$ 1.000.
- Ordenação decrescente pelo total gasto.

## ▶️ Exemplo de execução

```text
Nome: Carlos | Total gasto: R$ 8.300,00 | Média por pedido: R$ 2.075,00 | Quantidade de pedidos: 4 | Categoria: Premium
Nome: Lucas | Total gasto: R$ 1.200,00 | Média por pedido: R$ 1.200,00 | Quantidade de pedidos: 1 | Categoria: Normal
```

## 💡 Aprendizados

Este projeto contribuiu para o desenvolvimento de habilidades em consultas LINQ, manipulação de coleções, criação de classes e métodos com retorno tipado, além da organização e legibilidade do código C#.

---

Projeto desenvolvido para fins de estudo e evolução prática em C#/.NET.

## ▶️ Como executar o projeto localmente

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado.
- [Git](https://git-scm.com/downloads) instalado.

### Passo a passo

**1. Clone o repositório**

```bash
git clone https://github.com/byteaugusto/estudos-linq-csharp.git
```

**2. Entre na pasta do projeto**

```bash
cd estudos-linq-csharp
```
**3. Restaure as dependências**

```bash
dotnet restore
```

**4. Execute a aplicação**

```bash
dotnet run
```

O programa exibirá os resumos dos clientes que possuem gastos totais superiores a R$ 1.000, incluindo total gasto, média por pedido, quantidade de pedidos e categoria.

### Resultado esperado

- **Carlos:** total gasto de R$ 8.300,00 — categoria Premium.
- **Lucas:** total gasto de R$ 1.200,00 — categoria Normal.

Os valores são apresentados com base nos dados de exemplo definidos no código.
