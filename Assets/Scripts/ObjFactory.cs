using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFactory : MonoBehaviour {

	[SerializeField]
	private float interval = 3f;
	[SerializeField]
	private GameObject obj;
	private float timer;

	private void Awake() {
		this.clearTime ();
	}
	
	private void Update () {
		this.timer -= Time.deltaTime;
		if (this.timeTarget()) {
			GameObject.Instantiate (this.obj, this.transform.position, Quaternion.identity);
			this.clearTime ();
		}
	}

	private bool timeTarget() {
		return this.timer <= 0;
	}

	private void clearTime() {
		this.timer = this.interval;
	}

}
