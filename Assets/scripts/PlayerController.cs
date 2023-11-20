using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //variables


    private Rigidbody playerRigidbody;
    private bool IsOnTheGround = true;
    [SerializeField] private float intensityJump;
  

    //update

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsOnTheGround == true)
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
       
    }


}
