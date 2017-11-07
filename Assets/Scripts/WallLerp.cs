using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLerp : MonoBehaviour {
    
	public float movement = 0.5f;
	public bool movingUp = true;

    void Update (){
        //If moving up, move +y
        if(movingUp){
    
        	transform.position = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
    
        //If moving down, move -y
        }else{
    
        	transform.position = new Vector3(transform.position.x, transform.position.y - movement, transform.position.z);
    
        }
    
	}
    
    //Checks collision
    void OnTriggerEnter ( Collider other  ){
        if (other.tag == "Down"){movingUp = false;}
        if (other.tag == "Up"){movingUp = true;}
    }
}
