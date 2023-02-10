using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private float walkSpeed = 5.0f; 
    private float jumpStrength = 5.0f;
    private float leftAndRightInput;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       //player input
        leftAndRightInput = Input.GetAxis("Horizontal");

        // Moves character left or right
        transform.Translate(leftAndRightInput * Time.deltaTime * walkSpeed * Vector3.forward);

        // Makes the character jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.VelocityChange);       
        }
    }
}
