using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLocation : MonoBehaviour {

	public Transform near;
	public GameObject mid;
	public Transform far;

	void Update(){
		Vector3 nearPos = near.transform.position;
		Vector3 farPos = far.transform.position;
		float sliderValue = ReadDistanceSliderValue.distanceSliderValue; 
		Vector3 pos = Vector3.Lerp (farPos, nearPos, sliderValue);
		mid.transform.position = new Vector3 (pos.x, pos.y, pos.z);
	}
}