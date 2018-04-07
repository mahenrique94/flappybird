using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour {

	[SerializeField]
	private float velocity = 5f;
	private float variablePositionY = 2f;

	private void Awake() 
    {
		this.RandomPosition ();
	}

	private void Update () 
    {
		this.Move ();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        this.Destroy();
	}

	private void Move() 
    {
		this.transform.Translate (Vector3.left * this.velocity * Time.deltaTime);
	}

	private void RandomPosition() 
    {
		this.transform.Translate(Vector3.up * Random.Range(-this.variablePositionY, this.variablePositionY));
	}

	private void Destroy() 
    {
        GameObject.Destroy(this.gameObject);
	}

}
