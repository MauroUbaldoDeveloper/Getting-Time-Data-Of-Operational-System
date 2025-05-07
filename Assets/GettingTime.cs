using UnityEngine;
using UnityEngine.UI;
using System;


public class GettingTime : MonoBehaviour
{

    public Text dateText;

    private void Update()
    {
        dateText.text = "Now: " + DateTime.Now + "\n" + "Utc Now: " + DateTime.UtcNow + "\n" +
                        "Today: " + DateTime.Today + "\n" + "Hours: " + DateTime.Now.Hour + " : " +
                        "Minutes: " + DateTime.Now.Minute + " : " + "Seconds: " + DateTime.Now.Second + "\n" +
                        "Miliseconds: " + DateTime.Now.Millisecond + "\n" + "Ticks: " + DateTime.Now.Ticks + "\n" +
                        "Day of Week: " + DateTime.Now.DayOfWeek + "\n" + "Day of Year: " + DateTime.Now.DayOfYear;
    }

}