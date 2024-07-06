using System;
using System.Collections.Generic;
using UnityEngine;

using game_00;
public class Score : MonoBehaviour
{
    [SerializeField]
    private float scoreRate;

    private int score;
    private bool isScoring;
    private float scoreTime;

    private void Awake()
    {
        score = 0;
        isScoring = false;
    }

    private void Start()
    {
        GameManager.Instance.StartGameEvent += StartGameHandler;
        GameManager.Instance.GameOverEvent += GameOverHandler;
    }

    private void Update()
    {
        if (!isScoring)
        {
            return;
        }

        scoreTime += Time.deltaTime;
        while (scoreTime > 1/scoreRate)
        {
            score++;
            scoreTime -= 1 / scoreRate;
        }

        GameManager.Instance.OnUIUpdate(new UIData("Score", new Dictionary<string, object>() { { "score", $"Score: {score}" } }));
    }

    private void StartGameHandler(object sender, EventArgs eventArgs)
    {
        score = 0;
        isScoring = true;
    }

    private void GameOverHandler(object sender, EventArgs eventArgs)
    {
        isScoring = false;
        Debug.Log($"Final Score: {score}");
    }
}
