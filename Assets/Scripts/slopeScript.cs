using UnityEngine;
using System.Collections;

public class slopeScript : MonoBehaviour {
	Vector3 normalVector;
	public GameObject player;
	public Vector3 position;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		position = player.GetComponent<Transform> ().position;
	}
	void OnControllerColliderHit(ControllerColliderHit hit) {
//		Debug.Log("Normal vector we collided at: " + hit.normal);
		normalVector = hit.normal;
	}
}
