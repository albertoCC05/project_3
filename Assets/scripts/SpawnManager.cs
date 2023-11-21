using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnArray;
    private float timeDelay = 3;
    private float startDelay = 2;
    private int obstacleIndex;
    private PlayerController playerScript;

    private void spawnRandomObstacle()
    {
        if (playerScript.IsGameOver == false)
        {
            obstacleIndex = Random.Range(0, spawnArray.Length);

            Instantiate(spawnArray[obstacleIndex], new Vector3(20, 0, 0), Quaternion.identity);
        }
        
       
    }

  


    private void Start()
    {
        playerScript = FindObjectOfType<PlayerController>();

       
        
        InvokeRepeating("spawnRandomObstacle", startDelay, timeDelay);

    }

    



}
