﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 10f;
    public float health = 3;
    Collider2D refObjectCollider;

	private Transform target;
	private int wavepointIndex = 0;

	// Use this for initialization
	void Start () {
		target = Waypoints.points [0];
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance (transform.position, target.position) <= 0.2f) {
			GetNextWaypoint ();
		}

        if (health <= 0) {
            Destroy(gameObject);
        }

	}

    private void OnMouseDown()
    {
        --health;
    }

    void GetNextWaypoint() {
		if (wavepointIndex >= Waypoints.points.Length - 1) {
			Destroy(gameObject);
			return;
		}
			
		wavepointIndex++;
		target = Waypoints.points [wavepointIndex];
	}
}
