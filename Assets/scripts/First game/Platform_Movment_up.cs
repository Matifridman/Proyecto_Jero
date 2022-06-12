using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movment_up : MonoBehaviour
{
    bool Movment = true;



    void Update()
    {
        if (Movment == true)
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
        else
        {
            transform.position -= new Vector3(0, 0.1f, 0);
        }
        if (transform.position.y > 13.6f)
        {
            Movment = false;
        }
        if (transform.position.y < -13.6f)
        {
            Movment = true;
        }
    }
}
