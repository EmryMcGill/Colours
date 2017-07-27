using UnityEngine;
using System.Collections;

public class BlockerDestroy : MonoBehaviour {

	public float destroyTime = 3.0f;

	void Start () 
	{
		Destroy (gameObject, destroyTime);
	}
	

	void Update () {
	
	}
}
