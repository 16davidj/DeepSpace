using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Scrollbar))]
public class hpChangetr : MonoBehaviour
{	
	float lerpedNumber;
	public suitAI suitMan;
	[SerializeField]
	Image CircleImage;
	[SerializeField]
	Color start;
	[SerializeField]
	Color end;
	
	[SerializeField]
	Color current;
	
	//Scrollbar scrollbar { get { return GetComponent<Scrollbar>(); } }
	
	void Start()
	{
		CircleImage.type = Image.Type.Filled;
		CircleImage.fillMethod = Image.FillMethod.Radial360;
		CircleImage.fillOrigin = 0;
	}
	
	void Update()
	{	
		//lerpedNumber = Mathf.Lerp (0, 100, suitMan.lifeSupLevel);
		//Debug.Log (lerpedNumber);
		lerpedNumber = (float)suitMan.lifeSupLevel / 100f;
		//Debug.Log (lerpedNumber);
		CircleImage.fillAmount = Mathf.Max( lerpedNumber,0.001f);
		CircleImage.color = Color.Lerp(end, start, lerpedNumber);
		current = Color.Lerp(end, start, lerpedNumber);
	}
	
	
}
