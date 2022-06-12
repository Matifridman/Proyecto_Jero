using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movment : MonoBehaviour
{
    bool Movment = true;
    

    
    void Update()
    {
        if (Movment == true)
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        else
        {
            transform.position -= new Vector3(0, 0, 0.1f);
        }
        if (transform.position.z > -3.38f)
        {
            Movment = false;
        }
        if (transform.position.z < -28)
        {
            Movment = true;
        }
    }
}