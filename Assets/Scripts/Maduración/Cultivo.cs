using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Cultivo : MonoBehaviour
{
    public Material materialNoMaduro;
    public Material materialMaduro;
    public XRGrabInteractable grabInteractable;

    private bool estaMaduro = false;

    void Start()
    {
        // Asignar material de cultivo no maduro al inicio
        GetComponent<Renderer>().material = materialNoMaduro;

        // Desactivar XR Grab Interactable al inicio
        grabInteractable.enabled = false;

        // Llamar a la funci�n para iniciar el proceso de maduraci�n
        IniciarMaduracion();
    }

    void IniciarMaduracion()
    {
        // Generar un tiempo de maduraci�n aleatorio entre 5 y 20 segundos
        float tiempoDeMaduracion = Random.Range(5f, 20f);

        // Llamar a la funci�n de maduraci�n despu�s del tiempo aleatorio
        Invoke("Madurar", tiempoDeMaduracion);
    }

    void Madurar()
    {
        // Cambiar estado a maduro
        estaMaduro = true;
        // Cambiar material a maduro
        GetComponent<Renderer>().material = materialMaduro;
        // Activar XR Grab Interactable
        grabInteractable.enabled = true;
    }
}
