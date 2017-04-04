using UnityEngine;
using System.Collections;

public class footstepScript : MonoBehaviour {
	public AudioSource footstep;
	float speedx, speedy, speedz, totalSpeed;
	public 	OVRPlayerController1 control;
	CharacterController controlHUD;
	float prevTime;
	float playTime;
	public AudioSource body;
	public AudioClip footsteps;

	public AudioClip one;
	public AudioClip two;
	public AudioClip three;
	public AudioClip four;
	bool cycle = false;
	int iCounter=0;
	int random1;
	int random2;
	// Use this for initialization
	void Start () {
		controlHUD = control.Controller;
		//body.PlayOneShot (start, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {

		if (cycle == false) {
			random2 = (int)Random.Range(1f, 5f);
			random1 = (int)Random.Range (1f, 4.9f);
			cycle = true;
		}
		speedx = controlHUD.velocity.x;
		speedy = controlHUD.velocity.y;
		speedz = controlHUD.velocity.z;
		totalSpeed = Mathf.Abs(speedx) + Mathf.Abs(speedy) + Mathf.Abs (speedz);
		playTime = 10.0f / totalSpeed;
		if (controlHUD.isGrounded) {
			if( Time.time > (prevTime + playTime)){
				switch(random1){
				case 1:
					body.PlayOneShot(one, 0.4f);
					break;
				case 2: 
					body.PlayOneShot(two, 0.4f);
					break;
				case 3:
					body.PlayOneShot(three, 0.4f);
					break;
				case 4:
					body.PlayOneShot(four, 0.4f);
					break;
				}
				prevTime = Time.time;
				iCounter++;
			}
		}
		if (iCounter >= random2) {
			iCounter = 0;
			cycle = false;
		}
	}
}
