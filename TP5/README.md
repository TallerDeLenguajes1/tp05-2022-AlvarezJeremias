# Trabajo Practico 5
_ ¿Una String es un tipo de valor o un tipo por referencia? ¿Que secuencias de escape tiene el String? ¿Que sucede cuando se utiliza los caracteres @ y $ antes de una cadena de texto?_

##¿Valor o por referencia?

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
|     \´      |Muestra de comilla simple|
|     \"      |Muestra de comilla doble|
|     \\      |Muestra de barra invertida|
|     \O      |Caracter nulo|
