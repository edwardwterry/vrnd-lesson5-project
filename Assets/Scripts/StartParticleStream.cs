using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticleStream : MonoBehaviour {

	public GameObject ps;

	void Start(){
		ps.SetActive (false);
	}

	public void StartPS () {
		ps.SetActive (true);
		Debug.Log("started");
	}
}
