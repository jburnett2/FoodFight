﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour {

	public GameObject testShrimp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			var tmpFood = Instantiate (testShrimp,gameObject.transform);
			Rigidbody foodRig = tmpFood.GetComponent<Rigidbody> ();
			foodRig.AddForce (new Vector3 (0, 0, 10));
		}
	}


}