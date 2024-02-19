using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float forwardForce=2000f;
    public float sidewaysForce = 500f;

    public void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime ,0 , 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();  
        }


    }
}
