using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public Color[] colors;
    public Color[] colorAntis;
    

    [Header("TextsPlus")]
    public GameObject[] textGameObjectsPlus;
    [Header("TextsMinus")]
    public GameObject[] textgameObjectsMinus;

    [Header("ImagesPlus")]
    public GameObject[] imageGameObjectsPlus;
    [Header("ImagesMinus")]
    public GameObject[] imageGameObjectsMinus;

    public Camera myCam;

    private Color currentColor;
    private Color currentColorAnti;
    


    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            currentColor = colors[0];
            currentColorAnti = colorAntis[0];
        }

        if (val == 1)
        {
            currentColor = colors[1];
            currentColorAnti = colorAntis[1];
        }

        if (val == 2)
        {
            currentColor = colors[2];
            currentColorAnti = colorAntis[2];
        }

        if (val == 3)
        {
            currentColor = colors[3];
            currentColorAnti = colorAntis[3];
        }

        if (val == 4)
        {
            currentColor = colors[4];
            currentColorAnti = colorAntis[4];
        }

        if (val == 5)
        {
            currentColor = colors[5];
            currentColorAnti = colorAntis[5];
        }

        if (val == 6)
        {
            currentColor = colors[6];
            currentColorAnti = colorAntis[6];
        }




        foreach (GameObject textGameObjectPlus in textGameObjectsPlus)
        {
            var tmpro = textGameObjectPlus.GetComponent<TextMeshProUGUI>();
            tmpro.color = new Color (currentColor.r, currentColor.g, currentColor.b, 1f);
        }

        foreach (GameObject textGameObjectMinus in textgameObjectsMinus)
        {
            var tmpro1 = textGameObjectMinus.GetComponent<TextMeshProUGUI>();
            tmpro1.color = new Color(currentColorAnti.r, currentColorAnti.g, currentColorAnti.b, 1f);
        }

        foreach (GameObject imageGameObjectPlus in imageGameObjectsPlus)
        {
            var tmpro2 = imageGameObjectPlus.GetComponent<Image>();

            tmpro2.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
        }

        foreach (GameObject imageGameObjectMinus in imageGameObjectsMinus)
        {
            var tmpro3 = imageGameObjectMinus.GetComponent<Image>();
            tmpro3.color = new Color(currentColorAnti.r, currentColorAnti.g, currentColorAnti.b, 1f);
        }

        myCam.backgroundColor = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
    }
}
