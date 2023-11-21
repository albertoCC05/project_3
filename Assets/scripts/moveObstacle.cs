using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerController playerScript;


    private void Start()
    {
        playerScript = FindObjectOfType<PlayerController>();

    }

    private void Update()
    {
        if (playerScript.IsGameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        

    }
}
