using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	float speed;
	Rigidbody rigidbodyBall;

	// Use this for initialization
	void Start () {
		rigidbodyBall = GetComponent<Rigidbody> ();
		speed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("up")){
			rigidbodyBall.AddForce (transform.forward * speed, ForceMode.Force);
		}

		if (Input.GetKey("right")){
			rigidbodyBall.AddForce (transform.right * speed, ForceMode.Force);
		}

		if (Input.GetKey("left")){
			rigidbodyBall.AddForce (transform.right * -1.0f * speed, ForceMode.Force);
		}

		if (Input.GetKey("down")){
			rigidbodyBall.AddForce (transform.forward * -1.0f * speed, ForceMode.Force);
		}

		if (Input.GetButtonDown ("Jump")) {
			rigidbodyBall.AddForce (new Vector3 (0, 10, 0), ForceMode.Impulse);
		}
	}
}
