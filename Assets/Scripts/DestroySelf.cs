using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {

    public int time = 3;

	// Use this for initialization
	void Start () {
        Invoke("destroySelf", time);
	}
	

    void destroySelf()
    {
        Destroy(gameObject);
    }
}
