using UnityEngine;
using System.Collections;

public class LOL : MonoBehaviour {
	public AudioSource kobe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if (Input.GetMouseButton (2)) {
			Debug.Log ("hi");
			kobe.Play ();
		}
	}
}
