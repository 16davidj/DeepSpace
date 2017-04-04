using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class suitAI : MonoBehaviour {
	public int oxygenLevel;
	public int energyLevel;
	public int lifeSupLevel;
	int prevOx;
	int prevEn;
	public Text energyText;
	public Text lifeSupText;
	public environmentDetails environment;
	float depletionRate;
	public Image fade;
	public float prevTime;
	public AudioSource depletion;
	public AudioClip ten;
	public AudioClip twenty;
	public AudioClip thirty;
	public AudioClip fifty;
	public AudioClip seventy;
	public AudioClip start;
	public AudioClip dead;
	public Text partscompleted;
	float currentTime;
	public int parts;
	// Use this for initialization
	void Start () {
		depletionRate = environment.getDepletion ();
		prevTime = 0;
		lifeSupLevel = environment.lifeSup;
		lifeSupText.text = lifeSupLevel + "%";
		partscompleted.text = PlayerPrefs.GetInt ("parts") + "/4";
		parts = PlayerPrefs.GetInt ("parts");
		if(parts >= 4)
		{
			Application.LoadLevel("Forest_Win");
		}
	}
	
	// Update is called once per frame
	void Update () {
	//	Debug.Log (Time.time);
		if (Input.GetKey (KeyCode.Alpha1))
			Application.LoadLevel ("Scene_1");
		if (Input.GetKey (KeyCode.Alpha2))
			Application.LoadLevel ("Scene_2");
		if (Input.GetKey (KeyCode.Alpha3))
			Application.LoadLevel ("Scene_3_1");
		if (Input.GetKey (KeyCode.Alpha4))
			Application.LoadLevel ("Scene_3_2");
		depleteLifeSupport ();
		if (lifeSupLevel <= 0) {
			Application.LoadLevel(Application.loadedLevel);
		}
		

	}
	void OnApplicationQuit() {
		// Make sure prefs are saved before quitting.
		PlayerPrefs.DeleteAll ();
	}
	void depleteLifeSupport(){
		//Debug.Log ("1");
		currentTime = Time.time;
		if (lifeSupLevel > 100) {
			lifeSupLevel = 100;
		}
		if (currentTime - prevTime >= depletionRate) {
			//Debug.Log ("2");
			lifeSupLevel--;
			lifeSupText.text = lifeSupLevel + "%";
			prevTime = currentTime;
			switch (lifeSupLevel)
			{
			case 70:
				depletion.PlayOneShot(seventy);
				break;
			case 50:
				depletion.PlayOneShot(fifty);
				break;
			case 30:
				depletion.PlayOneShot(thirty);
				break;
			case 20:
				depletion.PlayOneShot(twenty);
				break;
			case 10:
				depletion.PlayOneShot(ten);
				break;
			case 0:
				depletion.PlayOneShot(dead);
				break;
			}
		}

	}

	public void kitCollect(){
		parts = PlayerPrefs.GetInt ("parts");
		parts++;
		PlayerPrefs.SetInt ("parts", parts);
		partscompleted.text = PlayerPrefs.GetInt ("parts") + "/4";
		PlayerPrefs.Save ();
	}


	public void setOxygen(int set){
		PlayerPrefs.SetInt ("oxygenLevel", set);
		PlayerPrefs.Save ();
	}
	public void setEnergy(int set){
		PlayerPrefs.SetInt ("energyLevel", set);
		PlayerPrefs.Save ();
	}

	public void changeOxygen(int change){
		prevOx = PlayerPrefs.GetInt ("oxygenLevel");
		PlayerPrefs.SetInt ("oxygenLevel", prevOx + change);
		PlayerPrefs.Save ();
	}
	public void changeEnergy(int change){
		prevEn = PlayerPrefs.GetInt ("energyLevel");
		PlayerPrefs.SetInt ("energyLevel", prevEn + change);
		PlayerPrefs.Save ();
	}
	public int getOxygen(){
		return PlayerPrefs.GetInt ("oxygenLevel");
	}
	public int getEnergy(){
		return PlayerPrefs.GetInt ("energyLevel");
	}
}
