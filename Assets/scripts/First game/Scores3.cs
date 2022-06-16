using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scores3 : MonoBehaviour
{
    public GameObject panel;
    public GameObject end;
    public GameObject text2;
    private float stop_timer;
 
    
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "end")
        {
            panel.SetActive(true);
            stop_timer = Time.time;
            text2.GetComponent<Text>().text = stop_timer.ToString("0.00");
            //stop_timer = Scores.score;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }


    }
}
