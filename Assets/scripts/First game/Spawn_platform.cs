using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_platform : MonoBehaviour
{
    public GameObject Obj;
    public void OnTriggerEnter(Collider other)
    {
        MeshRenderer m = Obj.GetComponent<MeshRenderer>();
        m.enabled = true;
    }
}
