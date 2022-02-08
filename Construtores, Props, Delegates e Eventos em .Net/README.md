# Construtores, Propriedades, Delegates e Eventos em .NET

## Construtores

- Um construtor é um método especial, que contém o mesmo nome do seu tipo classe.
- Tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instanciação de um objeto.
- Não possui retorno.
- Quando não declarado, é definido um contrutor padrão sem parâmetros.
- Pode ter mais de um construtor.
  
## Get e Set

- O Get e Set serve para que você possa atribuir um valor em uma variável de maneira controlada e com validações.

## Readonly and Const

- O modificador readonly (somente leitura) bloqueia um campo contra alterações que não sejam em sua inicialização ou pelo próprio construtor.
- Uma constante representa um valor que somente pode ser atribuído no momento de sua inicialização, e não pode ser modificado posteriormente.

## Delegates

- Um delegate é uma maneira de passar um método como referência, podendo ser usado como um callback, aceitando qualquer método que contenha a mesma assinatura.
- Os delegados podem ser encadeados juntos; por exemplo, vários métodos podem ser chamados um único evento.
  
## Eventos

- Eventos é um mecanismo de comunicação entre objetos, onde existe um publisher, que realiza o evento e o subscriber, que se inscreve em um evento.
- Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários publicadores.
- Eventos que não têm assinantes nunca são acionados.
