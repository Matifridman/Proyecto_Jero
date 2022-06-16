using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_to_menu : MonoBehaviour
{
    public GameObject text;
    public GameObject text2;
    public GameObject Confeti;
    private Vector3 Spawnpoint2;

    float stop_timer;
    void start()
    {
        Spawnpoint2 = new Vector3(-322.86f, 23, 387.09f);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Back")
        {
           
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                for (int i = 1; i < 95; i++)
                {
                    Instantiate(Confeti);
                    Destroy(Confeti, 2);
                }

            

        }
    }



    void Update()
    {
        text.GetComponent<Text>().text = Time.time.ToString("0.00");

    }
    public void back_menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void back()
    {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }
}

