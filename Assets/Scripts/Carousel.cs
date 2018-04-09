using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour {

    private Vector3 initialPosition;
    private float realSizeImage;
	[SerializeField]
	private float velocity = 5f;

	private void Awake() 
    {
		this.initialPosition = this.transform.position;
		this.CalculateRealSizeImage ();
	}

	private float CalculateDeslocation() 
    {
		return Mathf.Repeat(this.velocity * Time.time, this.realSizeImage);
	}

	private void CalculateRealSizeImage() 
    {
		float sizeImage = this.GetComponent<SpriteRenderer> ().size.x;
		float scale = this.transform.localScale.x;
		this.realSizeImage = sizeImage * scale;
	}

	private void Move() 
    {
		this.transform.position = this.initialPosition + (Vector3.left * this.CalculateDeslocation());
	}

    private void Update()
    {
        this.Move();
    }

}
