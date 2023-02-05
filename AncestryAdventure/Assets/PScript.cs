using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PScript : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;

    public Animator myanim;
    public static PScript instance;
    public string areaTransitionName;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null){
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
 
    // Update is called once per frame
    void Update()
    {
        if (canMove){
            theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"))*moveSpeed;
            myanim.SetFloat("moveX", theRB.velocity.x);
            myanim.SetFloat("moveY", theRB.velocity.y);
        } else{
            theRB.velocity = Vector2.zero;
        }


        // if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horiztonal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        // {
        //     myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
        //     myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        // }
        
    }
}