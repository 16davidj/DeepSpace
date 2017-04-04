using UnityEngine;
using System.Collections;

public class SplitAudio : MonoBehaviour {
	public AudioSource sound;
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
			sound.Play ();
			played = true;
		}

	}
}
