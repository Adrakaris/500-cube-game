using UnityEngine;
using UnityEngine.UI;

public class overMessage : MonoBehaviour {

    public Text over;
    
    bool show = false;

    public void toggleShow() {
        // Debug.Log("Show toggle");
        show = !show;
    }

    // Update is called once per frame
    void Update() { 
        if (show) {
            over.GetComponent<Text>().enabled = true;
        } else {
            over.GetComponent<Text>().enabled = false;
        }
    }
}
