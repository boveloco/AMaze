﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour {


    AudioSource destroySound;

    void Awake()
    {
        destroySound = GetComponent<AudioSource>();  
        destroySound.enabled = true;  
    }

    private void OnCollisionEnter (Collision collision) {
        destroySound.Play ();
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