using UnityEngine;

public class CultivoTomates : MonoBehaviour
{
    public Material materialNoMaduro;
    public Material materialMaduro;

    public bool estaMaduro;

    void Start()
    {
        // Asignar material de cultivo no maduro al inicio
        GetComponent<Renderer>().material = materialNoMaduro;

        // Al inicio, determinar si el tomate madurará o no de manera aleatoria
        estaMaduro = Random.value > 0.1f; // Hay un 90% de probabilidad de que madure ///////////////////////////////////////

        // Llamar a la función para iniciar el proceso de maduración si está maduro
        if (estaMaduro)
        {
            IniciarMaduracion();
        }
    }

    void IniciarMaduracion()
    {
        // Generar un tiempo de maduración aleatorio entre 2 y 15 segundos
        float tiempoDeMaduracion = Random.Range(2f, 15f);

        // Llamar a la función de maduración después del tiempo aleatorio
        Invoke("Madurar", tiempoDeMaduracion);
    }

    void Madurar()
    {
        // Cambiar material a maduro
        GetComponent<Renderer>().material = materialMaduro;
    }
}
