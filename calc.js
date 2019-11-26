
function atribuirValor(numero){
    //alert(numero)

    switch (numero) {
        case (9):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "9"; 
            break;
        case (8):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "8"; 
            break;
        case (7):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "7"; 
            break;
        case (6):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "6"; 
            break;
        case (5):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "5"; 
            break;
        case (4):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "4"; 
            break;
        case (3):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "3"; 
            break;
        case (2):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "1"; 
            break;
        case (1):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "1"; 
            break;
        case (0):
            var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "0"; 
            break;
        
    }

}

function backspace() {

    var backspace = document.getElementById("display").innerText;
    console.log(backspace); //mostra o valor da variável no F12 do Chrome
    document.getElementById("display").innerText = backspace.substring(0, backspace.length - 1);
    

}

    // function porcentagem(divisao) {
    //     this.display = '${parseFloat(this.display) / 100}';
    // }


    // function calcNumbers(result){
    //     form.displayResult.value=form.displayResult.value+result;
        
    // }

    // function soma(numero){

    //     if (numero == '+'){
            
    //     }

    // }

    // == compara se tudo dentro do parâmetro é idêntico (tamanho, nome, atributos, valor...)
    // === compara se apenas o valor dentro da variáel é idêntico

    // if(numero === 9){
    //     var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "9"; 
    //     return x;
    // } else if(numero === 8) {
    //     var x = document.getElementById("display").innerText = document.getElementById("display").innerText + "8"; 
    //     return x;
    // }

    
