# RPG_API
Cubre los problemas basicos de este tipo de juegos. No presenta soporte para interfaces de ningun tipo.
Usa las librerias basicas de C#, dado que evitar usar listas, o mapas dara lugar a codigo innecesario y dificil de interpretar a medida que crezca.
Enfocado para MonoGame, C#

Actualizacion: Se estan borrando/modificando clases para lograr correr los test unitarios

Al menos funciona los de la interfaz iAttack. Al acabar con toda la parte de Combat, se avanzara.

Se esta usando una interfaz iVar dentro de iAttack para garantizar la generalidad de los tipos usados, de esta forma se 
pueden realizar operaciones numericas. Deberia ser trasparente para el usuario, por lo que cuando se garantice la funcionalidad
se usara un ADAPTER sobre las clases attack, para usar uint o float.

Se pueden usar para los tipos uint, float, pero se trabajara para soportar byte o ushort embebidos, por cuestiones de memoria.

