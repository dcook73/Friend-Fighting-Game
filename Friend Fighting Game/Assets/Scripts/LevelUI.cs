using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelUI : MonoBehaviour
{

	public Text AnnouncerTextLine1;
	public Text AnnouncerTextLine2;
	public Text LevelTimer;

	public Slider[] healthSliders;

	public GameObject[] winIndicatorGrids;
	public GameObject winIndicator;

	public static LevelUI instance;

	public static LevelUI GetInstance ()
	{
		return instance;
	}//ends LevelUI method

	void Awake ()
	{
		instance = this;
	}//ends Awake method

	public void AddWinIndicator (int player)
	{
		GameObject go = Instantiate (winIndicator, transform.position, Quaternion.identity) as GameObject;
		go.transform.SetParent (winIndicatorGrids [player].transform);
	}//ends AddWinIndicator method
}//ends LevelUI class
