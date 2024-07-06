using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_00
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public event EventHandler<EventArgs> GameOverEvent;
        public event EventHandler<EventArgs> StartGameEvent;
        public event EventHandler<EventArgs> UIUpdateEvent;

        private bool isGameRunning;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }

            isGameRunning = false;
        }

        private void Start()
        {
            OnUIUpdate(new UIData("InfoText", new Dictionary<string, object>() { { "infoText", "Press Space to Start" } }));
        }

        private void Update()
        {
            if (!isGameRunning && Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
        }

        public void OnGameOver()
        {
            Debug.Log("Game Over");
            OnUIUpdate(new UIData("InfoText", new Dictionary<string, object>() { { "infoText", "Game Over\nPress Space to Play Again" } }));
            GameOverEvent?.Invoke(this, EventArgs.Empty);
            isGameRunning = false;
        }

        private void StartGame()
        {
            Debug.Log("Starting Game");
            isGameRunning = true;
            OnUIUpdate(new UIData("InfoText", new Dictionary<string, object>() { { "infoText", "" } }));
            StartGameEvent?.Invoke(this, EventArgs.Empty);
        }

        public void OnUIUpdate(EventArgs e)
        {
            UIUpdateEvent?.Invoke(this, e);
        }
    }
}

