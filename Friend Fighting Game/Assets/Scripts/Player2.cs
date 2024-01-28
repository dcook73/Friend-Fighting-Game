using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {
	float speed = 2.5f;
	private Rigidbody2D rb2d;

	public Sprite walkForward;
	public Sprite walkBackward;
	public Sprite idle;
	public Sprite jump;
	public Sprite punch;
	public Sprite kick;
	public Sprite victory;
	public Sprite block;

	bool win = false;

	public P2HealthBar health;
	public P1HealthBar opponentHealth;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.freezeRotation = true;
	}

	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<SpriteRenderer>().sprite = idle;

		if(win == false)
		{
		if (Input.GetKey(KeyCode.L))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
			GetComponent<SpriteRenderer>().sprite = walkForward;
		}//ends if
		if (Input.GetKey(KeyCode.J))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
			GetComponent<SpriteRenderer>().sprite = walkBackward;
		}//ends if
		if (Input.GetKey(KeyCode.I))
		{
			transform.position += 3 * Vector3.up * speed * Time.deltaTime;
			//rb2d.AddForce(new Vector2(0, .25f), ForceMode2D.Impulse);
			GetComponent<SpriteRenderer>().sprite = jump;
		}//ends if
		if (Input.GetKey(KeyCode.U))
		{
			GetComponent<SpriteRenderer>().sprite = punch;
		}//ends if
		if (Input.GetKey(KeyCode.H))
		{
			GetComponent<SpriteRenderer>().sprite = kick;
		}//ends if
		if(Input.GetKey(KeyCode.K)){
				GetComponent<SpriteRenderer> ().sprite = block;		
		}
		if (Input.GetKey(KeyCode.P))
		{
			health.TakeDamage();
		}//ends if
		}

		if(health.currentHp <= 0)
		{
			//do something for loss
		}//ends if 

		if(opponentHealth.currentHp <= 0)
		{
			win = true;
			GetComponent<SpriteRenderer>().sprite = victory;
		}
	}
}
