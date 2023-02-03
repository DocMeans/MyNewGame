using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    public float jumpHeight = 10.0f;
    public float leftAndRightInput;
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
        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed * leftAndRightInput);
        // Makes the character jump
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
        
    }
}
