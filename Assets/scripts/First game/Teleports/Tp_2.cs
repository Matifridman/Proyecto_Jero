using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_2 : MonoBehaviour
{
    private Vector3 Spawnpoint2;
    
    void Start()
    {
        Spawnpoint2 = new Vector3(-309.86f, 2, -35.09f);
    }

  


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Teleport2")
        {
            Instantiate(gameObject, Spawnpoint2, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
