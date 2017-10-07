# Git
Git es un sistema de control de versiones distribuidas de código abierto y libre diseñado para manejar desde proyectos pequeños hasta muy grandes con velocidad y eficiencia.

Puedes encontrar la documentacion en la siguiente liga
 - [https://git-scm.com/docs](https://git-scm.com/docs)

Puedes descargarlo aqui
 - [https://git-scm.com/downloads](https://git-scm.com/downloads)

Los comandos a utilizar para esta face, serian los siguientes

 - git clone URL
    Clona un repositorio completo a tu maquina para poder trabajar.

 - git add all
    Cuando tengas cambios que subir a tu repositorio, necesitas decirle cuales, para esto, puedes agregar todos los que modificaste.
    
 - git commit -m "MESSAGE - Equipo N"
    Despues de agregarlos, necesitas agregar un comentario para los cambios que hayas hecho, aqui es tu desicion que poner.
    Solamente te pedimos que le agregues `- Equipo ` y el numero de equipo en el que estas, por ejemplo `Este es un comentario - Equipo 5`

 - git push
    Despues de cometer la accion anterior, necesitas hacer un push para que se queden guardados en tu repositorio en GitHub.


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


# Problema 2
##### Reverse parenthesis
Tienes una cadena que consiste de cualquier combinacion de palabras u oraciones, espacios en blancos y hasta caracteres especiales.
Es obligatorio que te topes con palabras dentro de parentesis.

Tu tarea es voltear la cadena al revez, contenida en cada par de parentesis, empezando por los parentesis mas internos que te encuentres.
El resultado no debera de contener ningun parentesis.

###### Ejemplo:
 - String s = "a(bc)de";
    Segun lo dicho anteriormente, debes de voltear la cadena que esta entre parentesis.
    En este caso las letras b y c.
    Dicho esto, la salida seria:
 - reverseParenthesis = "acbde".

    Otro ejemplo
 - String s = "a(bc(de)fg(hi)jk)"

    Dicho la explicacion, necesitas empezar por los parentesis mas internos.
    Los cuales son (de) & (hi).
    Al ponerlos al revez, tu primera cadena seria la siguiente
 
 - reverseParenthesis = "a(bcedfgihjk)"
 
    Notese que todavia te quedan parentesis que evaluar.
    Tendrias que poner al revez la cadena que esta entre esos parentesis de nuevo y tu salida final seria la siguiente
    
 - reverseParenthesis = "akjhigfdecb";
