using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour {

    public manager manager;

    private void OnTriggerEnter(Collider other) {
        manager.levelComplete();
    }

}
