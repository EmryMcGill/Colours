using UnityEngine;
using System.Collections;

public class ParticuleTimer : MonoBehaviour {


	private float Timer;
	public float delayTimer = 5f;


	void Start () 
	{
		Timer = delayTimer;
	}
	

	void Update () 
	{
		Timer -= Time.deltaTime;
		if (Timer <= 0) 
		{
			Application.LoadLevel (2);
		}
	}
}
