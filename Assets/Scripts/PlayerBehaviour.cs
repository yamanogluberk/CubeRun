using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody rb;
    
    private GameManager gameManager;
    
    public float sideForce = 500f;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            gameManager.EndGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gameManager.EndGame();
            this.enabled = false;
        }
    }
}