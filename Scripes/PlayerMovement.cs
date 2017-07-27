using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeedUp = 0f;
	private float moveSpeedDown = 200f;
	private Rigidbody2D myrigidbody;
	private Bmove BM;
	private GameObject BlockO;


	private float timer;
	public float delayTimer = 100f;



	bool currentPlatformAndroid = false;

	void Awake()
	{
		#if UNITY_ANDROID
		currentPlatformAndroid = true;
		#else
		currentPlatformAndroid = false;
		#endif

	}


	void Start () 
	{

		if (currentPlatformAndroid == true) {
			Debug.Log ("Android");
		} else {
			Debug.Log ("Windows");
		}



		myrigidbody = GetComponent<Rigidbody2D>();
		timer = delayTimer;
		BlockO = GameObject.FindGameObjectWithTag ("Stop");
		BM = BlockO.GetComponent<Bmove> ();
	}
	

	void Update () 
	{
		if (currentPlatformAndroid == true) {
		//android stuff




		} else {

			myrigidbody.velocity = new Vector2 (moveSpeedDown * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f);

			/*	timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			moveSpeedDown += 0.2f;
			BM.Speed -= 50f;
			timer = delayTimer;
		}*/

		}
		
	}

	public void MoveLeft (){

		myrigidbody.velocity = new Vector2 (-moveSpeedDown * Time.deltaTime, 0f);

	}

	public void MoveRight (){ 

		myrigidbody.velocity = new Vector2 (moveSpeedDown * Time.deltaTime, 0f);

	}

	public void SetVel0 (){ 

		myrigidbody.velocity = Vector2.zero;

	}




}
