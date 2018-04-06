using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour {

	[SerializeField]
	private float velocity = 0.5f;

	private void Update () {
		this.transform.Translate (Vector3.left * this.velocity);
	}

}
