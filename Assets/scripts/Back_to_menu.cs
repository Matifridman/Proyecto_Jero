using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_to_menu : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "end")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (col.gameObject.tag == "Back")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }

    }
}
