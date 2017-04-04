using UnityEngine;
using System.Collections;

public class transitionworldNext: MonoBehaviour {
	public suitAI suitMan;
	bool firstTime = true;
	float timeStart;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay(Collider other){
		Debug.Log (Time.time);
		if (other.tag == "Player" && firstTime == true) {
			timeStart = Time.time;
			Debug.Log (timeStart);
			suitMan.fade.CrossFadeAlpha(255, 5,false);
			suitMan.changeEnergy(-20);
			suitMan.changeOxygen(-20);
			int energy = suitMan.getEnergy();
			int oxygen = suitMan.getOxygen();
			Debug.Log(energy);
			Debug.Log(oxygen);

			firstTime = false;	

			
		}
		if(Time.time >= (timeStart + 5)){

				Debug.Log("fakeload");
				Application.LoadLevel(Application.loadedLevel + 1);
			}
	}
}
