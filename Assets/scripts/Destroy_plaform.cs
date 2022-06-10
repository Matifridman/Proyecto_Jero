using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_plaform : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
