using UnityEngine;

public class playerCollision : MonoBehaviour {

    public playerMove movement;

    private void OnCollisionEnter(Collision collision) {

        if (collision.collider.tag == "Obstacle") {  // checks based on tags
            movement.enabled = false;
            FindObjectOfType<manager>().gameOver();
        }
    }

}
