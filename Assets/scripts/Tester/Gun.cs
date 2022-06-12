using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    float currReloadTime;
    bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && currReloadTime <= 0)
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            currReloadTime = reloadTime;
        }
    }
}
