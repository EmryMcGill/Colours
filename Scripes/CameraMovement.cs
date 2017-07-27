using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	//public float CameraMove = 0.01f;

	public float xMax;
	public float yMax;

	public float xMin;
	public float yMin;

	private Transform target;

	void Start () 
	{
		target = GameObject.Find ("Player").transform;
	}
	

	void LateUpdate () 
	{
		transform.position = new Vector3 (Mathf.Clamp(0f,xMin,xMax), Mathf.Clamp(target.position.y,yMin,yMax), transform.position.z);

		//transform.Translate (0f, CameraMove*Time.deltaTime, 0f);
	}
}
