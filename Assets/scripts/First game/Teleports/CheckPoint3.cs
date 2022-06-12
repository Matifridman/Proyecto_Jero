using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint3 : MonoBehaviour
{
    private Vector3 Spawnpoint4;
    void Start()
    {
        Spawnpoint4 = new Vector3(-309f, 2f, -36f);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CheckPoint3")
        {
            Instantiate(gameObject, Spawnpoint4, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
