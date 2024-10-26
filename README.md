# Cámara Unity - FDV

Las cámaras en los videojuegos son fundamentales para garantizar una experiencia visual coherente y clara para el jugador, ya que definen qué parte del mundo del juego es visible en pantalla. Cada tipo de juego requiere un comportamiento específico de las cámaras: en un puzzle, la cámara es estática y muestra todo el tablero; en un shooter en primera persona, la cámara se coloca a la altura de los ojos del personaje; y en un juego de carreras, la cámara sigue al vehículo.

En juegos 2D, se suelen emplear efectos de cámara como:

- **Seguimiento de personajes** para mantener al protagonista siempre visible.
- **Definición del área visible** para ajustar qué parte del mundo se muestra en pantalla.
- **Zoom y enfoque dinámico** para acercar o alejar la cámara, resaltando áreas clave.
- **Transiciones de escena** para cambios suaves entre niveles.
- **Efectos visuales** como sacudidas o desenfoques.
- **Pantalla dividida** en juegos multijugador, permitiendo varias perspectivas.

Unity ofrece el paquete **Cinemachine**, una herramienta que facilita el control de cámaras mediante cámaras virtuales o controladores, que permiten efectos avanzados como seguimiento de objetos, encuadre automático, seguimiento de grupos y combinaciones de cámaras.

## Tarea 1

Instalar el paquete CineMachine y configurar 2 cámaras virtuales con diferentes zonas de seguimiento al jugador. Mostar el efecto mediante un gif animado. 

## Tarea 2

Define un área de confinamiento diferente para cada una de las dos cámaras de la tarea anterior. Realiza una prueba de ejecución con el correspondiente gif animado que permita ver las diferencias.

## Tarea 3

Agrega varios sprites en la escena que estén realizando un movimiento (mínimo 3). Genera una cámara adicional que le haga el seguimiento a dichos objetos.

## Tarea 4

Agrega 2 sprites adicionales en la escena que estén realizando un movimiento Genera una cámara adicional que le haga el seguimiento a dichos objetos, cada uno con un peso en la importancia del seguimiento diferente.

## Tarea 5

Implementar un zoom a la cámara del jugador que se controle con las teclas w-s.

## Tarea 6

Seleccionar un conjunto de teclas que permitan hacer el cambio entre dos cámaras. (Habilitar/Deshabilitar el gameobject de la cámara virtual)

## Tarea 7

Crear un script para activar la cámara lenta cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad. 

## Tarea 8

Crear un script para activar la cámara rápida cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad. 

## Tarea 9 

Crear un script para intercambiar la cámara activa, una estará confinada y la otra no,  cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad. 