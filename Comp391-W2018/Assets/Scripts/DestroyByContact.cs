using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosionAsteroid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTrigeerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundary")
        {
            return;
            //Debug.Log("DestroyByContact");
        }

        Instantiate(explosionAsteroid, this.transform.position, this.transform.rotation);

        Destroy(other.gameObjet); // Destroy the other thing (laser)
        Destroy(this.gameObject); // Destroying this thing (the asteroid)        

    }
}
