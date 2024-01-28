using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
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

	public bool punching = false;
	public bool kicking = false;

	public Button main;

	public Collider2D trigger;

	public float attackTimer = 0;
	public float attackCd = 0.3f;

	public AudioSource Audio;
	public AudioClip oof;
	public AudioClip Victory;

	public Player2 opponent;

	bool win = false;

	public P1HealthBar health;
	public P2HealthBar opponentHealth;

	int plays = 0;
	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.freezeRotation = true;
		trigger.enabled = false;			


	}

	void mainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}//ends 

	// Update is called once per frame
	void FixedUpdate ()
	{
		Button btnMain = main.GetComponent<Button>();
		btnMain.onClick.AddListener(mainMenu);
		GetComponent<SpriteRenderer> ().sprite = idle;
		if (win == false) {
			if (Input.GetKey (KeyCode.D)) {
				transform.position += Vector3.right * speed * Time.deltaTime;
				GetComponent<SpriteRenderer> ().sprite = walkForward;
			}//ends if
			if (Input.GetKey (KeyCode.A)) {
				transform.position += Vector3.left * speed * Time.deltaTime;
				GetComponent<SpriteRenderer> ().sprite = walkBackward;
			}//ends if
			if (Input.GetKey (KeyCode.W)) {
				transform.position += 3 * Vector3.up * speed * Time.deltaTime;
				//rb2d.AddForce(new Vector2(0, .25f), ForceMode2D.Impulse);
				GetComponent<SpriteRenderer> ().sprite = jump;
			}//ends if
			if (Input.GetKey (KeyCode.R)) {
				GetComponent<SpriteRenderer> ().sprite = punch;
	
			}//ends if
			if (Input.GetKey (KeyCode.F)) {
				GetComponent<SpriteRenderer> ().sprite = kick;
			}//ends if
			if(Input.GetKey(KeyCode.S)){
				GetComponent<SpriteRenderer> ().sprite = block;
			}

			if (Input.GetKey (KeyCode.Q)) {
				//health.TakeDamage ();
				//add special if time
			}//ends if
		}


		if (health.currentHp <= 0) {
			//do something for loss
			health.currentHp = 0;
		}

		if (opponentHealth.currentHp <= 0) {
			//do something for victory
			win = true;
			if (plays == 0) {
				Audio.PlayOneShot (Victory);
			}
			plays++;
			GetComponent<SpriteRenderer> ().sprite = victory;
			//playVictory();
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Player2" && Input.GetKey(KeyCode.R))
		{
			opponent.health.TakeDamage();
			Audio.PlayOneShot (oof);
		}//ends if
		if(coll.gameObject.tag == "Player2" && Input.GetKey(KeyCode.F))
		{
			opponent.health.TakeDamage();
			Audio.PlayOneShot (oof);
		}//ends if
	}//ends collision method
		
}
