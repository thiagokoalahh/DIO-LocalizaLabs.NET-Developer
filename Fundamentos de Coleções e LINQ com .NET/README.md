# Fundamentos de Coleções e LINQ com .NET

## Arrays

- O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.
  - Para alterar o tamanho de um array, é necessário criar outro array.
- A posição de um valor em um array é chamado de **Índice**, sempre começando com zero.
  - Item 1 - Índice 0, item 2 - índice 1...
- O array pode ser multidimensional.

### Manipulando Arrays

- A classe Array é uma classe do C# que oferece diversos métodos para trabalhar com arrays.
  - Exemplos: Sort, Copy, Find, IndexOf, Resize...;
- Para ordenar um array, existem diversos algoritmos de ordenação, diferentes técnicas e casos a serem considerados.
  - Algoritmos de sorting: https://visualgo.net/en/sorting
  - Bubblesort
    - É um algoritmo de ordenação dos mais simples. A ideia é percorrer o vector diversas vezes, e a cada passagem fazer flutuar para o topo o maior elemento da sequência.

## Coleções Genéricas

- No C#, existem classes de coleções que agrupam valores, e essas classes são padronizadas para as operações mais comuns, como:
  - Ordenação;
  - Obter valor por índice;
  - Obter valor com expressões;
  - Trabalhar com tamanhos dinâmicos.
    - Diferente de um array, essas coleções não precisam ficar redimensionando sempre que precisar aumentar o tamanho.
- Coleção popular genérica: List.

## Coleções Específicas

- As coleções específicas implementam regras para sua ordem de acesso e manipulação de seus elementos.
  - Queue (Fila):
    - First In First Out;
  - Stack (Pilha):
    - Last In First Out;
  - Dictionary (Dicionário):
    - Um dicionário é uma coleção de chave e valor, permitindo que você recupere rapidamente seus itens baseado em sua chave.
    - O dicionário armazena a sua chave em hash.
  - LINQ (Language-Integrated Query):
    - É uma maneira de utilizar uma sintaxe de consulta padronizada para coleções de objetos, como arrays e lists;
    - Possui duas sintaxes para trabalhar:
      - Query, mais parecida com SQL
      - Method, que é feita a partir de métodos
    - Não há diferença de performance entre Query e Method.
