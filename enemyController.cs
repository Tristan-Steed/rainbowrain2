using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {
	
	public GameObject missile;
	public GameObject player;
	public GameObject enemy;
	public float speed = 1.0f;
	private Vector2 screenBounds;
	Camera cam;
	Vector2 border;

	// Use this for initialization
	private Rigidbody2D rb;
	// Use this for initialization
	public float min=-0.5f;
	public float max=0.5f;
	public float[] offset = { 0.1f, 0.0f,0.1f,0.1f };
	// Use this for initialization
	void Start() {

		min=transform.position.x-0.5f;
		max=transform.position.x+0.5f;
		rb = GetComponent<Rigidbody2D>();
		StartCoroutine (dropMissile ());
		Debug.Log ("Screen width world: "+border.y);
	}
	/*
	bool inOverRange(float num){
		if ((num - 0.1*Random.Range(0,2)) < (this.transform.position.x) && (this.transform.position.x) < num ){
			return true;
		} 
		else {
			return false;
		}
	}
	bool inUnderRange(float num){
		if ((num +0.1*Random.Range(1,3)) > (this.transform.position.x) && (this.transform.position.x) >num) {
			return true;
		} 
		else {
			return false;
		}
	}
	*/
	// Update is called once per frame
		void Update() {
		float step = Time.time;
		//Mathf.PingPong (Time.time * 2, Random.Range(max,min)) + min
		transform.position = new Vector2(Mathf.PingPong (Time.time * 2,max-min)+min, transform.position.y);
		int randomPutarbence = Random.Range (0,3);
		/*
		if (randomPutarbence == 3) {
			this.transform.position=Vector2.MoveTowards(this.transform.position,new Vector2(-2, transform.position.y),step*2);
		}
		if (randomPutarbence == 4) {
			this.transform.position=Vector2.MoveTowards(this.transform.position,new Vector2(3, transform.position.y),step*2);
		}*//*
		if (inOverRange(max) || inOverRange(0) || inUnderRange(min)){
			dropMissile ();
		}*/

	}
	IEnumerator dropMissile(){
		while (true) {
			yield return new WaitForSeconds (0.4f);
			GameObject a = Instantiate (missile, new Vector2 (Random.Range (-2, 3), 3), Quaternion.identity) as GameObject;

		}
		
	
	}


}