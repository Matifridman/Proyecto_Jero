using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject Protecotr;


    public int keys;

    void Update()
    {
        keys = data.keys;
        if (data.keys >= 4)
        {
            Destroy(Protecotr);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
    


}
    
  
