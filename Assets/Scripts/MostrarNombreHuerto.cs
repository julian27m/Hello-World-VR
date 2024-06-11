// Este script recibe una variable global y la muestra en un texto 3D dentro de la escena
// Además, muestra la efcha de hoy en un texto 3D dentro de la escena

using UnityEngine;
using TMPro; // Importante importar TMPro para referenciar el texto 3D (**¿EXPLICAR USING EN UNITY?**)

public class MostrarNombreHuerto : MonoBehaviour
{
    public string nombreHuerto; // Esta variable de tipo string se usa para escribir el nombre del huerto
    public TextMeshPro nombreTexto3D; // Esta variable es el texto 3D en el que se va a mostrar el nombre del huerto
    public TextMeshPro fechaTexto3D; // Esta variable es el texto 3D en el que se va a mostrar la fecha de hoy

    void Start()
    {
        // Obtenemos la fecha de hoy como en el script anterior
        string fechaHoy = System.DateTime.Now.ToString("yyyy-MM-dd");

        // Al texto 3D se le asigna el resultado de la función NombreHuerto
        nombreTexto3D.text = NombrarHuerto(nombreHuerto);
        // Al texto 3D se le asigna el valor de la fecha de hoy
        fechaTexto3D.text = fechaHoy;
    }

    private string NombrarHuerto(string nombreHuerto)
    {
        // Esta función recibe un string como parámetro y lo devuelve como resultado
        return nombreHuerto;
    }
}
