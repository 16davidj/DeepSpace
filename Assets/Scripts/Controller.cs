using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	Transform myTransform;
	public float velocity;
	// Use this for initialization
	void Start () 
	{
		myTransform = GetComponent<Transform> ();
	}
		
	// Update is called once per frame.
	//This method updates everytime an arrow is pressed to move the object. The rigidbody helps 
	//the sphere jump, while vector movement allows the sphere to travel to the left or right.
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 movement = new Vector3(5, 0, 0);
			myTransform.position -= movement;
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 movement = new Vector3(velocity, 0, 0);
			myTransform.position += movement;
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 movement = new Vector3(0, 0, velocity);
			myTransform.position -= movement; //negative because it means movement to the left.
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 movement = new Vector3(0, 0, velocity);
			myTransform.position += movement; 
		}
	}
}
