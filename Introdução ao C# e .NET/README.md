# Introdução ao C# e .NET

## Namespaces

Organizador/Container de classes.

- Para uma classe poder ser acessada em outro local, é preciso primeiro chamar o namespace que contém determina classe usando *using* ou colocando diretamente o namespace junto com a classe;
  - ```using System;```;
  - ```System.Console.WriteLine("HelloWorld");```;
  
- Um **namespace** não pode conter duas classes com o mesmo nome.
  - Mesmo utilizando namespaces diferentes, é uma boa prática não usar o mesmo nome de classe em mais de um namespace.

## Classes

Conjunto de características e comportamentos que definem o conjunto de objetos pertencentes à essa classe.

- Possui campos, propriedades, métodos e eventos dentro dela que são chamados de membros;
- Instância de uma classe é chamada de objeto:
  - Um objeto tem as características da classe a qual pertence, porém cada objeto tem seu próprio conjunto de valores que o define.
  
## Interface

Uma interface serve como molde para várias classes, estabelecendo uma espécie de contrato que a classe deve cumprir.

- Boa prática começar toda interface com a letra I na frente do nome:
  - ```interface IPessoa```.
  
- Classes que possuem *interfaces* devem implementar todos os membros que a interface possui.

## Enum

Declara um conjunto de constantes nomeadas que começam com o índice 0 e aumentam de 1 em 1.

## Debugging

Ferramenta utilizada para resolver problemas no código.

- Permite uma análise em tempo real do código, passo a passo, ajudando o desenvolvedor a entender o que aconteceu de errado.
- Pode ser feito utilizando Breakpoint, um marcador de parada na linha desejada.
