using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

	private Rigidbody2D physic;

	private void Awake () {
		this.physic = this.GetComponent<Rigidbody2D> ();
	}
	
	private void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			this.Impulse ();
		}
	}

	private void Impulse() {
		this.physic.AddForce (Vector2.up * 10, ForceMode2D.Impulse);
	}

}
