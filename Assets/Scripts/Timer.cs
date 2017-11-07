using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

class Timer : MonoBehaviour
{ 
    public float startTime;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("F0");
        text.text = minutes + ":" + seconds;
        
        
    }

}
