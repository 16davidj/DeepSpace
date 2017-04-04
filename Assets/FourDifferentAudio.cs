using UnityEngine;
using System.Collections;

public class FourDifferentAudio : MonoBehaviour {
	public AudioSource fourDiff;
	bool played;
	// Use this for initialization
	void Start () {
		played = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(!played)
		{
			fourDiff.Play ();
			played = true;
		}
	}

}
