using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLight : MonoBehaviour {
	public float highIntensity = 2.86f;
	public float lowIntensity = 0f;
	public float dimSpeed = 0.5F;
	public float delta = 0.04f;
	public bool isDimming;
	public float targetIntensity;

	public Light lt;


	// Use this for initialization
	void Start () {
		//Debug.Log ("DEBUG");
		isDimming = false;
		lt.intensity = highIntensity;
		targetIntensity = lowIntensity;


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			//if(Input.GetTouch(0)){
			isDimming = true;

		}
		if (isDimming) {
			FadeLight ();
		}


	}

	void FadeLight(){
		//Debug.Log ("IM HERE");
		lt.intensity = Mathf.Lerp(lt.intensity, targetIntensity, dimSpeed * delta);
		lt.color-= Color.black / 2.0F * Time.deltaTime;

	}
}