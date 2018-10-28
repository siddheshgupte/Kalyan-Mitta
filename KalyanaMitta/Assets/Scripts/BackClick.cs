using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackClick : MonoBehaviour {


	public void SwitchScene(){
		SceneManager.LoadScene ("MainMenu");
	}
}
