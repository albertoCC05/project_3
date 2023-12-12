using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{

    //variables


    private Rigidbody playerRigidbody;
    private bool IsOnTheGround = true;
    [SerializeField] private float intensityJump;
    public bool IsGameOver = false;
    private Animator playerAnimator;
    [SerializeField] private ParticleSystem death;
    [SerializeField] private ParticleSystem particles;
    private AudioSource playerAudiosource;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip deathClip;

    // FUNCIONES

    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnTheGround == true && IsGameOver == false)
        {
            playerRigidbody.AddForce(Vector3.up * intensityJump, ForceMode.Impulse);
            IsOnTheGround = false;

            playerAnimator.SetTrigger("Jump_trig");
           
            particles.Stop();

            playerAudiosource.PlayOneShot(jumpClip, 0.7f) ;
        }
    }
  

    //update

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudiosource = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnTheGround = true;
            particles.Play();
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            IsGameOver = true;
            int randomDeath = Random.Range(1, 3);
            playerAnimator.SetInteger("DeathType_int",randomDeath);
            playerAnimator.SetBool("Death_b", true);
            death.Play();
            particles.Stop();
            playerAudiosource.PlayOneShot(deathClip, 0.5f);

        }

       
    }

   


}
