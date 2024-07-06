using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_00;
public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;

    private GameObject player;

    private void Start()
    {
        GameManager.Instance.StartGameEvent += StartGameHandler;
        GameManager.Instance.GameOverEvent += GameOverHandler;
    }

    private void StartGameHandler(object sender, EventArgs eventArgs)
    {
        player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity, transform);
    }

    private void GameOverHandler(object sender, EventArgs eventArgs)
    {
        Destroy(player);
    }
}
