using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  
  public Rigidbody rb;
  public float forwardForce = 10f;
   public float backwardForce = -10f;
    public float LForce = -10f;
    public float RForce = 10f;
     //public float jumpForce = 10f;



    // Update is called once per frame
    void FixedUpdate()
    {
       
    
    if (Input.GetKey("w"))
    {
        rb.AddForce(0, 0, forwardForce);
       
    }
     if (Input.GetKey("s"))
    {
        rb.AddForce(0, 0, backwardForce);
       
    }
     if (Input.GetKey("a"))
    {
        rb.AddForce(LForce, 0, 0);
       
    }
     if (Input.GetKey("d"))
    {
        rb.AddForce(RForce, 0, 0);
       
    }
     if (Input.GetKey("d"))
    {
        rb.AddForce(RForce, 0, 0);
       
    }
    

}
}
