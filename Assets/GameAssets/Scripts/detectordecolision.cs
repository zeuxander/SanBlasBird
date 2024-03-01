using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectordecolision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabExplosion;


    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(prefabExplosion, transform.position, prefabExplosion.transform.rotation);
        Destroy(gameObject);
    }
}
