using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Camera cam;
    
    public Animator animator;

    public int movementSpeed = 4;
    
    Vector2 mvmnt;
    public float animspeed;
    public bool facingRight = false;


    void Update()
    {
        mvmnt.x = Input.GetAxisRaw("Horizontal");
        mvmnt.y = Input.GetAxisRaw("Vertical");
        animspeed = Mathf.Abs(mvmnt.x) + Mathf.Abs(mvmnt.y);
        animator.SetFloat("speed", Mathf.Abs(animspeed*movementSpeed));
        
    }


    private void FixedUpdate()
    {
        if (mvmnt.x > 0 && facingRight)
        {
            Flip();
        }
        else if(mvmnt.x < 0 && !facingRight)
        {
            Flip();
        }
        rb.MovePosition(rb.position + mvmnt * movementSpeed * Time.fixedDeltaTime);

    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
    
    


}
