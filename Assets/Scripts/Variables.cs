// Este script se utiliza para ense�ar variables y sus tipos

using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaraci�n de variables
    string mensajeBienvenida; // Variable de tipo string
    float velocidadJugador; // Variable de tipo float
    int cantidadManzanas; // Variable de tipo int

    // Start es una funci�n de Unity que se llama al iniciar el juego (Se explica mejor en la lecci�n de funciones)
    void Start()
    {
        // Asignaci�n de valores a las variables
        mensajeBienvenida = "Bienvenido al juego"; // Asignaci�n de un texto a la variable string
        velocidadJugador = 5.5f; // Asignaci�n de un valor decimal a la variable float
        cantidadManzanas = 10; // Asignaci�n de un n�mero entero a la variable int

        // Imprimir los valores de las variables en la consola
        // La funci�n Debug.Log permite mostrar mensajes en la consola (**�ENSE�AR O MENCIONAR LOS USOS DE DEBUG.LOG?**)
        Debug.Log(mensajeBienvenida); // Imprimir el mensaje de bienvenida
        Debug.Log("Velocidad del jugador: " + velocidadJugador); // Imprimir la velocidad del jugador
        Debug.Log("Cantidad de manzanas: " + cantidadManzanas); // Imprimir la cantidad de manzanas
    }

}
