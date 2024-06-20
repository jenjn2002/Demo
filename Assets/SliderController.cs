using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Button button;

    public void OnSliderValueChange(float value)
    {
        Debug.Log("current value" + value);
        button.transform.Translate(value,0, 0);

    }




}
