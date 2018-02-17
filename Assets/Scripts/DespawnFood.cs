using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnFood : MonoBehaviour {
	public float timer = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			Destroy (this.gameObject);
		}
		timer -= Time.deltaTime;
	}
}
