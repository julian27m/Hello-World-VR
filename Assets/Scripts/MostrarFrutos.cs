using UnityEngine;

public class MostrarFrutos : MonoBehaviour
{
    public GameObject objetoFrutoPrefab; // Objeto que se instanciará

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
            // Obtener posiciones
            Vector3 posicion = objetoFruto.transform.position;

            Instantiate(objetoFrutoPrefab, posicion, Quaternion.identity);
            
        }
    }
}
