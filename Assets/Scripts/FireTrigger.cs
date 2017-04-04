using UnityEngine;
using System.Collections;

public class FireTrigger : MonoBehaviour {

	public suitAI suit;
	public int oxygenLevel;
	public int energyLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") {
			suit.changeOxygen(-10);
		}
		PlayerPrefs.Save();

	}
}
