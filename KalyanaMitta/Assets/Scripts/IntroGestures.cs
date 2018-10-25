using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroGestures : MonoBehaviour {
	private Animator KalyanaACR;
	// Use this for initialization
	void Start () {
		KalyanaACR = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		float TimeLoad = Time.timeSinceLevelLoad;
		Debug.Log (TimeLoad);
				if (TimeLoad > 1) {
			KalyanaACR.SetBool ("Bow", true);
		} 
		if (TimeLoad > 48.8f) {
			KalyanaACR.SetBool ("Shrug", true);
		}
		if (TimeLoad > 61.2f) {
			KalyanaACR.SetBool ("OneFinger", true);
		}
		if (TimeLoad > 82.1f) {
			KalyanaACR.SetBool ("ReachOut", true);
		}
		/*if (TimeLoad > 48.8) {
			KalyanaACR.SetBool ("Shrug", true);
			//Problems with Animation #2
		} 
		if (TimeLoad > 86.6) {
			KalyanaACR.SetBool ("ReachOut", true);
		}*/
	}
}
