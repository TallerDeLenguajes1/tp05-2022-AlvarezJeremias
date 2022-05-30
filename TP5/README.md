# Trabajo Practico 5
_¿Una String es un tipo de valor o un tipo por referencia? ¿Que secuencias de escape tiene el String? ¿Que sucede cuando se utiliza los caracteres @ y $ antes de una cadena de texto?_

## ¿Valor o por referencia?

Una String (cadena de caracteres) es un tipo por referencia, puesto que la cantidad de memoria necesaria para su reserva no esta determinada y siempre se reserva en el heap.

## Secuencias de escape: 
La secuencias de escape presentes en C# disponibles para Strings son:

|  Secuencia  |  Descripcion  |
|  ---------  |  -----------  |
|     \a      |Emite un pitido|
|     \b      |  Retroceso  |
|     \f      |  Avance de pagina  |
|     \n      |  avance de Linea  |
|     \r      |  Retorno de Carro |
|     \t      |  salto de tabulacion horizontal  |
|     \v      |Salto de tabulacion vertical  |
|     \\'      |Muestra de comilla simple|
|     \\"      |Muestra de comilla doble|
|     \\\      |Muestra de barra invertida|
|     \O      |Caracter nulo|

## ¿Que pasa si colocamos un @ o $ antes de una String?

El caracter se $ se usa para un metodo conocido como Interpolacion de Cadenas, si lo colocamos previo a una cadena de caracteres en la cual interactuan variables, los nombres de las variables que se encuentren dentro de la cadena (las comillas dobles) y que esten entre llaves ({}), sera tomado como una referencia al valor de la misma.
Aqui una comparacion entre ambos metodos (clasico y usando interpolacion de cadenas)

```

int numero1=12, numero2=24;
// metodo clasico/convencional
Console.WriteLine("el numero 1 es {0} y el numero 2 es {1}",numero1,numero2);

// Metodo usando Interpolacion de Cadenas ($)

Console.WriteLine($"El numero 1 es {numero1} y el numero 2 es {numero2}");

// lo que se mostrara en la consola es lo mismo, "El numero 1 es 12 y el numero 2 es 24", pero el caracter $ nos permite que nuestro codigo sea mas legible.

```

El caracter @ nos permite que, al colocarlo previo a una cadena de caracteres, los caracteres especiales, tales como la barra invertida (\\) sean interpretados como tal.
