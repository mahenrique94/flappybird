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
		this.ClearTime ();
	}

	private void BuildNewObj() {
		GameObject.Instantiate (this.obj, this.transform.position, Quaternion.identity);
	}

    private void CalculateIntervalFromLastExecution() {
        this.timer -= Time.deltaTime;
    }

	private void ClearTime() {
		this.timer = this.interval;
	}

	private bool TimeWasTarget() {
		return this.timer <= 0;
	}

    private void Update() {
        this.CalculateIntervalFromLastExecution();
        if (this.TimeWasTarget()) {
            this.BuildNewObj();
            this.ClearTime();
        }
    }

}
