using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour {

	public GameObject testShrimp;
	public float force = 10f;
	public float timerMax = 10;

	private float count = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButton ("Fire1") && count <= 0) {
			var tmpFood = Instantiate (testShrimp,gameObject.transform);
			Rigidbody foodRig = tmpFood.GetComponent<Rigidbody> ();
			foodRig.AddForce (new Vector3 (force, 0, 0));
			count = timerMax;
		}
		count -= Time.deltaTime;
		print (count);
	}


}
