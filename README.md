# Modelando Domínios Ricos com DDD (Domain-Driven Design)

Este projeto exemplifica a prática de **Modelagem de Domínios Ricos** dentro de uma arquitetura de software usando **Domain-Driven Design (DDD)**. A ideia central por trás de um **domínio rico** é garantir que a lógica de negócios e as regras de consistência do sistema sejam encapsuladas dentro do próprio modelo de domínio, em vez de depender de camadas externas ou da infraestrutura.

### O que é um Domínio Rico?

No contexto de DDD, um **domínio rico** é aquele onde as entidades e objetos de valor contêm toda a lógica de negócios necessária para garantir a integridade e as regras de consistência dos dados. Em vez de ser apenas uma estrutura de dados simples (DTO), a entidade ou objeto de valor tem comportamentos próprios que validam e manipulam seus dados.

### Principais Componentes do Domínio Rico:

1. **Entidades**: Representam objetos com identidade própria e são responsáveis por manter a integridade dos dados ao longo do tempo.
2. **Value Objects**: Objetos imutáveis que não possuem identidade própria e representam valores ou conceitos (por exemplo, dinheiro ou endereço).
3. **Exceções de Domínio**: Exceções customizadas que lidam com erros específicos de regras de negócios, garantindo que as regras do domínio sejam mantidas.
4. **Agregados**: Um conjunto de entidades e objetos de valor que são tratados como uma única unidade para garantir a consistência dos dados. O **Aggregate Root** é a entidade principal do agregado.

### Estrutura do Projeto

O projeto foi estruturado de maneira a refletir as práticas de **DDD**, com as seguintes camadas:

- **Domain**: Contém as **Entidades**, **Value Objects**, **Enums**, **Exceptions** e interfaces que definem as operações que podem ser realizadas no domínio.
- **Application**: Contém a lógica de aplicação que interage com o domínio e orquestra operações, como a criação de pedidos e a adição de itens a um pedido.
- **Infrastructure** (não mostrado aqui, mas geralmente conteria implementação de repositórios e persistência de dados).

### Como Rodar o Projeto

Para rodar o projeto em qualquer máquina, siga os passos abaixo:

#### 1. **Instalar o .NET SDK**
Antes de rodar o projeto, você precisa ter o **.NET SDK** instalado em sua máquina.

- Vá até o [site oficial do .NET](https://dotnet.microsoft.com/download) e baixe o SDK mais recente.
- Siga as instruções de instalação para o seu sistema operacional.

#### 2. **Baixar o Projeto**
Se você ainda não tem o código, baixe o repositório ou extraia o arquivo compactado `dominio_rico_com_readme.zip`.

#### 3. **Restaurar Pacotes NuGet**
Dentro da pasta onde você extraiu o projeto (ou onde você baixou o código), abra um terminal ou prompt de comando e execute o comando:

```bash
dotnet restore
```

Esse comando vai restaurar todos os pacotes NuGet necessários para rodar o projeto.

#### 4. **Rodar o Projeto**
Após restaurar os pacotes, você pode rodar o projeto com o comando:

```bash
dotnet run
```

Esse comando irá compilar o código e executá-lo no seu terminal. O programa irá criar um pedido, adicionar itens a ele e confirmar o pedido, exibindo o total do pedido.

Exemplo de saída no terminal:

```
Pedido <GUID> de John Doe foi confirmado.
Valor total: 36.0 USD
```

### Benefícios de Modelar um Domínio Rico

- **Manutenção da Consistência**: Ao manter as regras de negócios dentro do domínio, garantimos que o estado do sistema esteja sempre consistente, independentemente das camadas externas.
- **Foco no Comportamento**: Em vez de termos apenas uma estrutura de dados, nosso modelo de domínio contém comportamentos e validações que refletem as regras de negócios reais.
- **Facilidade de Testes**: Com a lógica de negócios no próprio domínio, podemos escrever testes unitários de maneira mais eficaz, testando diretamente o comportamento das entidades e objetos de valor.
- **Extensibilidade**: A abordagem de **DDD** facilita a adição de novos comportamentos e funcionalidades sem quebrar o sistema, pois as mudanças são isoladas dentro do domínio.

### Conclusão

Modelar um domínio rico é uma das práticas fundamentais do **Domain-Driven Design (DDD)**. Ele permite que a lógica de negócios seja encapsulada nas próprias entidades e objetos de valor, garantindo a consistência e a integridade do sistema. Esse projeto serve como exemplo de como implementar um **domínio rico** com **C#** e **DDD**.