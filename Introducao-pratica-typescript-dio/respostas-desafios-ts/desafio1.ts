/* Para evitar erros no código, foi inserida uma tipagem explícita para code (number)
e para name (string), sendo agora necessário respeitar o tipo durante a criação do objeto. */

const employee: {code: number, name: string} = {
  code: 10,
  name: 'John'
}