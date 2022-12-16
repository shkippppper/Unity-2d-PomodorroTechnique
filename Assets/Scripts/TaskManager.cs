using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public TextMeshProUGUI taskText;
    public TMP_InputField taskInputField;


    private void Update()
    {
        taskText.text = taskInputField.text;
    }


}
