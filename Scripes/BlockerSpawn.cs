using UnityEngine;
using System.Collections;

public class BlockerSpawn : MonoBehaviour {

	public float maxPos = 2.2f;
	public GameObject blocker1;
	public GameObject blocker2;
	public GameObject blocker3;
	public GameObject blocker4;
	public GameObject blocker5;

	float timer;
	public float delayTimer = 4f;

	int num;

	void Start ()
	{
		timer = delayTimer;
	}
	

	void Update ()
	{
		timer -= Time.deltaTime;
		if (timer <= 0) {

			num = Random.Range (1, 5);
			print (num);

			if (num == 1) {
				Instantiate (blocker1, transform.position, transform.rotation);
			}

			if (num == 2) {
				Instantiate (blocker2, transform.position, transform.rotation);
			}

			if (num == 3) {
				Instantiate (blocker3, transform.position, transform.rotation);
			}

			if (num == 4) {
				Instantiate (blocker4, transform.position, transform.rotation);
			}

			if (num == 5) {
				Instantiate (blocker5, transform.position, transform.rotation);
			}
			timer = delayTimer;
		}
			
	}
		

}
