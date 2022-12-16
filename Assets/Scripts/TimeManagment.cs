using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimeManagment : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public GameObject playButton;
    public GameObject pauseButton;
    public GameObject audioSourceGameobject;
    private SoundManager soundManager;

    public GameObject workGameobject;
    public GameObject breakGameobject;
    public GameObject longBreakGameobject;

    public int timeStartHours;
    public int timeStartMinutes;
    public float timeStartSeconds;
    public int timeShortBreak;
    public int timeLongBreak;

    [SerializeField]
    private int timeHours;
    [SerializeField]
    private int timeMinutes;
    [SerializeField]
    private float timeSeconds;
    public int shortBreak;    
    public int longBreak;

    public bool started = false;

    public int cycle = 0;
    public bool notBreakTime = true;
    public bool longBreakTime = false;

    private void Awake()
    {
        soundManager = audioSourceGameobject.GetComponent<SoundManager>();
    }
    private void Start()
    {
        timeHours = timeStartHours; 
        timeMinutes = timeStartMinutes;
        timeSeconds = timeStartSeconds;
        shortBreak = 5;
        longBreak = 25;
    }

    private void Update()
    {
        if (started)
        {
            timeSeconds -= Time.deltaTime;
            if(timeSeconds <= -0.5001)
            {
                timeSeconds = 59.4999f;
                timeMinutes--;
                if (timeMinutes < 0)
                {
                    timeMinutes = 59;
                    timeHours--;
                }
            }

            if(timeHours == -1)
            {


                if (notBreakTime)
                {
                    notBreakTime = false;
                    cycle++;
                    if (cycle > 3.9f)
                    {
                        longBreakTime = true;
                        timeHours = 0;
                        timeMinutes = longBreak;
                        timeSeconds = 0;
                        cycle = 0;
                        
                    }
                    else 
                    {
                        longBreakTime = false;
                        timeHours = 0;
                        timeMinutes = shortBreak;
                        timeSeconds = 0;
                    }

                }
                else
                {
                    longBreakTime = false;
                    UpdateTimer();
                    notBreakTime = true;
                }

                soundManager.PlayOneSound();

            }

            if (longBreakTime)
            {
                workGameobject.SetActive(false);
                breakGameobject.SetActive(false);
                longBreakGameobject.SetActive(true);
            }

            else if (notBreakTime)
            {
                workGameobject.SetActive(true);
                breakGameobject.SetActive(false);
                longBreakGameobject.SetActive(false);
            }
            else if (!notBreakTime & !longBreakTime)
            {
                workGameobject.SetActive(false);
                breakGameobject.SetActive(true);
                longBreakGameobject.SetActive(false);
            }
            


        }

        
        timeText.text = string.Format("{0:00} : {1:00} : {2:00}", timeHours, timeMinutes, timeSeconds);
    }


    public void StartTimer()
    {
        started = true;
        playButton.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void StopTimer()
    {
        started = false;
        playButton.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void UpdateTimer()
    {
        timeHours = timeStartHours;
        timeMinutes = timeStartMinutes;
        timeSeconds = timeStartSeconds;
        timeShortBreak = shortBreak;
        timeLongBreak = longBreak;
    }

}
