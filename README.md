1. ¿Qué es un Coding Dojo? 

-	Un coding dojo es un evento de aprendizaje donde los programadores se reúnen para practicar y mejorar sus habilidades de codificación. Lo hacen mediante ejercicios estructurados y otras actividades colaborativas.  (https://www.codewars.com) 

2. Diferencia entre Requerimientos, Criterios de Aceptación y Escenarios de Prueba. Dar ejemplos a partir de un problema distinto a la referencia. Referencia https://lorenzosolano.com/requirements-acceptance-criteria-and/

Vamos a tomar el ejemplo de un programa para jugar ajedrez. 

-	Los requerimientos serian una necesidad o funcionalidad que el software necesita cumplir para considerarse completo, por ejemplo:

o	La aplicación debe permitir jugar ajedrez correctamente.
o	La aplicación debe permitir cambiar de color antes de jugar.
o	La aplicación debe permitir modificar la dificultad del ajedrez.

-	Los criterios de aceptación serian, como dice el nombre, criterios que te permiten comprobar si el funcionamiento de la aplicación es el correcto.

o	La aplicación debe cumplir con todos los reglamentos de ajedrez.
o	La aplicación debe navegar por el menú exitosamente.

-	Escenario de prueba seria un escenario que compruebe con éxito un criterio de aceptación.

o	Usaremos escenarios para probar las reglas de ajedrez:

	Esc 1.0: El primer jugador en moverse debe ser el blanco.
	Esc 1.1: Después del primer movimiento del peón, el mismo peón solo se mueve 1 vez. 
	Esc 1.2: Al mover el caballo, este se mueve en L. 
	Esc 1.3: La torre se mueve indefinidamente de manera lineal, con sus limites siendo el borde del tablero, hasta chocar con una ficha aliada o comerse una ficha enemiga. 



3. De dos ejemplos de requerimientos no-funcionales, y especifique cuál es su categoría (seguridad, performance, portabilidad, etc.)

-	Para el mismo ejemplo del punto anterior (ajedrez):

o	Rendimiento: Que el oponente CPU no tarde mas de 5 segundos en moverse en su máxima dificultad. 
o	Portabilidad: La aplicación debe pesar menos de 500mb

4. ¿Qué es TDD?

-	Test-Driven Development: Es un enfoque en la programacion que se trata de escribir las pruebas unitarias antes de escribir el código. (intelequia.com/tdd)

5. ¿Que son pruebas unitarias automatizadas?

-	Las pruebas unitarias son procesos en los que se prueban unidades funcionales pequeñas del código. Las pruebas unitarias automatizadas vienen de la aplicación de herramientas para automatizar el proceso de revisión de estas pruebas. (atlassian.com/PruebaAutomatizada) 

6. ¿Cual fue el 1er framework de pruebas unitarias y para cual lenguaje fue creado?

-	El primer framework de pruebas unitarias fue SUnit, creado por Kent Beck para el lenguaje de programación Smalltalk. (eng.libretexts.org) 

7. ¿Describa los componentes de la arquitectura xUnit?

-	Fixture: Configura el entorno necesario para las pruebas. Incluye la inicialización y limpieza del entorno antes y después de cada prueba.
-	Test Case: Define una unidad de prueba individual. Cada test case evalúa un aspecto específico del código.
-	Test Suite: Agrupa múltiples test cases en un conjunto que se puede ejecutar en conjunto. Permite la ejecución organizada de pruebas relacionadas.
-	Test Runner: Ejecuta los test cases y test suites. Reporta los resultados, indicando qué pruebas pasaron, fallaron o arrojaron errores.


8. Indique al menos tres desventajas de las pruebas unitarias automatizadas

-	Las pruebas unitarias requieren tiempo para ser escritas y, a medida que el código evoluciona, también necesitan ser mantenidas y actualizadas.
-	Las pruebas unitarias solo verifican el comportamiento de unidades individuales de código.
-	Si las pruebas no están bien diseñadas o no cubren todos los casos posibles, pueden dar una falsa sensación de que el código es robusto y libre de errores.

9. Indique al menos tres ventajas de las pruebas unitarias automatizadas

-	Permiten identificar y corregir errores en las primeras etapas del desarrollo
-	los desarrolladores pueden refactorizar el código con confianza, sabiendo que las pruebas verificarán que el comportamiento del código sigue siendo correcto.
-	Fomentan la escritura de código modular y cohesivo


10. Tomando el algoritmo de conversión de números arábigos o "decimales" a números Romanos:

  * Cree un documento donde se listen los Requerimientos, Criterios de Aceptación y Casos de Prueba para una aplicación de consola

-	Requerimientos: 

o	La aplicación debe permitir convertir el numero arabico ingresado a su equivalente romano.
o	La aplicación debe permitir múltiples respuestas en una sola sesión. 
o	La aplicación debe informar al usuario si se ingresan datos incompatibles con el programa.

-	Criterios de Aceptación:

o	La aplicación muestra el equivalente romano del numero arábico ingresado. 
o	La aplicación permite interactuar nuevamente después de responder.

-	Casos de Prueba: 

1.
Entrada: 15
Convert.ArabibicoRoman(INT) : String 
Salida: “XV”

2.
Entrada: 50
Convert.ArabicoRomano(INT) : String
Salida: “L”

3. 
Entrada: 100
Convert.ArabicoRomano(INT) : String
Salida: "C"
   
4. 
Entrada: 45
Convert.ArabicoRomano(INT) : String
Salida: XLV

5.
Entrada 25
Convert.ArabicoRomano(INT) : String
Salida: XXV

  * Los casos de prueba deben ser de dos categorías: End-To-End (desde el UI) y Unitarios (caja blanca, código, bajo nivel)


11. Utilizando el lenguaje de su preferencia cree cinco o mas casos de prueba unitarios automatizados utilizando un framework de automatización de pruebas para el algoritmo en cuestion
