using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //variables


    private Rigidbody playerRigidbody;
    private bool IsOnTheGround = true;
    [SerializeField] private float intensityJump;
    public bool IsGameOver = false;
  

    //update

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsOnTheGround == true && IsGameOver == false)
        {
            playerRigidbody.AddForce(Vector3.up * intensityJump, ForceMode.Impulse);
            IsOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnTheGround = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            IsGameOver = true;
        }

       
    }

   


}
