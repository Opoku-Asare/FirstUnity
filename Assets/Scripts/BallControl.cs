using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{

    public float rotationSpead = 100.00f;
    private Rigidbody rb;
    public float jumpHeight = 8f;
    private bool ballonned = false;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
    {
       // rotating a ball
        var rotation = Input.GetAxis("Horizontal") * rotationSpead;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);

        // jumping 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, jumpHeight, 0);
           // ballonned = true;
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //break
        //}
      

    }
}
