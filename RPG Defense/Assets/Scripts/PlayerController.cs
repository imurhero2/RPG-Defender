using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(h * speed * Time.deltaTime, v * speed * Time.deltaTime);
		}
	}
