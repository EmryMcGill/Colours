using UnityEngine;
using System.Collections;

public class MenuAnimation : MonoBehaviour {

	public float MoveSpeedUp = 2000f;
	public float MoveSpeedSide = 2000f;
	private Rigidbody2D myrigidbody;



	void Start () 
	{
		myrigidbody = GetComponent<Rigidbody2D>();
	}
	

	void Update () 
	{
		myrigidbody.velocity = new Vector2 (MoveSpeedSide*Time.deltaTime,MoveSpeedUp*Time.deltaTime);
	}
}
