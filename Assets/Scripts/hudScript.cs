using UnityEngine;
using System.Collections;

public class hudScript : MonoBehaviour {
	public Camera cameraFacing;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = cameraFacing.transform.position + 
							cameraFacing.transform.rotation * Vector3.forward * .5f;
		transform.LookAt (cameraFacing.transform.position);
		transform.Rotate (0.0f, 180f, 0.0f);
	}
}
