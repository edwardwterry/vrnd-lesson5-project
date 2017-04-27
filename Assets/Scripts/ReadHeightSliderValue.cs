using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadHeightSliderValue : MonoBehaviour {

	public Slider slider;
	public static float heightSliderValue;

	public void readValue(){
		//PlayerPrefs.SetFloat ("heightSliderValue", slider.value);
		heightSliderValue = slider.value;
		//Debug.Log (slider.value);
	}

	public void setToDefault(){
		heightSliderValue = 0;
	}


//	float shiftPos(){
	//
	//}

}
//Debug.Log (nearPos);
// Use this for initialization
//void Start () {
//
//	//		slider = GetComponent<Slider> ();
//	//		slider.onValueChanged.AddListener (delegate {
//	//			ValueChangeCheck ();
//	//		});
//PlayerPrefs.SetFloat ("posX", pos.x);
//PlayerPrefs.SetFloat ("posY", pos.y);
//PlayerPrefs.SetFloat ("posZ", pos.z);
//Debug.Log (PlayerPrefs.GetFloat ("posX"));	
////}
