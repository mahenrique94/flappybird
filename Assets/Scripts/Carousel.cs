using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour {

    private Vector3 initialPosition;
    private float realSizeImage;
	[SerializeField]
	private float velocity;

	private void Awake() {
		this.initialPosition = this.transform.position;
		this.calculateRealSizeImage ();
	}

	private float calculateDeslocation() {
		return Mathf.Repeat(this.velocity * Time.time, this.realSizeImage);
	}

	private void calculateRealSizeImage() {
		float sizeImage = this.GetComponent<SpriteRenderer> ().size.x;
		float scale = this.transform.localScale.x;
		this.realSizeImage = sizeImage * scale;
	}

	private void move() {
		this.transform.position = this.initialPosition + Vector3.left * this.calculateDeslocation();
	}

    private void Update() {
        this.move();
    }

}
