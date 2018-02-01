using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("w")) {
			transform.Translate(0, speed, 0);
				}
		if (Input.GetKeyDown("a")) {
			transform.Translate(-speed, 0, 0);
		}
		if (Input.GetKeyDown("s")) {
			transform.Translate(0, -speed, 0);
		}
		if (Input.GetKeyDown("d")) {
			transform.Translate(speed, 0, 0);
		}
		}
	}
