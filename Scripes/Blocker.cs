using UnityEngine;
using System.Collections;

public class Blocker : MonoBehaviour {

	private GameObject player;
	private Rigidbody2D bC;
	private PlayerMovement Mp;
	private GameObject Spawn;
	private ScoreManeger Scor;

	public GameObject Explode;

	public GameObject OD1;
	public GameObject OD2;
	public GameObject OD3;
	public GameObject OD4;
	public GameObject OD5;

	public GameObject BlockO;

	private Bmove Bm;

	//public GameObject Death1;
	//public GameObject Death2;
	//public GameObject Death3;
	//public GameObject spawn1;

	//float Speed = -125f;
	//private Rigidbody2D myrigidbody;

	float restart = 0f;

	private float Timer;
 	public float delayTimer = 10000f;

	void Start () 
	{
		//myrigidbody = GetComponent<Rigidbody2D>();
		BlockO = GameObject.FindGameObjectWithTag("Stop");
	//	Explode = GameObject.Find ("Particules");
		player = GameObject.Find ("Player");
		Spawn = GameObject.Find ("SpawnPoint");
		bC = player.GetComponent<Rigidbody2D> ();
		Mp = player.GetComponent<PlayerMovement> ();
		Bm = BlockO.GetComponent<Bmove> ();
		Scor = player.GetComponent<ScoreManeger> ();
		//Timer = delayTimer;
		//Explode.GetComponent<ParticleSystem> ().enableEmission = false;
	//	Application.LoadLevel (2);



		/*if (PlayerPrefs.GetFloat ("Highscore") < Scor.ScoreCount) 
		{
			PlayerPrefs.SetFloat ("HighScore", Scor.ScoreCount);
		}
		*/


	}
	

	void Update () 
	{
		//myrigidbody.velocity = new Vector2 (0f*Time.deltaTime,Speed*Time.deltaTime);
		if (player == null) 
		{
				Application.LoadLevel (3);
			//Instantiate (Explode, transform.position, transform.rotation);
		}
		/*if (PlayerPrefs.GetFloat ("score") < Scor.ScoreCount) 
		{
			PlayerPrefs.SetFloat ("HighScore", Scor.ScoreCount);
		}*/

	}

	void OnTriggerEnter2D()
	{

		/*Timer -= Time.deltaTime;
		if (Timer <= 0) 
		{
		Application.LoadLevel (2);
		}*/

		if (PlayerPrefs.GetFloat ("HighScore") < Scor.ScoreCount) {
			

			PlayerPrefs.SetFloat ("HighScore", Scor.ScoreCount);
		}
		PlayerPrefs.SetFloat ("score",Scor.ScoreCount);

		print ("You Died!");
		Destroy (Spawn, 0f);
		Destroy (player);
		//Destroy (BlockO);


		//Timer -= Time.deltaTime;
		//if (Timer <= 0) 
		//{
		//Application.LoadLevel (2);
		//}
	}

}
