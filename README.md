# Problema 1
##### AlmostIncreasingSequence

Dada una secuencia de enteros como un array, determinar si se puede obtener una secuencia estrictamente en incremento, removiendo no mas de un elemento del array.
###### Ejemplos
 - Para sequence = [1, 3, 2, 1], la salida deberia de ser:
almostIncreasingSequence(sequence) = false;

    No hay ningun elemento en el array que pueda ser removido para asi obtener una secuencia estrictamente en incremento
    
 - Para sequence = [1, 3, 2], la salida deberia de ser:
almostIncreasingSequence(sequence) = true;
    
    Es posible remover el numero 3 y asi obtener la secuencia [1, 2], la cual va en estricto incremento.
De manera alterna, tambien es posible remover el numero 2, obteniendo la secuencia [1, 3], la cual tambien va en incremento.

