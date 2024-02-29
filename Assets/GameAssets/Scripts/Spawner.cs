using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int numeroElementos;
    public float tiempoEntreSpawn;
    private int contador = 0;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", tiempoEntreSpawn, tiempoEntreSpawn);
    }

    // Update is called once per frame
    void Spawn(){
        contador++;
        Instantiate(prefab, transform);
        if (contador >= numeroElementos){
            CancelInvoke("Spawn");

        }

    }
   
}
