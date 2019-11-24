using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileController : MonoBehaviour {
	public GameObject missile;
	public GameObject player;
	public GameObject explosion;
	private float yRotation=0.0f;
	// Use this for initialization
	private Rigidbody2D rb;
	// Update is called once per frame
	void Start(){
		rb = this.GetComponent<Rigidbody2D> ();
		this.transform.eulerAngles = new Vector3(180, yRotation, 0);
	
	}	
		
	private void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "player") {
			Debug.Log ("hit detected");
			Destroy (GameObject.FindWithTag("missile"));
			GameObject a = Instantiate (explosion,this.transform.position, Quaternion.identity) as GameObject;
			Destroy (player.gameObject);
		
		}
			
	}
	
			



	}

