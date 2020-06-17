using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour
{

  public Rigidbody rb;

      public float forwardForce = 2000f;
      public float backwardForce = 2000f;
      public float rightForce = 2000f;
      public float upForce = 2000f;
      public float jumpSpeed = 7f;
      private bool onGround = true;

   
 
     void start()
    {
      rb = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {

     rb.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);

    

        if (Input.GetKey("s"))
        {
          rb.AddForce(0,0,-backwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

      if(Input.GetKey("d"))
      {
        rb.AddForce(rightForce * Time.deltaTime , 0 , 0,ForceMode.VelocityChange);
      }

        else if(Input.GetKey("a"))
        {
          rb.AddForce(-rightForce * Time.deltaTime , 0 , 0,ForceMode.VelocityChange);
        }
      if(Input.GetKey("z"))
      {
        rb.AddForce(0, upForce * Time.deltaTime , 0,ForceMode.VelocityChange);
      }

        else if(Input.GetKey("x"))
        {
          rb.AddForce(0, -upForce * Time.deltaTime  , 0,ForceMode.VelocityChange);
        }
      if (rb.position.y <= 1f)
      {
        FindObjectOfType<GameManager>().EndGame();
      }

      if (Input.GetKeyDown("space") && onGround)
      {
        rb.AddForce(Vector3.up *jumpSpeed, ForceMode.Impulse);
        onGround = false;
      }

    }
void OnCollisionEnter(Collision collision)
    {
      onGround = true;
    }

      

}