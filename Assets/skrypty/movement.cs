using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    private float moveVelocity;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private Animator anim;
    private Rigidbody2D myrigidbody2D;
    public AudioSource jump;

    public bool onLadder;
    public float climbSpeed;
    private float climbVelocity;
    private float gravityStore;
    



    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        myrigidbody2D= GetComponent<Rigidbody2D>();
        gravityStore = myrigidbody2D.gravityScale;
    }

    

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight * Time.deltaTime);
            jump.Play();
        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed * Time.deltaTime;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); //czy dotyka ziemi

        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x)); //animacje
        if(GetComponent<Rigidbody2D>().velocity.x>0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f); //wszystko zostaje takie samo bez zmian
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);    //odwraca animacje (jeżeli idziemy w lewo)
        }
        anim.SetBool("Grounded", grounded);

        if(onLadder)
        {
            myrigidbody2D.gravityScale = 0f;
            climbVelocity = climbSpeed * Input.GetAxisRaw("Vertical");
            myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, climbVelocity);
        }

        if (!onLadder)
        {
            myrigidbody2D.gravityScale = gravityStore;
        }

        
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag=="platform")
        {
            transform.parent = other.transform;           
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "platform")
        {
            transform.parent = null;
        }
    }
}
