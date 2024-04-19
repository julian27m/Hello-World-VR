using UnityEngine;

public class MostrarFrutos : MonoBehaviour
{
    public GameObject objetoFrutoPrefab; // Objeto que se instanciar�
    public float maximaRotacion; // �ngulo m�ximo de rotaci�n

    private void Start()
    {
        MostrarFrutosEnPosiciones();
    }

    private void MostrarFrutosEnPosiciones()
    {
        GameObject[] objetosFrutos = GameObject.FindGameObjectsWithTag("PosicionFruto");

        // Instanciar objetos
        foreach (GameObject objetoFruto in objetosFrutos)
        {
            // Obtener posici�n
            Vector3 posicion = objetoFruto.transform.position;

            // Instanciar objeto
            GameObject frutoInstanciado = Instantiate(objetoFrutoPrefab, posicion, Quaternion.identity);

            // Aplicar rotaci�n aleatoria sobre el eje Y
            float rotacionAleatoria = Random.Range(-maximaRotacion, maximaRotacion);
            frutoInstanciado.transform.Rotate(Vector3.up, rotacionAleatoria);
        }
    }
}
