using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_HighScore : MonoBehaviour {

	public Text Score;
	public Text HighScore;

	void Start () 
	{



		Score.text = "" + PlayerPrefs.GetFloat ("score");

		HighScore.text = "" + PlayerPrefs.GetFloat ("HighScore");
	}
	

	void Update () 
	{
		
	}
}
