using UnityEngine;
using System.Collections;

public class FinalScriptAudio : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		Application.Quit ();
	}
}
