using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

    private Director director;
	private Rigidbody2D physic;
	[SerializeField]
	private int strength = 3;

	private void Awake () {
		this.physic = this.GetComponent<Rigidbody2D> ();
	}

    private void changePhysic(bool state) {
        this.physic.simulated = state;
    }

	private void Impulse() {
        this.physic.velocity = Vector2.zero;
        this.physic.AddForce (Vector2.up * this.strength, ForceMode2D.Impulse);
	}

	private bool MouseWasClicked() {
		return Input.GetButtonDown ("Fire1");
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        this.StopPhysic();
        this.director.EndGame();
    }

    public void Restart() {
        
    }

    private void Start() {
        this.director = GameObject.FindObjectOfType<Director>();
    }

    private void StopPhysic() {
        this.changePhysic(false);
    }

    private void Update() {
        if (this.MouseWasClicked()) {
            this.Impulse();
        }
    }

}
