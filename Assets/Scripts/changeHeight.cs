using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeHeight : MonoBehaviour {

	public GameObject water;

	// Update is called once per frame
	void Update () {
		Vector3 waterPos = water.transform.position; 
		float minWaterLevel = 0;
		float maxWaterLevel = 20;
		float sliderValue = ReadHeightSliderValue.heightSliderValue;
		//float sliderValue = PlayerPrefs.GetFloat ("heightSliderValue");
		float waterLevel = Mathf.Lerp (maxWaterLevel, minWaterLevel, sliderValue);
		water.transform.position = new Vector3 (waterPos.x, waterLevel, waterPos.z); 
	}
}
