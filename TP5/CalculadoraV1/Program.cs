using System;

int numero1,numero2,operacion,resultado=0;
char respuesta='y';


while (respuesta=='Y' || respuesta=='y')
{
    Console.WriteLine("Seleccione un tipo de operacion: ");
    Console.WriteLine("1) SUMA");
    Console.WriteLine("2) RESTA");
    Console.WriteLine("3) MULTIPLICACION");
    Console.WriteLine("4) DIVISION");

    operacion=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ahora, ingrese los numeros que se van a operar");
    numero1=Convert.ToInt32(Console.ReadLine());
    numero2=Convert.ToInt32(Console.ReadLine());

    switch (operacion)
    {
        case 1 : 
            resultado=numero1+numero2;
            break;
        case 2: 
            resultado=numero1-numero2;
            break;
        case 3: 
            resultado=numero1*numero2;
            break;
        case 4: 
            if(numero2!=0){ 
                resultado=numero1/numero2;
            }else {
                resultado=0;
            }
                break;
        
    }
    Console.WriteLine("El resultado de la operacion es: " + resultado);

    Console.Write("Desea hacer otra operacion? [Y/N]  ");
    respuesta=Convert.ToChar(Console.ReadLine());
    if (respuesta=='y' || respuesta == 'Y')
    {
        Console.WriteLine("-------------Siguiente operacion------------");
    }

}

Console.WriteLine ("Se ha finalizado la ejecucion de la calculadora");
