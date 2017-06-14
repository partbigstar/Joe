using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitwall : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.CompareTag ("ground"))
			move.wall = true;
	}
	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.CompareTag ("ground"))
			move.wall = false;
	}
}
