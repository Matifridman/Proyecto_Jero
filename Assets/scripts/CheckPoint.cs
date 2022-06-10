using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    //public GameObject Player;
    //public string Death_point;
    //private Vector3 Spawnpoint;
    void Start()
    {
        //Spawnpoint = new Vector3(66.95f, 15f, 21.7f);
    }

    public void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position + new Vector3(0, 2.5f, 0);
    }
}




