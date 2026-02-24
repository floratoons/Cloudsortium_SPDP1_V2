using UnityEngine;

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