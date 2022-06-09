using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    /*public GameObject Player;
    public string teleport;
    private Vector3 Spawnpoint¨*/

    public Transform teleportTarget;
    public GameObject thePlayer;
    void OnTriggerEnter( Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
    
    void Start()
    {
        //Spawnpoint = new Vector3(1.3f, 20f, 59.8f);
    }

    
    void Update()
    {

    }
    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Teleport")
        {
            //Instantiate(Player, Spawnpoint, Quaternion.identity);
            Player.transform.position += Spawnpoint;
        }
    }*/
}
