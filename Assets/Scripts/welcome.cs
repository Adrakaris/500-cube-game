using UnityEngine;
using UnityEngine.SceneManagement;

public class welcome : MonoBehaviour {

    public void Commence() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
