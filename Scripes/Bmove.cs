using UnityEngine;
using System.Collections;

public class Bmove : MonoBehaviour {

	private float Speed = -180f;
	private Rigidbody2D myrigidbody;
	private GameObject player;
	private ScoreManeger Scor;


	void Start () 
	{
		myrigidbody = GetComponent<Rigidbody2D>();
		player = GameObject.Find ("Player");
		Scor = player.GetComponent <ScoreManeger> ();
	}
	

	void Update () 
	{
		/*if (Scor.ScoreCount == 2) {
			Speed = Speed - 1f;
			Debug.Log ("Faster!");
		}

		if (Scor.ScoreCount == 4) {
			Speed = Speed - 2f;
			Debug.Log ("Faster!");
		}

		if (Scor.ScoreCount == 15) {
			Speed = Speed - 2f;
			Debug.Log ("Faster!");
		}

		if (Scor.ScoreCount == 20) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 25) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 30) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 35) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 40) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 45) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 50) {
			Speed = Speed - 10f;
		}

		if (Scor.ScoreCount == 55) {
			Speed = Speed - 10f;
		}*/


		myrigidbody.velocity = new Vector2 (0f*Time.deltaTime, Speed*Time.deltaTime);

	}
}
