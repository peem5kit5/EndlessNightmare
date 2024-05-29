using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    public TextMeshProUGUI timeCount;
    private float sec;
    int minuteCount;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        timeCount.text = minuteCount + "m: " + (int)sec + "s";
        if (sec >= 60)
        {
            minuteCount++;
            sec = 0;
        }
    }
}
