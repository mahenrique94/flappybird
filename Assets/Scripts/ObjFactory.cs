using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFactory : MonoBehaviour {

	[SerializeField]
	private float interval;
	[SerializeField]
	private GameObject obj;
	private float timer;

    public void destroyAll() {
        Obj[] objs = GameObject.FindObjectsOfType<Obj>();
        if (this.hasObjCreatedInScene(objs)) {
            foreach (Obj o in objs) {
                o.destroy();
            }
        }
    }

	private void Awake() {
		this.clearTime ();
	}

	private void buildNewObj() {
		GameObject.Instantiate (this.obj, this.transform.position, Quaternion.identity);
	}

    private void calculateIntervalFromLastExecution() {
        this.timer -= Time.deltaTime;
    }

	private void clearTime() {
		this.timer = this.interval;
	}

    private bool hasObjCreatedInScene(Obj[] objs) {
        return objs.Length > 0;
    }

	private bool timeWasTarget() {
		return this.timer < 0;
	}

    private void Update() {
        this.calculateIntervalFromLastExecution();
        if (this.timeWasTarget()) {
            this.buildNewObj();
            this.clearTime();
        }
    }

}
