using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottomScript : MonoBehaviour {
	public Text ScoreText;
	public int score;
	// Use this for initialization
	void Update () {
		ScoreText.text = "" + score;
	}
	
	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D other){
			if (other.gameObject.tag == "missile") {
				Debug.Log ("hit detected");
				Destroy(other.gameObject);
			score += 1;
			}
	
}
}