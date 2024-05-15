using UnityEngine;
using TMPro;
using System.Collections;

public class ControladorConteoTomates : MonoBehaviour
{
    public GameObject contenedorTomates;
    public TextMeshPro textoTomatesMaduros;
    public TextMeshPro textoTomatesNoMaduros;

    // M�todo para contar solo los tomates maduros
    public void ContarTomatesMaduros()
    {
        int tomatesMaduros = 0;

        foreach (Transform tomate in contenedorTomates.transform)
        {
            ControladorMaduracion scriptTomate = tomate.GetComponent<ControladorMaduracion>();
            if (scriptTomate != null && scriptTomate.estaMaduro)
            {
                tomatesMaduros++;
            }
        }

        textoTomatesMaduros.text = tomatesMaduros.ToString();
        StartCoroutine(Resize(textoTomatesMaduros.transform));
    }

    // M�todo para contar solo los tomates no maduros
    public void ContarTomatesNoMaduros()
    {
        int tomatesNoMaduros = 0;

        foreach (Transform tomate in contenedorTomates.transform)
        {
            ControladorMaduracion scriptTomate = tomate.GetComponent<ControladorMaduracion>();
            if (scriptTomate != null && !scriptTomate.estaMaduro)
            {
                tomatesNoMaduros++;
            }
        }

        textoTomatesNoMaduros.text = tomatesNoMaduros.ToString();
        StartCoroutine(Resize(textoTomatesNoMaduros.transform));
    }

    IEnumerator Resize(Transform textTransform)
    {
        Vector3 originalSize = textTransform.localScale;
        Vector3 targetSize = originalSize * 1.25f;  // Aumentar tama�o a 125%
        float duration = 0.5f;  // Duraci�n total de la animaci�n
        float halfDuration = duration / 2;

        // Animaci�n para aumentar tama�o
        for (float t = 0; t < halfDuration; t += Time.deltaTime)
        {
            textTransform.localScale = Vector3.Lerp(originalSize, targetSize, t / halfDuration);
            yield return null;
        }
        textTransform.localScale = targetSize;

        // Animaci�n para volver al tama�o original
        for (float t = 0; t < halfDuration; t += Time.deltaTime)
        {
            textTransform.localScale = Vector3.Lerp(targetSize, originalSize, t / halfDuration);
            yield return null;
        }

        textTransform.localScale = originalSize;
    }
}
