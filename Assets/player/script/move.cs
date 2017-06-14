using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public Rigidbody2D rb;
	static public bool onGround;		//是否在地面上
	static public bool wall = false;	//是否撞牆
	public float high = 100.0f;			//跳躍高度
	public float speed = 0;				//走路速度

    void jump()
    {
        Vector2 up = new Vector2(0, high);
        //if (Input.GetKey("up") && onGround == true)
        //{
        rb.velocity = new Vector2(rb.velocity.x, high);
        //}
    }
    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void Update (){
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log (rb.velocity.y);
		Vector2 movement = new Vector2 (rb.velocity.x, rb.velocity.y);

		//移動
		if (Input.GetKey ("right") ) {
			rb.transform.rotation = Quaternion.Euler (0, 0, 0);
            if (wall != true)
                rb.velocity = new Vector2(speed, rb.velocity.y);
		} else if (Input.GetKey ("left")) {
			rb.transform.rotation = Quaternion.Euler (0, 180, 0);
            if (wall != true)
                rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
		if (Input.GetKeyUp ("right") || Input.GetKeyUp("left")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
		//Vector2 up = new Vector2 (0, high);
		if (Input.GetKey ("up") && onGround == true) {
            //rb.velocity = new Vector2 (rb.velocity.x, high);
            jump();
		}
	}

    
}
