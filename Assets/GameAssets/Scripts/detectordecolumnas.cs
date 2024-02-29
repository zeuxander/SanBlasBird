using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class detectordecolumnas : MonoBehaviour
{
    public TMP_Text textObject;
  public int puntuacion = 0;

    public int puntosPorColumna = 1;
    void OnTriggerExit()
    {
        puntuacion = puntuacion + puntosPorColumna;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacion.ToString());
    }
    
        
    

}
