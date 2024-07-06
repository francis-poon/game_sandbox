using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using game_00;
public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float obstacleSpeed;

    [SerializeField]
    private float spawnDelay;

    [SerializeField]
    private new Camera camera;

    private float timeSinceLastSpawn;
    private float leftBound;
    private float rightBound;
    private bool isSpawning;

    private void Awake()
    {
        leftBound = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane)).x;
        rightBound = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane)).x;

        timeSinceLastSpawn = 0f;
        isSpawning = false;
    }

    private void Start()
    {
        GameManager.Instance.StartGameEvent += StartGameHandler;
        GameManager.Instance.GameOverEvent += GameOverHandler;
    }

    private void Update()
    {
        if (!isSpawning)
        {
            return;
        }

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > spawnDelay)
        {
            timeSinceLastSpawn -= spawnDelay;
            GameObject obstacle = Instantiate(obstaclePrefab, new Vector3(UnityEngine.Random.Range(leftBound, rightBound), transform.position.y, 0), Quaternion.identity, transform);
            obstacle.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -obstacleSpeed, 0);
        }
    }

    private void StartGameHandler(object sender, EventArgs eventArgs)
    {
        isSpawning = true;
    }

    private void GameOverHandler(object sender, EventArgs eventArgs)
    {
        isSpawning = false;
    }
}
