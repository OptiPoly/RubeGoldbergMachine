using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceHit : MonoBehaviour {

	public AudioSource dieSource;

	// Use this for initialization
	void Start () {

		dieSource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision collision) 
	{
		if (collision.gameObject.tag == "other") 
		{
			dieSource.Play();
		}
		if (collision.gameObject.tag == "domino") 
		{
			dieSource.Play();
		}

	}

}