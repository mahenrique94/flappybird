using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

    private Director director;
	private Rigidbody2D physic;
    private Vector3 startPosition;
	[SerializeField]
	private int strength = 3;

    public void restart() {
        this.transform.position = this.startPosition;
        this.changePhysic(true);
    }

	private void Awake () {
		this.physic = this.GetComponent<Rigidbody2D> ();
        this.startPosition = this.transform.position;
	}

    private void changePhysic(bool state) {
        this.physic.simulated = state;
    }

	private void impulse() {
        this.physic.velocity = Vector2.zero;
        this.physic.AddForce (Vector2.up * this.strength, ForceMode2D.Impulse);
	}

	private bool mouseWasClicked() {
		return Input.GetButtonDown ("Fire1");
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        this.stopPhysic();
        this.director.endGame();
    }

    private void Start() {
        this.director = GameObject.FindObjectOfType<Director>();
    }

    private void stopPhysic() {
        this.changePhysic(false);
    }

    private void Update() {
        if (this.mouseWasClicked()) {
            this.impulse();
        }
    }

}
