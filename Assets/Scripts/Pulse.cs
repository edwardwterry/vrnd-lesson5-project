using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour {

	public GameObject breathObject; 
		
	// Update is called once per frame
	void Update () {
		float size =0.6f*( 1f + 0.25f*Mathf.Cos (Time.time/1.3f+.5f));// * Time.deltaTime*10.0f;
		breathObject.transform.localScale = new Vector3 (size, size, size);//Mathf.Sin(Time.time) * Time.deltaTime;
	}
}
