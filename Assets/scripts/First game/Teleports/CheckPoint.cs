using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    
    
    private Vector3 Spawnpoint;
    void Start()
    {
        Spawnpoint = new Vector3(-28.27f, 12f, -353.83f);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CheckPoint")
        {
            Instantiate(gameObject, Spawnpoint, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}




