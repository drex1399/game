using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      


       if(Input.GetKeyDown(KeyCode.Space))
        {

        anim.SetTrigger("Jump");
        }     rb.AddForce(Vector2.up);
    }
}




