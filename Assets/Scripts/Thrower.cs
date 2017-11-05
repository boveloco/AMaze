using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Thrower : MonoBehaviour {

    public float timeInBetween = 2.0f;
    /* Restart - Exit - End */
    public GameObject projectile;

    private void Start()
    {
        InvokeRepeating("launchProjectile", 2.0f, timeInBetween);
    }

    void launchProjectile()
    {
        var obj = Instantiate(projectile, transform.position + new Vector3(1, 0, 0) , Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
    
}
