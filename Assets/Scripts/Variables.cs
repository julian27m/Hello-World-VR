// Este script se utiliza para enseñar variables y sus tipos

using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaración de variables
    string mensajeBienvenida; // Variable de tipo string
    float velocidadJugador; // Variable de tipo float
    int cantidadManzanas; // Variable de tipo int

    // Start es una función de Unity que se llama al iniciar el juego (Se explica mejor en la lección de funciones)
    void Start()
    {
        // Asignación de valores a las variables
        mensajeBienvenida = "Bienvenido al juego"; // Asignación de un texto a la variable string
        velocidadJugador = 5.5f; // Asignación de un valor decimal a la variable float
        cantidadManzanas = 10; // Asignación de un número entero a la variable int

        // Imprimir los valores de las variables en la consola
        // La función Debug.Log permite mostrar mensajes en la consola (**¿ENSEÑAR O MENCIONAR LOS USOS DE DEBUG.LOG?**)
        Debug.Log(mensajeBienvenida); // Imprimir el mensaje de bienvenida
        Debug.Log("Velocidad del jugador: " + velocidadJugador); // Imprimir la velocidad del jugador
        Debug.Log("Cantidad de manzanas: " + cantidadManzanas); // Imprimir la cantidad de manzanas
    }

}
