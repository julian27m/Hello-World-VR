using UnityEngine;
using TMPro;

public class ContadorAlimentos : MonoBehaviour
{
    public TextMeshPro contadorLechugas;
    public TextMeshPro contadorSandias;
    public TextMeshPro contadorCalabazas;
    public TextMeshPro contadorMaiz;

    private int lechugas = 0;
    private int sandias = 0;
    private int calabazas = 0;
    private int maiz = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lechuga")
        {
            lechugas++;
            contadorLechugas.text = lechugas.ToString();
        }
        else if (other.gameObject.name == "Sandia")
        {
            sandias++;
            contadorSandias.text = sandias.ToString();
        }
        else if (other.gameObject.name == "Calabaza")
        {
            calabazas++;
            contadorCalabazas.text = calabazas.ToString();
        }
        else if (other.gameObject.name == "Maiz")
        {
            maiz++;
            contadorMaiz.text = maiz.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Lechuga")
        {
            lechugas--;
            contadorLechugas.text = lechugas.ToString();
        }
        else if (other.gameObject.name == "Sandia")
        {
            sandias--;
            contadorSandias.text = sandias.ToString();
        }
        else if (other.gameObject.name == "Calabaza")
        {
            calabazas--;
            contadorCalabazas.text = calabazas.ToString();
        }
        else if (other.gameObject.name == "Maiz")
        {
            maiz--;
            contadorMaiz.text = maiz.ToString();
        }
    }
}
