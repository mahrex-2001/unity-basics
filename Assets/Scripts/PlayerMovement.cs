using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float jumpForce = 5f;
    Rigidbody rb;

    [SerializeField] private float xSpeed = 5f;
    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float zSpeed = 5f;
    [SerializeField] private float moveSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        // PrintStuff();

    }

    // Update is called once per frame
    void Update()
    {
        // fly high bob! 
        //transform.Translate(0, yVal, zVal);

        MoveBlud();

        // hehe, u don't call this type of methods in update :3
        // PrintStuff();
    }

    // our blud can move AF 
    void MoveBlud()
    {
        // get x and z value for the player movement
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // moving the player using keyboard
        transform.Translate(xMove, 0, zMove);

        // if player wants to jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpBlud();
        }
    }

    // jumping of the player
    void JumpBlud()
    {
        transform.Translate(0, 1f, 0);
    }

    void PrintStuff()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("You can control the BLUD by 'w', 'a', 's' & 'd' keys!");
        Debug.Log("You Hate Gravity!");
    }
}