using UnityEngine;
using System.Collections;

public class startScene2 : MonoBehaviour {
	public suitAI suitMan;
	int energy;
	int oxygen;
	// Use this for initialization
	void Start () {

		energy = suitMan.getEnergy();
		oxygen = suitMan.getOxygen();
		suitMan.lifeSupText.text = "Oxygen Level: " + oxygen;
		suitMan.energyText.text = "Energy Level: " + energy;
		
		//suitMan.fade.IsActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
