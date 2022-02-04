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
