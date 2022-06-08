using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float jumpForce;

    private bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void JumpCar()
    {
        if (isgrounded) {
            rb.freezeRotation = true;
            rb.AddForce(new Vector2 (0f , jumpForce));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "ground")
        {
            isgrounded = true;
        }
    }


    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "ground")
        {
            isgrounded = false;
        }
    }
}
