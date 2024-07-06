using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_00;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject progressBar;

    [SerializeField]
    private GameObject score;

    [SerializeField]
    private GameObject infoText;

    private void Start()
    {
        GameManager.Instance.UIUpdateEvent += UIUpdateHandler;
    }

    private void UIUpdateHandler(object sender, EventArgs e)
    {
        if (e.GetType() != typeof(UIData))
        {
            return;
        }

        UIData uiData = (UIData)e;

        switch (uiData.dataType)
        {
            case "ProgressBar":
                // TODO: Decide if I want this event handler to be in each UI element or in a central UIManager
                progressBar.GetComponent<ProgressBar>().UIUpdate(uiData.data);
                break;
            case "Score":
                score.GetComponent<ScoreUI>().UIUpdate(uiData.data);
                break;
            case "InfoText":
                infoText.GetComponent<InfoText>().UIUpdate(uiData.data);
                break;
        }
    }
}

