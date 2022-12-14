using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundImageChanger : MonoBehaviour
{
    public Sprite[] images;
    public Image image;
    public Slider soundSlider;
    public AudioSource audioSource;


    private void Update()
    {


        audioSource.volume = soundSlider.value;
        if(soundSlider.value == 0)
        {
            image.sprite = images[0];
        }
        else if (soundSlider.value < 0.35)
        {
            image.sprite = images[1];
        }
        else if (soundSlider.value < 0.7)
        {
            image.sprite = images[2];
        }
        else
        {
            image.sprite = images[3];
        }
         
    }
    
}
