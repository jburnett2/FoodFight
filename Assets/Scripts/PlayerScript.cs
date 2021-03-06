﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	//public Canvas canvas;
	public int maxHealth = 100;
	public int playerNum = 0;
	public int damage = 5;
	public int health;
	public ThrowFood thow;

	public Text healthText;
	// Use this for initialization
	void Start () {
		health = maxHealth;
		healthText.text = "Health: " + health;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			SceneManager.LoadScene (2);
		}
	}

	void OnCollisionEnter(Collision col){
		
		if (col.gameObject.tag == "Food") {
			health -= damage;
			print (health);
			healthText.text = "Health: " + health;
		}

	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Chipbag") {
			print ("Chips");
			thow.chippedUp = true;
			thow.powerTimer = thow.powerUpCooldown;
		}
	}
		
}
