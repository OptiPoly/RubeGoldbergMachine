using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour {

	public AudioSource hitSource;

	// Use this for initialization
	void Start () {

		hitSource = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision) 
	{
		if (collision.gameObject.tag == "other") 
		{
			hitSource.Play();
		}
		
	}

}
