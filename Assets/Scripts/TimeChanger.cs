using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    public GameObject timeManagerGameObject;
    private TimeManagment timeManagment;


    private void Awake()
    {
        timeManagment = timeManagerGameObject.GetComponent<TimeManagment>();
    }

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            timeManagment.timeStartHours = 0;
            timeManagment.timeStartMinutes = 25;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 5;
            timeManagment.longBreak = 25;
        }

        if (val == 1)
        {
            timeManagment.timeStartHours = 0;
            timeManagment.timeStartMinutes = 50;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 10;
            timeManagment.longBreak = 50;
        }

        if (val == 2)
        {
            timeManagment.timeStartHours = 0;
            timeManagment.timeStartMinutes = 1;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 1;
            timeManagment.longBreak = 3;
        }

        if (val == 3)
        {
            timeManagment.timeStartHours = 0;
            timeManagment.timeStartMinutes = 2;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 2;
            timeManagment.longBreak = 5;
        }

        if (val == 4)
        {
            timeManagment.timeStartHours = 0;
            timeManagment.timeStartMinutes = 60;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 5;
            timeManagment.longBreak = 20;
        }

        if (val == 5)
        {
            timeManagment.timeStartHours = 02;
            timeManagment.timeStartMinutes = 0;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 10;
            timeManagment.longBreak = 60;
        }

        if (val == 6)
        {
            timeManagment.timeStartHours = 03;
            timeManagment.timeStartMinutes = 0;
            timeManagment.timeStartSeconds = 0;
            timeManagment.shortBreak = 1;
            timeManagment.longBreak = 20;
        }




        timeManagment.UpdateTimer();
    }
}
