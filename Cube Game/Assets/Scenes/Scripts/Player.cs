using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 10f;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
   /* public float jump = 5;
    private bool isOnGround = true;*/


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /* if (Input.GetKeyDown("space") && isOnGround)
         {
             rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
             isOnGround = false;
         }*/

        /*float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
         float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;*/

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerUpdate>().EndGame();
        }
    }

    /* void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }*/
}
