using UnityEngine;
using System.Collections;

public class OxygenTextScript : MonoBehaviour {
	public Camera cameraFacing;
	public float forwardD, upD, rightD;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = cameraFacing.transform.position + 
			cameraFacing.transform.rotation * Vector3.forward * forwardD + 
				cameraFacing.transform.rotation * Vector3.up * upD + 
				cameraFacing.transform.rotation * Vector3.right * rightD;
		transform.LookAt (cameraFacing.transform.position);
		transform.Rotate (0.0f, 180.0f, 0.0f);
	}
}
