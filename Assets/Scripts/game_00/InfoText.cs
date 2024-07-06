using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoText : MonoBehaviour
{
    public void UIUpdate(Dictionary<string, object> data)
    {
        GetComponent<TextMeshProUGUI>().text = (string)data.GetValueOrDefault("infoText", "");
    }
}
