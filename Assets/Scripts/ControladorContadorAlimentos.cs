using UnityEngine;
using TMPro;

public class ControladorContadorAlimentos : MonoBehaviour
{
    public TextMeshPro contadorLechugas;
    public TextMeshPro contadorSandias;
    public TextMeshPro contadorCalabazas;
    public TextMeshPro contadorMaiz;

    private int lechugas = 0;
    private int sandias = 0;
    private int calabazas = 0;
    private int maiz = 0;

    // Con esta función se registran los alimentos que ingresan a la caja
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lechuga") // Si el objeto que entra a la caja es una lechuga...
        {
            lechugas++; // El contador de lechugas aumenta en 1
            contadorLechugas.text = lechugas.ToString(); // El resultado se muestra en el letrero correspondiente
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

    // Con esta función también se registran los alimentos que salgan de la caja
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Lechuga") // Si el objeto que sale de la caja es una lechuga...
        {
            lechugas--; // El contador de lechugas disminuye en 1
            contadorLechugas.text = lechugas.ToString(); // El resultado se muestra en el letrero correspondiente
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
 