# Explorando Sintaxe e Lógica em C\#

## 📌 Introdução

Este projeto foi desenvolvido como parte do **bootcamp da Digital Innovation One (DIO)**, com o objetivo de **praticar conceitos básicos de sintaxe e lógica de programação em C#**.
O desafio consiste em implementar um programa que calcula o valor final de um produto após aplicar um **desconto percentual**, validando os casos de entrada.

## 📑 Sumário

* [Introdução](#-introdução)
* [Funcionalidades](#-funcionalidades)
* [Tecnologias Utilizadas](#-tecnologias-utilizadas)
* [Instalação](#-instalação)
* [Uso](#-uso)
* [Exemplos de Entrada e Saída](#-exemplos-de-entrada-e-saída)
* [Habilidades e Aprendizados](#-habilidades-e-aprendizados)
* [Contribuidores](#-contribuidores)
* [Licença](#-licença)

## ⚙️ Funcionalidades

* Ler o **valor original** de um produto.
* Ler a **porcentagem de desconto**.
* Calcular e exibir o **valor final** do produto.
* Validar descontos inválidos (menores que 0 ou maiores que 100).
* Exibir resultados formatados com **duas casas decimais**.

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET SDK** (versão 6.0 ou superior recomendada)
* IDE recomendada: Visual Studio / Visual Studio Code
* Plataforma de desenvolvimento: **Digital Innovation One (DIO)**

## 📥 Instalação

1. Clone este repositório:

   ```bash
   git clone https://github.com/seu-usuario/explorando-sintaxe-logica-csharp.git
   ```
2. Acesse a pasta do projeto:

   ```bash
   cd explorando-sintaxe-logica-csharp
   ```
3. Compile o projeto:

   ```bash
   dotnet build
   ```

## ▶️ Uso

Para executar o programa, utilize:

```bash
dotnet run
```

O programa irá solicitar a entrada de dois valores:

1. Valor original do produto (double)
2. Porcentagem de desconto (double)

## 📊 Exemplos de Entrada e Saída

| Entrada         | Saída               |
| --------------- | ------------------- |
| `100` <br> `10` | `90.00`             |
| `250` <br> `15` | `212.50`            |
| `80` <br> `5`   | `76.00`             |
| `50` <br> `150` | `Desconto invalido` |

## 🚀 Habilidades e Aprendizados

Durante o desenvolvimento deste projeto, foram aplicados e aprimorados os seguintes conceitos essenciais da programação em **C#**:

* **Estruturas Condicionais (if/else):** Implementação da lógica de verificação da porcentagem de desconto (entre 0 e 100), demonstrando o controle de fluxo do programa.
* **Manipulação de Dados e Tipos:** Conversão de entradas do usuário (strings) para o tipo numérico `double`. Utilização de `double.TryParse()` para garantir segurança contra entradas inválidas.
* **Formatação de Saída:** Exibição do valor final com duas casas decimais utilizando `.ToString("F2")` em conjunto com `CultureInfo.InvariantCulture`, garantindo consistência no formato numérico independentemente das configurações regionais do sistema.
* **Operadores Lógicos e Aritméticos:** Aplicação de operadores como `*`, `/`, `-`, `>=` e `<=` para realizar cálculos e validações.
* **Estrutura de Código em C#:** Prática da estruturação de um programa de console, incluindo a declaração de classes e a utilização do método `Main()`, ponto de entrada de qualquer aplicação C#.

## 👥 Contribuidores

* [**Cleófas Júnior**](https://github.com/cleofasjunior) - Desenvolvimento e documentação
* **Digital Innovation One (DIO)** - Plataforma de aprendizado

## 📄 Licença

Sinta-se livre para usar, modificar e distribuir este código.

---

👉 Você quer que eu inclua também o **código-fonte completo em C#** dentro de uma seção “📂 Código do Projeto” no README, para que qualquer pessoa possa ver de imediato a implementação sem precisar abrir os arquivos?
