using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour {

    private Vector3 planePosition;
    private Score score;
    private bool scored;
    private float variablePositionY = 2f;
	[SerializeField]
	private float velocity;

    public void destroy() {
        GameObject.Destroy(this.gameObject);
    }

	private void Awake() {
		this.randomPosition ();
	}

	private void Start() {
        this.planePosition = GameObject.FindObjectOfType<Plane>().transform.position;
        this.score = GameObject.FindObjectOfType<Score>();
	}

    private bool giveScore() {
        return !this.scored && this.planePass();
    }

	private void move() {
		this.transform.Translate (Vector3.left * this.velocity * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        this.destroy();
    }

    private bool planePass() {
        return this.transform.position.x < this.planePosition.x;
    }

	private void randomPosition() {
		this.transform.Translate(Vector3.up * Random.Range(-this.variablePositionY, this.variablePositionY));
	}

    private void Update() {
        this.move();

        if (this.giveScore()) {
            this.score.scored();
            this.scored = true;
        }
    }

}
