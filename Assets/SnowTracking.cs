using UnityEngine;
using System.Collections;

public class SnowTracking : MonoBehaviour {
	Vector3 movePos;
	public GameObject OVR;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movePos = OVR.GetComponent<slopeScript> ().position;
		transform.position = movePos;
	}
}
