﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public Transform[] patrolpoints;
	public float movespeed;
	public int currentpoint;


	void Start()
	{
		transform.position = patrolpoints [0].position;
		currentpoint = 0;
	}

	void Update()
	{
		if (transform.position == patrolpoints [currentpoint].position) {
			currentpoint++;
		}
		if (currentpoint >= patrolpoints.Length)
			currentpoint = 0;
		transform.position = Vector3.MoveTowards (transform.position, patrolpoints [currentpoint].position, movespeed * Time.deltaTime);
	}

}