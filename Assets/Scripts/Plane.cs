using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

	private Rigidbody2D physic;
	[SerializeField]
	private int strength = 3;
    private Director director;

	private void Awake () 
    {
		this.physic = this.GetComponent<Rigidbody2D> ();
        this.director = GameObject.FindObjectOfType<Director>();
	}
	
	private void Update () 
    {
		if (this.MouseWasClicked()) 
        {
			this.Impulse ();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        this.physic.simulated = false;
        this.director.EndGame();
	}

	private void Impulse() 
    {
        this.physic.velocity = Vector2.zero;
        this.physic.AddForce (Vector2.up * this.strength, ForceMode2D.Impulse);
	}

	private bool MouseWasClicked() 
    {
		return Input.GetButtonDown ("Fire1");
	}

}
