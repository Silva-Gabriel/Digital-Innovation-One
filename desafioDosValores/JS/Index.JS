var num,positivos = 0,negativos = 0,impares = 0,pares = 0;
for(var i = 0; i < 5;i++)
{
    num = parseInt(prompt(`Digite o ${i}º número`));
    if(num > 0)
    {
        positivos++;  
    }
    else if(num < 0)
    {
        negativos++;
    }

    if(num % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
window.alert(`${pares} valor(es) par(es)\n${impares} valor(es) impar(es)\n${positivos} valor(es) positivo(s)\n${negativos} valor(es) negativo(s)`);
