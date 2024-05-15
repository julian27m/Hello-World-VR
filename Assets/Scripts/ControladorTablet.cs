using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControladorTablet : MonoBehaviour
{
    // Referencias a los GameObjects y materiales necesarios
    public Collider colliderTablet;
    public GameObject contenido;
    public GameObject pantalla;
    public Material materialBlanco;
    public Material materialNegroMate;
    private XROrigin rig;

    private void Start()
    {
        // Verificar si se ha asignado un Collider y demás objetos necesarios
        if (colliderTablet == null || contenido == null || pantalla == null || materialBlanco == null || materialNegroMate == null)
        {
            Debug.LogError("No se han asignado todos los componentes necesarios.");
        }

        // Obtener referencia al componente XROrigin del jugador
        rig = FindObjectOfType<XROrigin>();
    }

    private void Update()
    {
        // Verificar si el jugador está dentro de los límites
        if (colliderTablet.bounds.Contains(rig.Camera.transform.position))
        {
            // Activar el contenido y cambiar el material de la pantalla a blanco
            contenido.SetActive(true);
            pantalla.GetComponent<Renderer>().material = materialBlanco;
        }
        else
        {
            // Desactivar el contenido y cambiar el material de la pantalla a negro mate
            contenido.SetActive(false);
            pantalla.GetComponent<Renderer>().material = materialNegroMate;
        }
    }
}
