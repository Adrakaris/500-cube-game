using UnityEngine;
using UnityEngine.SceneManagement;

public class onLevelComplete : MonoBehaviour
{
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
