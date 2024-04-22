using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LimitesDeEscena : MonoBehaviour
{
    // Referencia al Collider que delimita la escena
    public Collider limiteCollider;
    private XROrigin rig;

    private void Start()
    {
        // Verificar si se ha asignado un Collider
        if (limiteCollider == null)
        {
            Debug.LogError("No se ha asignado un Collider para los l�mites de la escena.");
        }

        // Obtener referencia al componente XRRig
        rig = FindObjectOfType<XROrigin>();
    }

    private void Update()
    {
        // Verificar si el jugador est� fuera de los l�mites
        if (!limiteCollider.bounds.Contains(rig.Camera.transform.position))
        {
            // Si el jugador est� fuera de los l�mites, detener su movimiento
            rig.MoveCameraToWorldLocation(new Vector3(-1.5999999f, 0.545000076f, 10.3100004f));

            // Aqu� puedes agregar cualquier otra l�gica que desees para manejar el hecho de que el jugador est� fuera de los l�mites
        }
    }
}
