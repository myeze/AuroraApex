using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;



    //lets you see private felds in inspector
    [SerializeField]
    private int extraJumps;
    
    public int extraJumpsValue;
    private bool jumpAgain;

    void Start(){
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0){
            Flip();
        } else if (facingRight == true && moveInput < 0){
            Flip();
        }
    }

    void Flip(){

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Update(){
        float vert = Input.GetAxisRaw("Vertical");

        if (isGrounded == true){
            extraJumps = extraJumpsValue;
        }

        if (vert < .7 && !Input.GetButton("Xbox-A"))
        {
            jumpAgain = true;
        }

        if ((vert >= .8 || Input.GetButton("Xbox-A")) && extraJumps > 0 && jumpAgain){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            jumpAgain = false;

        }   else if ((vert >= .8 || Input.GetButton("Xbox-A")) && extraJumps == 0 && isGrounded == true && jumpAgain){
            rb.velocity = Vector2.up * jumpForce;
            jumpAgain = false;
        }
    }

}
