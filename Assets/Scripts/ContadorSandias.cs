using UnityEngine;
using TMPro;

public class ContadorSandias : MonoBehaviour
{
    public TextMeshPro textoContador;
    public Collider colisionadorCaja;
    private int contador = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sandia"))
        {
            contador++;
            textoContador.text = contador.ToString();
        }
    }
}
