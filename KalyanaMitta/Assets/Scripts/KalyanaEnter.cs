using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KalyanaEnter : MonoBehaviour {
	//Where we want to be, in this case where Kalyana will sit but could add multiple locations
	public Transform[] target;
	//How fast she's going to move
	public float speed;
	//Which target we want to walk towards. In this case there is only the one (where she will sit) but we can add more
	private int current;

	//Reference to our animator controller
	private Animator Anim;

	void Awake() {
		Anim = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		//If we aren't at the place we want to move to
		if(transform.position != target[current].position) {
		//Then we create a vector that moves us towards that position
		Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed*Time.deltaTime);
			//and move our player using ~physics~ to that location (Unity Rigidbody is what makes physics "easy peasy")
		GetComponent<Rigidbody> ().MovePosition (pos);
		
			Anim.SetBool ("IsWalking", true);
		} else {
			//switch to sit for now
			Anim.SetBool ("IsSitting", true);
		}
	} 
}
