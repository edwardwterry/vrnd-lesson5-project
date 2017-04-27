using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcherOutbound : MonoBehaviour {

	public Camera cam;
	public static Vector3 camPos;
	public static Vector3 camRot;

	public void goToCliff(){
		camPos = cam.transform.position;
		camRot = cam.transform.rotation.eulerAngles;
		PlayerPrefs.SetFloat ("campos_x", camPos.x);
		PlayerPrefs.SetFloat ("campos_y", camPos.y);
		PlayerPrefs.SetFloat ("campos_z", camPos.z);
		PlayerPrefs.SetFloat ("camrot_x", camRot.x);
		PlayerPrefs.SetFloat ("camrot_y", camRot.y);
		PlayerPrefs.SetFloat ("camrot_z", camRot.z);
		SceneManager.LoadScene ("cliff");
	}
}
