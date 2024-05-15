using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ControladorMaduracion : MonoBehaviour
{
    public Material materialNoMaduro;
    public Material materialMaduro;
    public XRGrabInteractable grabInteractable;

    public bool estaMaduro = false;
    private bool maduracion = false;

    void Start()
    {
        // Comienza con material no maduro
        GetComponent<Renderer>().material = materialNoMaduro;

        // Si el objeto tiene un grabInteractable, desactivarlo al inicio
        if (grabInteractable != null)
        {
            grabInteractable.enabled = false;
        }

        // Inicia el proceso de maduraci�n
        IniciarMaduracion();
    }

    void IniciarMaduracion()

    {
        float tiempoDeMaduracion;
        if (gameObject.name == "Tomate") // Si el objeto es un tomate...
        {
            maduracion = Random.value > 0.1f;
            // Devuelve un n�mero al azar entre 0 y 1
            // Si el n�mero es mayor que 0.1 (90% probable que pase)...
            // El valor de maduracion ser� true, de lo contrario ser� false
            tiempoDeMaduracion = Random.Range(2f, 60f);
        }
        else
        {
            tiempoDeMaduracion = Random.Range(5f, 20f);
            maduracion = true; // Todos los objetos que no son tomates siempre maduran
        }

        if (maduracion) // Si el objeto madura, inicia el proceso de maduraci�n
        {
            Invoke("Madurar", tiempoDeMaduracion);
        }
        
    }

    void Madurar()
    {
        // Cambiar estado a maduro
        estaMaduro = true;
        // Cambiar material a maduro
        GetComponent<Renderer>().material = materialMaduro;

        // Activar XR Grab Interactable si es maduro y si el componente est� presente
        if (estaMaduro && grabInteractable != null)
        {
            grabInteractable.enabled = true;
        }
    }
}
