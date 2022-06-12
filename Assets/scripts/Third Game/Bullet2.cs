using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    bool gun = true;

    public GameObject bullet;
    public Transform bulletSpawn = null;
    public GameObject thePlayer;
 
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;

       /* while (thePlayer==true) 
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            
        }*/
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }


}
