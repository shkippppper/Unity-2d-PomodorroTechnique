using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TomatoManager : MonoBehaviour
{
    public GameObject timeManagerGameObject;
    private TimeManagment timeManagment;

    public GameObject[] tomatos;

    private void Awake()
    {
        timeManagment = timeManagerGameObject.GetComponent<TimeManagment>();
    }

    private void Update()
    {
        if (timeManagment.longBreakTime)
        {
            tomatos[0].SetActive(true);
            tomatos[1].SetActive(true);
            tomatos[2].SetActive(true);
            tomatos[3].SetActive(true);
        }

        else if(timeManagment.cycle == 0)
        {
            tomatos[0].SetActive(false);
            tomatos[1].SetActive(false);
            tomatos[2].SetActive(false);
            tomatos[3].SetActive(false);
        }
        else if (timeManagment.cycle == 1)
        {
            tomatos[0].SetActive(true);
            tomatos[1].SetActive(false);
            tomatos[2].SetActive(false);
            tomatos[3].SetActive(false);
        }
        else if (timeManagment.cycle == 2)
        {
            tomatos[0].SetActive(true);
            tomatos[1].SetActive(true);
            tomatos[2].SetActive(false);
            tomatos[3].SetActive(false);
        }
        else if (timeManagment.cycle == 3)
        {
            tomatos[0].SetActive(true);
            tomatos[1].SetActive(true);
            tomatos[2].SetActive(true);
            tomatos[3].SetActive(false);
        }
    }




}
