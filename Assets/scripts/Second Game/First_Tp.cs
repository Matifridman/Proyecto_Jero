using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Tp : MonoBehaviour
{
    private Vector3 Spawnpoint;
    

    void Start()
    {
        Spawnpoint = new Vector3(-321, 24, 287);
    }

    


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "End2")
        {
            Instantiate(gameObject, Spawnpoint, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
