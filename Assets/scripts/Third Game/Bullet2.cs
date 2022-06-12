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
    bool can_shhot = false;

    public float reloadTime;
    float currReloadTime;

    
    
    void Update()
    {


        while (can_shhot ==true)
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            bullet.transform.position += bullet.transform.forward * speed;
            currReloadTime = reloadTime;

            Destroy(gameObject, lifeTime);
        }


    }
    void canShoot()
    {
        if (currReloadTime<0)
        {
            can_shhot = false;
        }

        if (currReloadTime >= 0)
        {
            can_shhot = true;
            currReloadTime -= Time.deltaTime;
        }
    }
    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }


}
