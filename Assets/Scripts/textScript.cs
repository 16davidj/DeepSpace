using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textScript : MonoBehaviour {
	public Camera cameraFacing;
	public float forwarndD;
	public float upD;
	public float rightD;
	public float zR;
	public GameObject test;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float totalAngle = 32 + zR;
		float angleSet = totalAngle	 - transform.rotation.x;
		Debug.Log ("x: " + (int)transform.localRotation.x);
		Debug.Log ("angleSet :" + (int)angleSet + " totalAngle: " + totalAngle);
		transform.position = cameraFacing.transform.position + 
			cameraFacing.transform.rotation * Vector3.forward * forwarndD +
				cameraFacing.transform.rotation * Vector3.up *  upD+
					cameraFacing.transform.rotation * Vector3.right * rightD;
		transform.LookAt (cameraFacing.transform.position);
		transform.Rotate (0.0f, 180.0f, 0.0f);

	}
}

 