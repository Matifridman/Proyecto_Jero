using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_to_menu : MonoBehaviour
{
    public GameObject text;
    public GameObject text2;
    float stop_timer;
    private void OnTriggerEnter(Collider col)

    {


        if (col.gameObject.tag == "Back")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
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

