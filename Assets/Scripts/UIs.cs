using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIs : MonoBehaviour
{
    public GameObject infoButton;
    public GameObject hamburgerIcon;

    private bool hamburgerMenuActive = false;


    public void ClickInfoButton()
    {
        if (infoButton.activeSelf)
        {
            infoButton.SetActive(false);

        }
        else
        {
            MoveHamburgerIn();
            infoButton.SetActive(true);
            hamburgerMenuActive = false;

        }
    }

    public void ClickHamburgerButton()
    {
        if (!hamburgerMenuActive)
        {
            MoveHamburgerOut();
            hamburgerMenuActive = true;
            infoButton.SetActive(false);

        }
        else
        {
            infoButton.SetActive(false);
            MoveHamburgerIn();
            hamburgerMenuActive = false;

        }
    }


    public void ClickQuitButton()
    {
        Application.Quit();
    }

    public void ShkipperButton()
    {
        Application.OpenURL("http://titberidze.com/");
    }

    public void MoveHamburgerOut()
    {
        hamburgerIcon.transform.position = hamburgerIcon.transform.position + new Vector3(1000, 0, 0);
    }

    public void MoveHamburgerIn()
    {
        hamburgerIcon.transform.position = hamburgerIcon.transform.position - new Vector3(1000, 0, 0);
    }

}
