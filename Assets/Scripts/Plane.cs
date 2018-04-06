using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

	private Rigidbody2D physic;
	[SerializeField]
	private int strength = 10;

	private void Awake () {
		this.physic = this.GetComponent<Rigidbody2D> ();
	}
	
	private void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			this.Impulse ();
		}
	}

	private void Impulse() {
		this.physic.AddForce (Vector2.up * this.strength, ForceMode2D.Impulse);
	}

}
