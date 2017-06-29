using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

	[SerializeField] private Text text;
	[SerializeField] private GameObject ball;
	bool judge = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < -0.1 && !judge) {
			text.text = "Game Over";
		}
	}

	void OnTriggerEnter(){
		text.text = "Game Clear";
		judge = true;
	}
}
