using UnityEngine;
using System.Collections;

public class startScene1 : MonoBehaviour {
	public suitAI suitMan;
	int energy;
	int oxygen;
	// Use this for initialization
	void Start () {
		suitMan.setEnergy (100);
		suitMan.setOxygen (100);
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
