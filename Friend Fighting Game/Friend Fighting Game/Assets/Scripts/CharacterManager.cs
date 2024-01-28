using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
	public int numOfUsers;

	//list of players and types
	public List<PlayerBase> players = new List<PlayerBase>();

	public List<CharacterBase> characterList = new List<CharacterBase>();

	public CharacterBase returnCharacterWithID(string id)
	{
		CharacterBase retVal = null;

		for (int i = 0; i < characterList.Count; i++)
		{
			if (string.Equals(characterList[i].charId, id))
			{
				retVal = characterList[i];
			}//ends if statement
		}//ends for loop
		return retVal;
	}//ends CharacterBase method

	public PlayerBase returnPlayerFromStates(StateManager states)
	{
		PlayerBase retVal = null;

		for (int i = 0; i < players.Count; i++)
		{
			if (players[i].playerStates == states)
			{
				retVal = players[i];
				break;
			}//ends if statement
		}//ends for loop
		return retVal;
	}//ends returnPlayerFromStates method

	public static CharacterManager instance;
	public static CharacterManager GetInstance()
	{
		return instance;
	}//ends GetInstance method

	void Awake()
	{
		instance = this;
		DontDestroyOnLoad(this.gameObject);
	}//ends awake method

}//ends CharacterManager class

[System.Serializable]
public class CharacterBase
{
	public string charId;
	public GameObject prefab;
}//ends CharacterBase class

[System.Serializable]
public class PlayerBase
{
	public string playerId;
	public string inputId;
	public PlayerType playerType;
	public bool hasCharacter;
	public GameObject playerPrefab;
	public StateManager playerStates;
	public int score;

	public enum PlayerType
	{
		user,
		ai
	}//ends enum
}//ends PlayerBase class