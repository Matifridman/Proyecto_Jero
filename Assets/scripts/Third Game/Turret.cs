using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform targetTr;

    /*public GameObject bullet;
    public Transform bulletSpawn = null;
    public GameObject thePlayer;*/

    
    void Update()
    {

        Quaternion lookRotation = Quaternion.LookRotation(targetTr.position - transform.position);
        transform.rotation = lookRotation;

       
    }
}
