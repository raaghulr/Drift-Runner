using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody player;
	Vector3  input ;
	public float movespeed=10;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		if (player.velocity.magnitude < 10) {
			player.AddForce (input * movespeed);
		}
	}
}
