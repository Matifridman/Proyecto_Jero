using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte1 : MonoBehaviour
{
    private Vector3 Spawnpoint;
    public GameObject Protecotr;
    public int keys;

    void Start()
    {
        Spawnpoint = new Vector3(-28.27f, 12f, -353.83f);
    }

    void Update()
    {
        keys = data.keys;
        if (data.keys >=4)
        {
            Destroy(Protecotr);
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Teleport")
        {
            Instantiate(gameObject, Spawnpoint, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    /*public void OnTriggerEnter(Collider other)
{
    thePlayer.transform.position = teleportTarget.transform.position + new Vector3(0, 2.5f, 0);
}*/
}

