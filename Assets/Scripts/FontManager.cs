using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FontManager : MonoBehaviour
{
    public TMP_FontAsset[] fontStyles;
    private TMP_FontAsset currentFont;

    public GameObject[] texts;
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            currentFont = fontStyles[0];
        }

        if (val == 1)
        {
            currentFont = fontStyles[1];
        }

        if (val == 2)
        {
            currentFont = fontStyles[2];
        }

        if (val == 3)
        {
            currentFont = fontStyles[3];
        }

        if (val == 4)
        {
            currentFont = fontStyles[4];
        }

        if (val == 5)
        {
            currentFont = fontStyles[5];
        }

        if (val == 6)
        {
            currentFont = fontStyles[6];
        }



        foreach(GameObject tmpTexts in texts)
        {
            var tmp = tmpTexts.GetComponent<TextMeshProUGUI>();
            tmp.font = currentFont;
        }
    }

}
