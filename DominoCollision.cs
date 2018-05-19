using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoCollision : MonoBehaviour {

	public AudioSource domSource;

	// Use this for initialization
	void Start () {

		domSource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision collision) 
	{
		if (collision.gameObject.tag == "domino") 
		{
			domSource.Play();
		}

	}

}
