using UnityEngine;
using TMPro;

public class ContadorTomatesMaduros : MonoBehaviour
{
    public TextMeshPro textoTomatesMaduros;
    public TextMeshPro textoTomatesNoMaduros;

    void Start()
    {
        // Esperan 15 segundos antes de comenzar para que todos los tomates terminen su proceso
        Invoke("ContarTomates", 15f);
    }

    // Con esta función vamos a saber cuántos tomates maduraron y cuántos no
    void ContarTomates()
    {
        // Con este llamado obtenemos todos los objetos de la escena
        GameObject[] todosLosObjetos = GameObject.FindObjectsOfType<GameObject>();

        // Contadores para contar los tomates maduros y no maduros
        int tomatesMaduros = 0;
        int tomatesNoMaduros = 0;

        // Recorrer todos los objetos
        // La función foreach sirve para recorrer todos los objetos dentro de un grupo
        // En este caso recorremos todos los objetos del mundo en busca de los tomates
        foreach (GameObject obj in todosLosObjetos)
        {
            // Verificar si el objeto es un tomate
            if (obj.name == "Tomate")
            {
                // De esta manera se puede obtener el componente encargado de madurar los tomates
                CultivoTomates scriptTomate = obj.GetComponent<CultivoTomates>();

                // Verificar si el tomate está maduro
                if (scriptTomate != null)
                {
                    if (scriptTomate.estaMaduro)
                    {
                        // Si el tomate está maduro, aumenta el contador de los tomates maduros
                        tomatesMaduros++;
                    }
                    else
                    {
                        // Si el tomate no está maduro, aumenta el contador de los tomates no maduros
                        tomatesNoMaduros++;
                    }
                }
            }
        }

        // Al finalizar el ciclo, solo falta mostrar los resultados en los objetos TextMeshPro
        textoTomatesMaduros.text = tomatesMaduros.ToString(); ;
        textoTomatesNoMaduros.text = tomatesNoMaduros.ToString(); ;
    }
}
