using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PScript : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;

    public Animator myanim;
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"))*moveSpeed;
        myanim.SetFloat("moveX", theRB.velocity.x);
        myanim.SetFloat("moveY", theRB.velocity.y);

        // if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horiztonal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        // {
        //     myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
        //     myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        // }
        
    }
}