/* No arquivo README.md há uma orientação de como compilar e executar o código.
Como eu programei a página para ser carregada com foco na área de input, você já pode inserir diretamente o valor desejado, sem usar o mouse. A cada nova inserção, o foco voltará para o input.
Também é possível navegar utilizando tab e teclar enter para inserir o valor de entrada.

Para realizar o teste de funcionamento do código, é necessário copiar as linhas comentadas abaixo e colar na linha 20 do arquivo index.html.

    <h4>Valor a ser adicionado: <input autofocus id="soma"></h4>
    <button id="atualizar-saldo">Atualizar saldo</button>
    <button id="limpar-saldo">Limpar seu saldo</button>
    <h2>Seu saldo é: <span id="campo-saldo"></span></h2>
 */

let botaoAtualizar = document.getElementById('atualizar-saldo');
let botaoLimpar = document.getElementById('limpar-saldo')!; // "!" indica que o campo não é nulo
let soma = document.getElementById('soma')! as HTMLInputElement; // "!" indica que o campo não é nulo
let campoSaldo = document.getElementById('campo-saldo');

let saldoTotal = 0

function apagarInputSoma() {
    soma.value = "";
}

function zerarSaldo() {
    if (campoSaldo) {
        saldoTotal = 0;
        campoSaldo.innerHTML = saldoTotal.toString();
    }
}

zerarSaldo()
function somarAoSaldo(soma: number) {
    if (campoSaldo) {
        saldoTotal += soma
        campoSaldo.innerHTML = saldoTotal.toString();
        apagarInputSoma();
    }
}

if (botaoAtualizar) {
    botaoAtualizar.addEventListener('click', () => {
        somarAoSaldo(Number(soma.value));
        soma.focus();
    });
}
botaoLimpar.addEventListener('click', () => {
    zerarSaldo();
    soma.focus();
})