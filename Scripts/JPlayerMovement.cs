using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JPlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;
    private SpriteRenderer sprite;

    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle, running, jumping, falling }

    //public Button left;
    //public Button right;
   // public Button jump;
    public Joystick joystick;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update() //Jump code
    {
        float verticalMove = joystick.Vertical;
        //dirX = joystick.Horizontal;

        dirX = joystick.Horizontal;
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if(verticalMove >= .7f && IsGrounded())
        {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        //verticalMove = rb.velocity;
        }

        UpdateAnimationState();
    }


    private void UpdateAnimationState() //animation
    {
        MovementState state;
        //float verticalMove = joystick.Vertical;
        

        if (dirX >= .2f)
        {
            state = MovementState.running;
            sprite.flipX = false; //turn right
        }
        else if (dirX <= -.2f)
        {
            state = MovementState.running;
            sprite.flipX = true; //turn left
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .5f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }


    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
