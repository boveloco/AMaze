using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour {
	
    private void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Player") {
            Invoke ("Restart", 0.2f);
            return;
        }
        Destroy (gameObject);
    }

    void Restart () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
    }
}