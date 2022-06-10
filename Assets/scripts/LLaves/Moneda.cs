using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Players")
        {
            Destroy(gameObject);
            data.keys += 1; 
            
        }
    }
}
