using UnityEngine;
using System.Collections;

public class MissingPartsAudio : MonoBehaviour {
	public AudioSource missingParts;
	private bool played;
	// Use this for initialization
	void Start () {
		played = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (!played) {
			missingParts.Play ();
			played = true;
		}
	}
}
