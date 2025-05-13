using UnityEngine;

//class selcet
public class PlayerMovement : MonoBehaviour
{
    //variables 
    public Rigidbody rb;
    [SerializeField] float forwardForce = 2000f;
    [SerializeField] float sidewaysForce = 500f;
    
 

    // Function
    // We marked this as "fixed" Update because we are using it to mess with physics.
    void FixedUpdate()
    {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime); //method

        if (Input.GetKey("d"))                            //exeption from method
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))                            //exeption from method
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // if (rb.position.y < -1f)                          //exeption from method
        // {
        //     FindObjectOfType<GameManager>().EndGame();
        // }
        //Jump_2
        // if (Input.GetButtonDown("Jump"))
        //{
        //        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        //}

    }
}