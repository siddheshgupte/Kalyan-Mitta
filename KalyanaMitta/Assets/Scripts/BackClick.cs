using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackClick : MonoBehaviour {

	//void Update(){
	//	if (Input.GetButtonDown ("Fire1")) {
	//		SwitchScene ();
	//	}
	//}
	public void SwitchScene(){
		SceneManager.LoadScene ("MainMenu");
	}
}
