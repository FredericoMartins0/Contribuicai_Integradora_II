using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public bool press = false;
    public bool timing = true;

    static float timer = 0.0f;
    public Text text_box;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timing)
        {
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        timer += Time.deltaTime;
        var min = Mathf.Floor(timer / 60);
        var sec = timer % 60;
        text_box.text = string.Format("{0:00} : {1:00}", min, sec);
    }

    public void StartTimer()
    {
        timing = true;
    }

    public void StopTimer()
    {
        timing = false;
    }

    public void ResetTime()
    {
        timer = 0.0f;
        
    }
}
