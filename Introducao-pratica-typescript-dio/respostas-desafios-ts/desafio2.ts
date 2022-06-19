/* No desafio proposto é possível observar diferentes grafias para as palavras "atriz"
e "padeiro", iniciando ora com letra maiúscula, ora com letra minúscula.
É possível contornar esse problema criando um Enum para validar cada profissão. */

enum Profissao {
    Atriz,
    Padeiro
}

type Pessoa = {
    nome: string,
    idade: number,
    profissao: Profissao // A profissão definida no Enum será usada aqui
}

let pessoa1: Pessoa = {
    nome: 'Maria',
    idade: 29,
    profissao: Profissao.Atriz
};

let pessoa2: Pessoa = {
    nome: 'Roberto',
    idade: 19,
    profissao: Profissao.Padeiro
};

let pessoa3: Pessoa = {
    nome: 'Laura',
    idade: 32,
    profissao: Profissao.Atriz
};

let pessoa4: Pessoa = {
    nome: "Carlos",
    idade: 19,
    profissao: Profissao.Padeiro
}