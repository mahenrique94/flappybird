using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour {

    private float variablePositionY = 2f;
	[SerializeField]
	private float velocity = 5f;

    public void destroy() {
        GameObject.Destroy(this.gameObject);
    }

	private void Awake() {
		this.randomPosition ();
	}

	private void move() {
		this.transform.Translate (Vector3.left * this.velocity * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        this.destroy();
    }

	private void randomPosition() {
		this.transform.Translate(Vector3.up * Random.Range(-this.variablePositionY, this.variablePositionY));
	}

    private void Update() {
        this.move();
    }

}
