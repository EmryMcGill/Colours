using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour {

	public Text Score;
	public float ScoreCount;


	void Start () 
	{
		ScoreCount = 0;
		Score.text = " " + ScoreCount;
	}
	

	void Update () 
	{
		
		//ScoreCount += 1;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Point") {
			ScoreCount += 1;
			Score.text = " " + ScoreCount;
		}
	}
}
