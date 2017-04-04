using UnityEngine;
using System.Collections;

public class SmokeDistanceAudio : MonoBehaviour {
	public AudioSource smoke;
	public bool played;
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
			smoke.Play ();
			played = true;
		}
	}
}
