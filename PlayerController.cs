using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	public Rigidbody rb;
	public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        // if(Input.GetButtonDown("Jump"))
        // {
        // 	rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        // }
        //OnCollisionEnter();
        //				rb.velocity = new Vector3(rb.velocity.x, jumpForce + (Physics.gravity.y * gravityScale), rb.velocity.z);
        //Example();

    }

    void OnCollisionEnter(Collision other){
		//Debug.Log ("collision!");


        //This is to make it jump.
		if(Input.GetButtonDown("Jump"))
		{
			if (other.gameObject.tag == "validfloor") {
				rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
			}

		}
        //This is to switch the scene
        if (other.gameObject.tag == "lastplatform")
        {
            SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lastplatform2")
        {
            SceneManager.LoadScene("EndScreen");
        }
        if (other.gameObject.tag == "killer")
        {
            SceneManager.LoadScene("Level1");
        }
        if (other.gameObject.tag == "killer2")
        {
            SceneManager.LoadScene("Level2");
        }
    }
	

    void OnCollisionStay(Collision other){
		Debug.Log ("collision!");

		if(Input.GetButtonDown("Jump"))
		{
			if (other.gameObject.tag == "validfloor") {
				rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
			}
		}
	}

	// void Example()
 //    {
 //        Physics.gravity = new Vector3(0, -15.0F, 0);
 //    }
}
