const formularioEntradaUrgente = document.getElementById('formulario-entrada-urgente');
const formularioEntradaImportante = document.getElementById('formulario-entrada-importante');
const listaTarefasUrgentes = document.getElementById('lista-tarefas-urgentes');
const listaTarefasImportantes = document.getElementById('lista-tarefas-importantes');

formularioEntradaUrgente.onsubmit = function (urgente) {
	urgente.preventDefault();
	const campoTarefaUrgente = document.getElementById('entrada-urgente');
	InserirTarefaUrgente(campoTarefaUrgente.value);
	formularioEntradaUrgente.reset();
};

formularioEntradaImportante.onsubmit = function (importante) {
	importante.preventDefault();
	const campoTarefaImportante = document.getElementById('entrada-importante');
	InserirTarefaImportante(campoTarefaImportante.value);
	formularioEntradaImportante.reset();
};

function InserirTarefaUrgente(inserirTarefaUrgente) {
	const EntradaObrigatoriaUrgente = document.getElementById('entrada-urgente');
	const corBotaoUrgente = document.getElementById('botao-urgente');
	if (inserirTarefaUrgente === ""){
		EntradaObrigatoriaUrgente.placeholder="Entrada obrigatória!";
		EntradaObrigatoriaUrgente.style.borderColor = "#e70202";
		corBotaoUrgente.style.borderColor = "#e70202";
		corBotaoUrgente.style.backgroundColor = "#e70202";
		EntradaObrigatoriaUrgente.focus();
		return
	}
	EntradaObrigatoriaUrgente.placeholder="Escreva sua tarefa";
	EntradaObrigatoriaUrgente.style.borderColor = "#B1D34B";
	corBotaoUrgente.style.borderColor = "#F47920";
	corBotaoUrgente.style.backgroundColor = "#F47920";
	const taskContainerUrgente = document.createElement('div');
	const novaTarefaUrgente = document.createElement('input');
	const checkTarefaUrgente = document.createElement('marcador-urgente');
	const taskDescriptionNodeUrgente = document.createTextNode(inserirTarefaUrgente);

	novaTarefaUrgente.setAttribute('type', 'checkbox');
	novaTarefaUrgente.setAttribute('name', inserirTarefaUrgente);
	novaTarefaUrgente.setAttribute('id', inserirTarefaUrgente);

	checkTarefaUrgente.setAttribute('for', inserirTarefaUrgente);
	checkTarefaUrgente.appendChild(taskDescriptionNodeUrgente);

	taskContainerUrgente.classList.add('tarefa-urgente');
	taskContainerUrgente.appendChild(novaTarefaUrgente);
	taskContainerUrgente.appendChild(checkTarefaUrgente);

	listaTarefasUrgentes.appendChild(taskContainerUrgente);
}


function InserirTarefaImportante(inserirTarefaImportante) {
	const EntradaObrigatoriaImportante = document.getElementById('entrada-importante');
	const corBotao = document.getElementById('botao-importante');
	if (inserirTarefaImportante === ""){
		EntradaObrigatoriaImportante.placeholder="Entrada obrigatória!";
		EntradaObrigatoriaImportante.style.borderColor = "#e70202";
		corBotao.style.borderColor = "#e70202";
		corBotao.style.backgroundColor = "#e70202";
		EntradaObrigatoriaImportante.focus();
		return
	}
	EntradaObrigatoriaImportante.placeholder="Escreva sua tarefa";
	EntradaObrigatoriaImportante.style.borderColor = "#B1D34B";
	corBotao.style.borderColor = "#F47920";
	corBotao.style.backgroundColor = "#F47920";
	const taskContainerImportante = document.createElement('div');
	const novaTarefaImportante = document.createElement('input');
	const checkTarefaImportante = document.createElement('marcador-importante');
	const taskDescriptionNodeImportante = document.createTextNode(inserirTarefaImportante);

	novaTarefaImportante.setAttribute('type', 'checkbox');
	novaTarefaImportante.setAttribute('name', inserirTarefaImportante);
	novaTarefaImportante.setAttribute('id', inserirTarefaImportante);

	checkTarefaImportante.setAttribute('for', inserirTarefaImportante);
	checkTarefaImportante.appendChild(taskDescriptionNodeImportante);

	taskContainerImportante.classList.add('tarefa-importante');
	taskContainerImportante.appendChild(novaTarefaImportante);
	taskContainerImportante.appendChild(checkTarefaImportante);

	listaTarefasImportantes.appendChild(taskContainerImportante);
}