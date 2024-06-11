// Este script recibe una variable global y la muestra en un texto 3D dentro de la escena
// Además, muestra la efcha de hoy en un texto 3D dentro de la escena

using UnityEngine;
using TMPro; // Importante importar TMPro para referenciar el texto 3D (**¿EXPLICAR USING EN UNITY?**)

public class MostrarNombreJugador : MonoBehaviour
{
    // TO DO

    // 1. Declarar la variable con el nombre del jugador
    public string nombreJugador; // Esta variable de tipo string se usa para escribir el nombre del jugador
    // Se puede pensar en que no sea una variable publica sino privada y que el usuario la defina desde el script en forma de string "Mi nombre".


    //2. Declarar las variables de los textos donde se va a mostrar la información en la escena
    public TextMeshPro nombreTexto3D; // Esta variable es el texto 3D en el que se va a mostrar el nombre del jugador
    public TextMeshPro fechaTexto3D; // Esta variable es el texto 3D en el que se va a mostrar la fecha de hoy

    void Start()
    {
        // TO DO

        //4. Asignar el resultado de NombrarJugador a la variable con el nombre 3D jugador
        nombreTexto3D.text = NombrarJugador(nombreJugador);

        //5. Asignar la fecha de hoy a la variable fecha
        string fechaHoy = System.DateTime.Now.ToString("yyyy-MM-dd");

        //6. Al texto 3D se le asigna el valor de la fecha de hoy
        fechaTexto3D.text = fechaHoy;



    }

    private string NombrarJugador(string nombreJugador)
    {
        // TO DO

        // 3. Modificar o crear la función NombreJugador
        return nombreJugador;
    }
}
