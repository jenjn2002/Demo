using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Button buttonResult;
    [SerializeField] InputField input;
    [SerializeField] Text output;
    public void OnButtonClick()
    {
        
    }

    public string ReturnNumber(Button button)
    {
        Text text = button.GetComponentInChildren<Text>();
        return text.text;
    }
    
    public void InputText(string text)
    {
        input.text += ReturnNumber(button);
    }
    
    public void Clear()
    {
        input.text = "";
    }


}
