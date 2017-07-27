using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMode : MonoBehaviour {


	void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}

    public void MedSpeed()
    {
        PlayerPrefs.SetFloat("BmoveSpeed", -150f);
    }


    public void EasySpeed()
    {
        PlayerPrefs.SetFloat("BmoveSpeed", -100f);
    }


    public void FastSpeed()
    {
        PlayerPrefs.SetFloat("BmoveSpeed", -200f);
    }




}
