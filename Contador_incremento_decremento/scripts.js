let currentNumberWrapper = document.getElementById("currentNumber")
// currentNumberWrapper = document.querySelector('#currentNumber') faz o mesmo da linha acima
let currentNumber = 0;

function increment(){
  currentNumber = currentNumber + 1;
  currentNumberWrapper.innerHTML = currentNumber;
  if (currentNumber >= 0 && currentNumber < 10){
    document.querySelector('#alerta').innerHTML = ""
    document.querySelector('.subtrair').style.opacity = 1;
  }

  if (currentNumber >= 10){
    document.querySelector('.adicionar').style.opacity = 0;
    document.querySelector('#alerta').innerHTML = "Não canse seu dedo! Vamos contar só até 10.";
    currentNumberWrapper.innerHTML = 10
    currentNumber = 10;
  } 
}

function decrement(){
  currentNumber = currentNumber - 1;
  currentNumberWrapper.innerHTML = currentNumber;
  if (currentNumber < 0){
    document.querySelector('.subtrair').style.opacity = 0;
    document.querySelector('#alerta').innerHTML = "Número não pode ser negativo!"
    currentNumberWrapper.innerHTML = 0
    currentNumber = 0
  }

  if (currentNumber > 0 && currentNumber <= 10){
    document.querySelector('.adicionar').style.opacity = 1;
    document.querySelector('#alerta').innerHTML = "";
  }
}