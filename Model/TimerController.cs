using System.Collections;
using System.Timers;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TMP_Text timer;
    [SerializeField] private float time;
    public static bool TimerStop = false;


    private void Awake()
    {
        StartCoroutine(Timer());
    }


    private IEnumerator Timer()
    {
        while(TimerStop == false)
        {
            yield return new WaitForFixedUpdate();
            time += Time.deltaTime;
            DisplayTime(time);
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timer.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
    }


}
