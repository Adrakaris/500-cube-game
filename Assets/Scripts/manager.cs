using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour
{

    public float delay = 5f;
    public GameObject completeLevelUI;
    
    bool over = false;

    public void gameOver() {
        if (over == false) {
            over = true;
            toggleScoreTrack();
            // Debug.Log("Game over");
            /*Invoke("restart", delay);  // calls said method after x time
            Invoke("toggleScoreTrack", delay);*/
        }
    }

    public void levelComplete() {
        if (over == false) {
            completeLevelUI.SetActive(true);
        }
    }

    void Update() {
        if (over) {
            if (Input.GetKeyDown("r")) {
                // reloads the scene and turns on score tracking again
                restart();
                toggleScoreTrack();
                over = false;
            }
        }
    }

    void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void toggleScoreTrack() {
        FindObjectOfType<overMessage>().toggleShow();
        FindObjectOfType<scoreTracker>().toggleScoreTrack();
    }

}
