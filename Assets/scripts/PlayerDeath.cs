using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject Player;
    public string Enemy;
    private Vector3 SpawnPoint;

    private float Speed = 0.1f;
    private float Rotation = 3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint = new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Rotation,0 , 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Rotation, 0, 0);
        }

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == Enemy)
        {
            Instantiate(Player, SpawnPoint, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
