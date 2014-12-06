﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerProjectile : MonoBehaviour {

	public Vector3 spawnDirection;

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("BULLET COLLISION: "+coll.gameObject.tag);
		if (coll.gameObject.tag == "Wall") {
			GameObject.Destroy (this);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log ("BULLET TRIGGER: "+coll.gameObject.tag);
		if (coll.gameObject.tag == "Wall") {
			GameObject.Destroy (gameObject);
		}
	}
}
