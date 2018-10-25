using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyGestures : MonoBehaviour {
	private Animator KalyanaACR;
	public float highIntensity = 2.86f;
	public float lowIntensity = 0f;
	public float dimSpeed = 0.5F;
	public float delta = 0.04f;
	public float targetIntensity;

	public Light lt;
	// Use this for initialization
	void Start () {
		KalyanaACR = GetComponent<Animator> ();
		lt.intensity = highIntensity;
		targetIntensity = lowIntensity;

	}
	
	// Update is called once per frame
	void Update () {
		float TimeLoad = Time.timeSinceLevelLoad;
		Debug.Log (TimeLoad);
				if (TimeLoad > 1) {
			KalyanaACR.SetBool ("bow", true);
		} 
		if (TimeLoad > 8.0f) {
			KalyanaACR.SetBool ("clasp", true);
		}
		if (TimeLoad > 10.0f) {
			KalyanaACR.SetBool ("heart", true);
		}
		/*if (TimeLoad > 40.0f) {
			lt.intensity = Mathf.Lerp(lt.intensity, targetIntensity, dimSpeed * delta);
			lt.color-= Color.black / 2.0F * Time.deltaTime;
		}*/
		if (TimeLoad > 481.0f) {
			KalyanaACR.SetBool ("final", true);
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
