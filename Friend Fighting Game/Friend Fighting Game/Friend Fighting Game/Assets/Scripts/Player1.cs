using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
    public float speed = 1.5f;
    private Rigidbody2D rb2d;

	public Sprite walkForward;
    public Sprite walkBackward;
    public Sprite idle;
    public Sprite jump;
    public Sprite punch;
    public Sprite kick;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
        rb2d.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().sprite = idle;
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
			GetComponent<SpriteRenderer>().sprite = walkForward;
        }//ends if
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().sprite = walkBackward;
        }//ends if
        if (Input.GetKey(KeyCode.W))
        {
          //  transform.position += Vector3.up * speed * Time.deltaTime;
            rb2d.AddForce(new Vector2(0, .25f), ForceMode2D.Impulse);
            GetComponent<SpriteRenderer>().sprite = jump;
        }//ends if
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<SpriteRenderer>().sprite = punch;
        }//ends if
        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<SpriteRenderer>().sprite = kick;
        }//ends if
	}
}
