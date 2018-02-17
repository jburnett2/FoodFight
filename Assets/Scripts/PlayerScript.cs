using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	public Canvas canvas;
	public int maxHealth = 100;
	public int playerNum = 0;
	public int damage = 5;
	public int health;

	public Text healthText;
	// Use this for initialization
	void Start () {
		health = maxHealth;
		healthText.text = "Health: " + health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Food") {
			health -= damage;
			print (health);
			healthText.text = "Health: " + health;
		}
	}
}
