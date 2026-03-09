/*using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 8f;
    public float jumpForce = 12f;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadius = 0.2f;
    [SerializeField] private LayerMask Ground;

    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, Ground);

       
        float xInput = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(xInput * speed, rb2D.velocity.y);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }
    }

    public void StopMoving()
    {       
        rb2D.velocity = Vector2.zero;
        this.enabled = false;
    }
}
*/

using System;
using System.Collections;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    public float moveSpeed;
    bool isFacingRight = true;
    public float jumpPower;
    bool isGrounded = false;


    Rigidbody2D rb;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public static PlayerMovement Instance; // Add this line

void Awake() {
    Instance = this; // Set the reference when the game starts
}
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        FlipSprite();

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    void FlipSprite()
    {
        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", !isGrounded);

   
    }

    public IEnumerator SpeedBoost()
    {
        float originalSpeed = moveSpeed;
        moveSpeed = 8f;
        yield return new WaitForSeconds(4.0f);
        moveSpeed = originalSpeed;
    }

    public IEnumerator JumpPower()
    {
        float originalJump = jumpPower;
        jumpPower = 15f;
        yield return new WaitForSeconds(4.0f);
        jumpPower = originalJump;
    }

    //timer doesnt need a coroutine here!
    public void StopMoving()
    {
        rb.velocity = Vector2.zero;
        this.enabled = false;
    }

  
}
