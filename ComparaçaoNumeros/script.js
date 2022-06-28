function comparaNumeros(num1, num2) {
    const primeiraFrase = criarprimeirafrase(num1, num2);
    const SegundaFrase = criarSegundaFrase(num1, num2);
    

    return `${primeiraFrase} ${SegundaFrase}`;

}

function criarprimeirafrase(num1, num2) {
    let saoIguais = '';

    if (num1 !== num2) {
        saoIguais = 'nao'; 
    }
    return `Os numeros ${num1} e ${num2}  ${saoIguais} sao iguais `
}
function criarSegundaFrase(num1, num2){
    const soma = num1 + num2;

    let resultado10 = 'menor';
    let resultado20 = 'menor';

    const compara10 = soma > 10 ;
    const compara20 = soma > 20;

    if (compara10){
        resultado10 = 'maior';
    }
    if (compara20){
        resultado20 = 'maior';
    }
    return `Sua soma é ${soma}, que é ${resultado10} do que 10 e ${resultado20} do que 20.`;
}