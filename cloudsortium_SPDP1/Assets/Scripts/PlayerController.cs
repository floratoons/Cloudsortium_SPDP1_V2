using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("A float that instructs character's movement speed")]
    public float moveSpeed;
    [Tooltip("A float that instructs the upwards force of character's jump")]
    public float jumpForce;

    [Tooltip("A float that is the threshold between jumping and falling. Is usually set to 0.")]
    public float fallingThreshold;

    [Tooltip("An int that instructs how many times a character can jump. i.e set to 2 for a double jump")]
    public int jumpsAmount;

    [Tooltip("An int for testing that lets us know how many jumps a character has left")]
    public int jumpsLeft;

    [Tooltip("An float between -1 and 1 that tells us if a character is moving, and if it is moving left or right")]
    public float moveInput;
    [Tooltip("A bool that is true if the character is not moving")]
    public bool isIdle;

    public Rigidbody2D rb2d;
    float scaleX;
    public ContactFilter2D ContactFilter;
    [Tooltip("A bool that is true if the character is touching a collider on the Ground layer")]
    public bool isGrounded => rb2d.IsTouching(ContactFilter);

    [Tooltip("A bool that is true if the character's y velocity is less than fallingThreshold")]
    public bool isFalling = false;
    [Tooltip("A bool that is true if the character's y velocity is less than fallingThreshold")]
    public bool isRising = false;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb2d.velocity.y);
        Debug.Log(fallingThreshold);

        moveInput = Input.GetAxisRaw("Horizontal");
        if(moveInput != 0)
        {
            isIdle= false;
        }
        else
        {
            isIdle = true;
        }
        Jump();
        Rising();
        Falling();
     
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Flip();
        rb2d.velocity = new Vector2(moveInput * moveSpeed, rb2d.velocity.y);
    }

    public void Flip()
    {
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        if (moveInput < 0)
        {
            transform.localScale = new Vector3((-1) * scaleX, transform.localScale.y, transform.localScale.z);
        }
    }

    public void Jump()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            CheckForJumpReset();
            if (jumpsLeft > 0)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                jumpsLeft= jumpsLeft - 1;
            }
           
        }
       
    }

    void Rising()
    {
        //Ball is Rising
        if (rb2d.velocity.y > fallingThreshold)
        {
            isRising = true;
        }
        else
        {
            isRising = false;
        }
    }
    void Falling()
    {
    

        if (rb2d.velocity.y < fallingThreshold)
        {
            isFalling = true;
        }
        else
        {
            isFalling = false;
         
        }
    }

    public void CheckForJumpReset()
    {
        if (isGrounded == true)
        {
           
            ResetJumps();
        }
     
    }



    public void ResetJumps()
    {
        if (isGrounded)
        {
            jumpsLeft = jumpsAmount;// jumpsAmount =2;
            
        }
    }


}

