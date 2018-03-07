using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    private Rigidbody2D rBody;

    public float tumble;

	// Use this for initialization
	void Start ()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        rBody.angularVelocity = Random.value * tumble;

	}

	
}
