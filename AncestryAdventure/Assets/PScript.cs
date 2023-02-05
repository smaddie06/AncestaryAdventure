using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PScript : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;

    public Animator myanim;
    public string areaTransitionName;
    private Vector3 bottomLeftLimit;
            public static PScript instance;

    private Vector3 topRightLimit;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance==null){
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

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
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);

    }

    public void SetBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottomLeftLimit = botLeft + new Vector3(0.5f, 0.5f, 0f);
        topRightLimit = topRight + new Vector3(-0.5f,-0.5f,0f);
    }
}