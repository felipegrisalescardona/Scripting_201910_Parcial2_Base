# Scripting_201910_Parcial2_Base

Pooling en Balas y Spawn de AI:
para la instanciacion de balas y enemigos, y de acuerdo al problema planteado, el patron de creacion
de pooling permitia mantener mas control sobre los objetos que se iban a usar durante la ejecucion
del juego, economizando recursos y asegurandose de que siempre se tendra una prediccion de lo que
vendra despues (ya estan instanciados entonces se sabe cual viene ademas de que se llaman en orden).

State como patron de comportamiento de la AI
aA inteligencia artificial usa este patron (de acuerdo en este caso a la distancia con el jugador)
para definir un comportamiento especifico de acuerdo a la condicion, dentro de los requerimientos
del proyecto se proponia implicitamente este patron de comportamiento. Idle, Warning y Act son sus 
estados particulares.
