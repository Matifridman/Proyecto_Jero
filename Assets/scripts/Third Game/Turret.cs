using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform targetTr;
    void Update()
    {

        Quaternion lookRotation = Quaternion.LookRotation(targetTr.position - transform.position);
        transform.rotation = lookRotation;
    }
}
