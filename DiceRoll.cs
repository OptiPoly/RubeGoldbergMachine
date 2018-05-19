using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour {

	public AudioSource rollSource;

	// Use this for initialization
	void Start () {

		rollSource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision collision) 
	{
		if (collision.gameObject.tag == "other") 
		{
			rollSource.Play();
		}

	}

}