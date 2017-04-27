using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTracker : MonoBehaviour
{
	public GameObject _camera;

	// Position
	static float campos_x;
	static float campos_y;
	static float campos_z;
	static float camrot_x;
	static float camrot_y;
	static float camrot_z;

	public void ToggleState()
	{
		campos_x = PlayerPrefs.GetFloat ("campos_x");
		campos_y = PlayerPrefs.GetFloat ("campos_y");
		campos_z = PlayerPrefs.GetFloat ("campos_z");
		camrot_x = PlayerPrefs.GetFloat ("camrot_x");
		camrot_y = PlayerPrefs.GetFloat ("camrot_y");
		camrot_z = PlayerPrefs.GetFloat ("camrot_z");
	}

	void Update ()
	{
		if (sceneSwitcherInbound.hasReturned) {
			_camera.transform.position = new Vector3(campos_x, campos_y, campos_z);
			_camera.transform.rotation = Quaternion.Euler(camrot_x, camrot_y, camrot_z);
			sceneSwitcherInbound.hasReturned = false;
		}
	}

}