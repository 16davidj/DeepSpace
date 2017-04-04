using UnityEngine;
using System.Collections;

public class Kit : MonoBehaviour
{
	public suitAI suit;
	public AudioSource collect;
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player" && Input.GetMouseButton(2)) {
			Destroy (gameObject);
			suit.kitCollect();
			collect.Play();
		}
	}
}
