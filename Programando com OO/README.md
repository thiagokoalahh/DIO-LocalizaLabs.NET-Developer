# Programando com Orientação a Objetos

## Os Quatro Pilares de OO

### Abstração

- Pilar responsável pela abstração de objetos do mundo real, considerando apenas características que sejam úteis para um fim específico.

### Encapsulamento

- O encapsulamento tem a função de definir limites de alteração dos membros de uma classe. Oculta comportamentos internos e mostra apenas o necessário.
- Modificadores de acesso:
  - Public: acesso total;
  - Protected: acesso em classes filhas, através da herança;
  - Internal: acesso apenas dentro do mesmo assembly;
  - Protected Internal: apenas classes não derivadas de assembly diferentes não tem acesso;
  - Private: apenas dentro da própria classe;
  - Private Protected: acesso em classes filhas somente no mesmo assembly.

### Herança

- A herança permite a reutilização de atributos, métodos e comportamentos de uma classe em outras classes;
- A classe superior permite o agrupamento de classes derivadas, sendo uma generalização;
- Já uma classe derivada, costuma ser uma especialização da classe herdada.

### Polimorfismo

- O polimorfismo permite sobrescrever métodos, possibilitando uma melhor implementação/especialização do método.
  - Override: sobrescrita de métodos em classes derivadas.
  - Overload: sobrecarga de métodos, permite a utilização de um método com o mesmo nome, mas com diferentes parâmetros.

## Outros tipos de Classes

### Classe Abstrata

- Fortemente ligada a herança, pois seu objetivo é ser um modelo de classe para ser herdado.
- Não pode ser instanciada.
- Pode implementar métodos normalmente ou de forma abstrata.
  - Quando de forma abstrata, a classe que a herdou fica responsável pela implementação.
  
### Classe Selada

- Ao contrário das classes abstratas a classe selada não pode derivar nenhuma outra classe.
- Ponto final de uma árvore de heranças.
- Também existem métodos e propriedades seladas:
  - Ocorre quando a classe não é selada, apenas métodos e propriedades selados.
  - Significa que estes não podem sofrer polimorfismo, ou seja, devem ser usados da mesma forma de onde foram selados.

### Classe Object

- System.Object é a classe mãe de todas as classes na hierarquia .NET.
- Todas as classes derivam de *object*, direta ou indiretamente.
- Tem como objetivo fornecer serviços de baixo nível para classes derivadas.

### Interfaces

- Uma interface é um contrato que pode ser implementado por uma classe.
- Não pode ser instanciada.
- Assim como uma classe abstrata, a interface pode definir métodos abstratos para serem implementados.
  - A partir do .NetCore 3, interfaces podem implementar métodos padrão.

## Trabalhando com Arquivos

### File

- Fornece métodos estáticos para a criação, cópia, exclusão, deslocamento e abertura de um arquivo.

### Directory

- Expõe métodos estáticos para criar, mover e enumerar em diretórios e subdiretórios.
- Essa classe não pode ser herdada.

### Path

- Executa operações em instâncias de string que contêm informações de caminho de arquivo ou diretório.
