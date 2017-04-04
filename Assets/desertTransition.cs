using UnityEngine;
using System.Collections;

public class desertTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerStay(Collider other){
		
		if(other.tag == "Player"){
			
			//	Debug.Log("fakeload");
			Application.LoadLevel("Scene_3_2");
		}
	}
}
