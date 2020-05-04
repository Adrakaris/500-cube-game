using UnityEngine;

public class playerMove : MonoBehaviour {

    public Rigidbody rb;  // reference rigid body -- public allows unity to access

    public float forwardForce = 1000f;
    public float strafeSpeed = 600f;

    // Start is called before the first frame update
    void Start() {
        // Debug.Log("Hello world");
    }

    // Update is called once per frame
    // FixedUpdate is preferable if used for physics
    void FixedUpdate() {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // x, y, z
        // add time.deltatime multiplier to normalise values between different framerates
        // this is then more like forwardForce force per second

        if (Input.GetKey("d")) {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  // x is L/R , force mode on the end
        }
        
        if (Input.GetKey("a")) {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<manager>().gameOver();
        }
    }
}
