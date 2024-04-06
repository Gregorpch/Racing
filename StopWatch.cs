using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    public bool hasFinished;
    float minutes;
    float seconds;

    public TextMeshProUGUI stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasFinished == false)
        {
            seconds += Time.deltaTime;

            if (seconds >= 60) 
            {
                minutes += 1;
                seconds -= 60;
            }
        }
        int s = Mathf.RoundToInt(seconds);
        int m = Mathf.RoundToInt(minutes);

        stopwatch.text = m + ":" + s;
    }
}
