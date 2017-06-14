using UnityEngine;
using System.Collections;

public class animatorcontrol : MonoBehaviour {
	private Animator animator;
	private bool mov;
	private bool jump;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		mov = false;
		jump = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey ("right") || Input.GetKey ("left"))
			mov = true;
		else
			mov = false;
		animator.SetBool ("move", mov);
		animator.SetBool ("jump", jump);
	}
	void OnTriggerStay2D (Collider2D other){
        if (other.gameObject.CompareTag("ground"))
        {
            jump = false;
            move.onGround = true;
        }
        else
        {
            jump = true;
            move.onGround = false;
        }
	}
	/*void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.CompareTag ("ground")) {
			jump = true;
			move.onGround = false;
		}
	}*/
}
