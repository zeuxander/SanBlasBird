using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectordecolumnas : MonoBehaviour
{
  public int puntuacion = 0;

    public int puntosPorColumna = 1;

    private void OnTriggerExit(Collider other)
    {
        puntuacion = puntuacion + puntosPorColumna;
    }

   
}
