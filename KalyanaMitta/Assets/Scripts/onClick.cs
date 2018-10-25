using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class onClick : MonoBehaviour {
	public GameObject collider;

	/*void OnCollisionEnter(Collider col) {
		if (col == collider) {
			SwitchScene ();
		}
	}*/
	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit))
			if (hit.collider == collider) {
				SwitchScene ();
			}
		} 
	}


	public void SwitchScene(){
		Debug.Log ("DEBUG");
			SceneManager.LoadScene ("Introduction");
	}

}
