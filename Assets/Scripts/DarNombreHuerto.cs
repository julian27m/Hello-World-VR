// Este script recibe una variable global y la imprime en la consola
// (**¿EXPLICAR QUE LOS COMENTARIOS EN C# SE ESCRIBEN CON // ?**)

using UnityEngine;

public class DarNombreHuerto : MonoBehaviour
{
    public string nombreHuerto; // Esta variable de tipo string se usa para escribir el nombre del huerto

    void Start()
    // La funciuón Start se activa cuando el juego empieza
    {
        // Llamamos a la función NombrarHuerto y mostramos el resultado en la consola
        // Detalles:
        // Para llamar a una función se escribe su nombre y dentro del paréntesis se pone el parámetro a ingresar
        // En este caso el parámetro es el string que se usa para escribir el nombre del huerto desde el inspector
        // Debug.Log es una función de Unity usada para mostrar resultados en la consola
        Debug.Log(NombrarHuerto(nombreHuerto));
        
    }

    void Update()
    // Esta función se actualiza de forma constante mientras el juego se esté ejecutando
    {
        // Se obtiene la fecha de hoy utilizando System.DateTime.Now
        // Para convertir la fecha a un string se utiliza ToString("yyyy-MM-dd")
        string fechaHoy = System.DateTime.Now.ToString("yyyy-MM-dd");

        // Muestra la fecha de hoy en la consola con un texto adicional 
        Debug.Log("La fecha de hoy es: " + fechaHoy);
    }

    private string NombrarHuerto(string nombreHuerto)
    {
        // Devuelve el mismo nombre del huerto que le ingresa
        return nombreHuerto;

        // ¿Qué pasaría si quisieramos agregar texto adicional?
        // Los strings se pueden concatenar (**¿EXPLICACIÓN DE CONCATENACIÓN?**)
        // return "Mi huerto es" + nombreHuerto
        // Con este pequeño cambio podemos agregar texto adicional al escrito desde el inspector
    }
}
