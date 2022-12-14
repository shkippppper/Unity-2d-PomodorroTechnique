using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] audioClips;

    private AudioClip currentSound;

    private void Start()
    {
        currentSound = audioClips[0];
    }


    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            currentSound = audioClips[0];
        }

        if (val == 1)
        {
            currentSound = audioClips[1];
        }

        if (val == 2)
        {
            currentSound = audioClips[2];
        }

        if (val == 3)
        {
            currentSound = audioClips[3];
        }

        if (val == 4)
        {
            currentSound = audioClips[4];
        }

        if (val == 5)
        {
            currentSound = audioClips[5];
        }

        if (val == 6)
        {
            currentSound = audioClips[6];
        }


        audioSource.clip = currentSound;
        PlayOneSound();
    }

    public void PlayOneSound()
    {
        audioSource.PlayOneShot(currentSound);
    }

}
