using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    
    public string Death_point;
    private Vector3 Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        Spawnpoint = new Vector3(-38.1f, 6f, 3.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Death_point)
        {
            Instantiate(gameObject, Spawnpoint, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
