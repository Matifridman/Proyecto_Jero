using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_point : MonoBehaviour
{
    public Transform tp;
    
    public void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = tp.transform.position + new Vector3(0, 2.5f, 0);
    }
}
