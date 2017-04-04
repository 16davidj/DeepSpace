using UnityEngine;
using System.Collections;

public class hudSoundScript : MonoBehaviour {
	public AudioSource body;
	public AudioClip start;
	// Use this for initialization
	void Start () {
		body.PlayOneShot (start, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
