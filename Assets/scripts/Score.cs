using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float scores1;
    public GameObject text;
    
   
    void Update()
    {
        Scores.score = scores1;
        text.GetComponent<Text>().text = scores1.ToString("0.00");
    }
}
