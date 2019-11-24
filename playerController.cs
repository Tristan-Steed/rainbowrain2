using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public float ScreenWidth=Screen.width;
	private float speed = 20.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;

		if (Input.GetKey("right")) {
				//move right
			this.transform.position = Vector2.MoveTowards(this.transform.position,new Vector2(2, transform.position.y),step);
			}
		if (Input.GetKey("left")) {
				//move left
			this.transform.position =Vector2.MoveTowards(this.transform.position,new Vector2(-2, transform.position.y),step);
			}
		
	}
}
