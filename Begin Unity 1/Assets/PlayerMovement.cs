 using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float fowardForce = 20000f;
    public float sidewayForce = 500f;

	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, fowardForce* Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
	}
}
