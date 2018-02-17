using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour {

	public GameObject testShrimp;
	public float force = 10f;
	public float timerMax = 10f;

	public bool chippedUp = false;
	public float powerUpCooldown = 2f;

	public float powerTimer = 0f;
	public float count = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (chippedUp) {
			if (Input.GetButton ("Fire1")) {
				var tmpFood = Instantiate (Resources.Load("Prefabs/chip")as GameObject,gameObject.transform);
				Rigidbody foodRig = tmpFood.GetComponent<Rigidbody> ();
				foodRig.AddForce (transform.forward * force);
				powerTimer -= Time.deltaTime;
				if (powerTimer <= 0) {
					chippedUp = false;
				}
			}
		}
		else if ((Input.GetButton ("Fire1") || Input.GetAxisRaw("Fire2")==1) && count <= 0) {
			var randFood = Random.Range (0, 17);
			var tmpFood = Instantiate (Resources.Load("Prefabs/" +randFood)as GameObject,gameObject.transform);
			Rigidbody foodRig = tmpFood.GetComponent<Rigidbody> ();
			foodRig.AddForce (transform.forward * force);
			count = timerMax;
		}
		count -= Time.deltaTime;
		//print (count);
	}

	void OnCollisionEnter(Collision col){
		print("Colliding");
		if (col.gameObject.tag == "Chipbag") {
			chippedUp = true;
			powerTimer = powerUpCooldown;
		}
	}

}
