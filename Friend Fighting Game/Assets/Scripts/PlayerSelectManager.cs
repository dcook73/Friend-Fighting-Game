using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelectManager : MonoBehaviour
{
	public Button darrenSelect;
	public Button joshSelect;
	public Button devSelect;

	public bool isP1Darren = false;
	public bool isP1Josh = false;
	public bool isP1Dev = false;

	public bool isP2Darren = false;
	public bool isP2Josh = false;
	public bool isP2Dev = false;

	public bool isP1Choosing = true;
	public bool isP2Choosing = false;

	public Text topText;

	//public SceneManager sceneMan;

	// Use this for initialization
	void Start ()
	{
		Button btnDarren = darrenSelect.GetComponent<Button>();
		btnDarren.onClick.AddListener(SelectDarren);

		Button btnJosh = joshSelect.GetComponent<Button>();
		btnJosh.onClick.AddListener(SelectJosh);

		Button btnDev = devSelect.GetComponent<Button>();
		btnDev.onClick.AddListener(SelectDev);

		Text txt = topText.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.skin.label.fontSize = 19;
		GUI.Label (new Rect (Screen.width / 2 - 530, 550, 2000, 1000), "Once you choose your friends, click on the Friend Button.");

		if (GUI.Button (new Rect (Screen.width / 2 - 100, 500, 175, 40), "FRIEND"))
			switchLevel ();
	}

	void SelectDarren()
	{
		Debug.Log("Darren clicked");
		if(isP1Choosing == true)
		{
			isP1Darren = true;
			isP1Choosing = false;
			isP2Choosing = true;
			topText.text = "Player 2 Select";
		}//ends if
		else if(isP2Choosing == true)
		{
			isP2Darren = true;
			//switchLevel();
		}//ends else if
	}

	void SelectJosh()
	{
		if(isP1Choosing == true)
		{
			isP1Josh = true;
			isP1Choosing = false;
			isP2Choosing = true;
			topText.text = "Player 2 Select";
		}//ends if
		else if(isP2Choosing == true)
		{
			isP2Josh = true;
			//this.switchLevel();
		}//ends else if
	}

	void SelectDev()
	{
		if(isP1Choosing == true)
		{
			isP1Dev = true;
			isP1Choosing = false;
			isP2Choosing = true;
			topText.text = "Player 2 Select";
		}//ends if
		else if(isP2Choosing == true)
		{
			isP2Dev = true;
			//switchLevel();
		}//ends else if
	}

	void switchLevel()
	{
		if(isP1Darren == true && isP2Josh == true)
		{
			SceneManager.LoadScene("DaVSJo");
		}//ends if
		else if(isP1Darren == true && isP2Dev == true)
		{
			SceneManager.LoadScene("DaVSDe");
		}//ends else
		else if(isP1Josh == true && isP2Darren == true)
		{
			SceneManager.LoadScene("JoVSDa");
		}//ends else if
		else if(isP1Josh == true && isP2Dev == true)
		{
			SceneManager.LoadScene("JoVSDe");
		}//ends else
		else if(isP1Dev == true && isP2Darren == true)
		{
			SceneManager.LoadScene("DeVSDa");
		}//ends else
		else if(isP1Dev == true && isP2Josh == true)
		{
			SceneManager.LoadScene("DeVSJo");
		}
	}
}
