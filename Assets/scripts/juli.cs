using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juli : MonoBehaviour
{
    public GameObject bolita;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i< 30; i++)
        {
            Instantiate(bolita);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
