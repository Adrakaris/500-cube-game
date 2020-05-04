using System;
using UnityEngine;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour {

    public Transform player;
    public Text score;

    bool halt = false;
    float z = 0;

    // toggles tracking of the score
    public void toggleScoreTrack() {
        // Debug.Log("Toggle called");
        halt = !halt;
    }

    // Update is called once per frame
    void Update() {
        if (halt == false) {
            z = player.position.z;
        }
        
        if (z < 0) {  // score does not update if below 0
            z = 0;
        } 

        if (z > 500) {  // score (hopefully) turns green past 500
            score.color = new Color(0f, 0.85f, 0f);
        } else {
            score.color = new Color(0f, 0f, 0f);
        }

        score.text = z.ToString("0");
    }
}
