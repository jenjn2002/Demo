using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public Text text;
    public int count = 0;
    
    public void OnButtonClick()
    {
        Debug.Log("Clicked");
        text.text = "";
        count++;
        text.text += count;
    }
}
