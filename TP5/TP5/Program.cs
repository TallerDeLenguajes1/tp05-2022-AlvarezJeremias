using System;

Console.Write("Escriba el numero a invertir: ");
int numero, reverso=0, resto;

numero=int.Parse(Console.ReadLine());

while (numero>0){
    resto = numero % 10;
    reverso = reverso * 10 + resto;
    numero = numero / 10;
    
}
Console.Write("el numero ingresado invertido es : " + reverso);

