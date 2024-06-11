// Este script busca los objetos marcados con el tag "PosicionArbol" y obtiene sus posiciones en x y z.
// Luego, instancia el objeto deseado en esas posiciones.

using UnityEngine;

public class InstanciarObjetos : MonoBehaviour
{
    public GameObject objetoDeseado; // Objeto que se instanciará

    private void Start()
    {
        MostrarObjetosEnPosiciones();
    }

    private void MostrarObjetosEnPosiciones()
    {
        // Se encuentran todos los objetos marcados por el tag PosicionArbol y se guardan en un arreglo
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("PosicionArbol");

        // Instanciar objetos
        // Se recorre el arreglo para obtener todas las posiciones deseadas
        foreach (GameObject objeto in objetos)
        {
            // Se obtienen las posiciones en x y z de cada uno de los objetos, y se mantiene la posición y del prefab
            // Hago esto para que las instancias queden a la altura del suelo
            Vector3 posicion = new Vector3(objeto.transform.position.x, objetoDeseado.transform.position.y, objeto.transform.position.z);

            // Instanciar el objeto deseado en las posiciones obtenidas
            GameObject objetoInstanciado = Instantiate(objetoDeseado, posicion, Quaternion.identity);

            // Aplicar rotación en el eje X
            objetoInstanciado.transform.Rotate(Vector3.left, 90f);
        }
    }
}

