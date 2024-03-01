using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnas : MonoBehaviour
{
    public float velocidad = 1;
    [Range(0, 3)]
    public float offset = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.up * Random.Range(-offset, offset));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -velocidad * Time.deltaTime));
    }
}
