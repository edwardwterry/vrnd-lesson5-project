using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcherInbound : MonoBehaviour {

	//public Camera cam;
	public static bool hasReturned = false;

	public void goHome(){
		SceneManager.LoadScene ("museum");
		hasReturned = true;
	}
}
