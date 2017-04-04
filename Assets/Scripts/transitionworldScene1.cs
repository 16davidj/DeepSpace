using UnityEngine;
using System.Collections;

public class transitionworldScene1 : MonoBehaviour {
	//public suitAI suitMan;
	bool firstTime = true;
	float timeStart;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay(Collider other){
	
		if(other.tag == "Player"){

				Debug.Log("fakeload");
				Application.LoadLevel("Scene_4");
			}
	}
}
