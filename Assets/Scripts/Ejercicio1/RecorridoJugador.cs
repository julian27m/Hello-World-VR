// Este script reconoce la posición del jugador y escribe su posición en un archivo .txt, cada segundo

using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.XR.CoreUtils;
using UnityEngine;

public class RecorridoJugador : MonoBehaviour
{
    private string filePath; // Este es el archivo txt en el que se van a escribir las posiciones
    private XROrigin rig;
    private float updateInterval = 1.0f; // Intervalo de actualización en segundos

    private void Start()
    {
        // Esta es la referencia del jugador
        rig = FindObjectOfType<XROrigin>();

        // Esta es la ruta del archivo, se puede cambiar dependiendo de lo que se le quiera dar al estudiante para el primer ejercicio
        filePath = Application.dataPath + "/Scripts/Ejercicio1/RecorridoJugador.txt";

        // Si el archivo ya existe, eliminarlo para comenzar de nuevo
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        // Inicia la corrutina de registro de posición
        StartCoroutine(RegisterPlayerPosition());
    }

    private IEnumerator RegisterPlayerPosition()
    {
        while (true)
        {
            // Se obtiene la posición del jugador
            Vector3 playerPosition = rig.Camera.transform.position;

            // Se arma un texto predefinido para escribir la posición del jugador
            string positionString = $"Posición del jugador : ({playerPosition.x}, {playerPosition.y}, {playerPosition.z})";

            // Se escribe esa posición en el archivo .txt para guardar en forma de log
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(positionString);
            }

            // Se realiza esta corrutina cada segundo
            yield return new WaitForSeconds(updateInterval);
        }
    }
}
