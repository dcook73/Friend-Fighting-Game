using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	WaitForSeconds oneSec;
	public Transform[] spawnPositions;

	CharacterManager charM;
	LevelUI levelUI;

	public int maxRounds = 2;
	int currentRound = 1;

	public bool countdown;
	public int maxTurnTimer = 99;
	int currentTimer;
	float internalTimer;

	// Use this for initialization
	void Start ()
	{
		charM = CharacterManager.GetInstance ();
		levelUI = LevelUI.GetInstance ();


	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}//ends LevelManager class
