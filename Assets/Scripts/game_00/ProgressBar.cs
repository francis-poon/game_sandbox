using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private Image progressBar;

    private float maxValue;
    private float currentValue;

    private void Awake()
    {
        maxValue = 1f;
        currentValue = 0f;
    }

    public void UIUpdate(Dictionary<string, object> data)
    {
        maxValue = (float)data.GetValueOrDefault("maxValue", 1);
        currentValue = (float)data.GetValueOrDefault("currentValue", 1);
    }

    public void Update()
    {
        progressBar.fillAmount = currentValue / maxValue;
    }
}
