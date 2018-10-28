using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Use this script to change asynchronously to any scene given as a string name.
public class ChangeSceneTo : MonoBehaviour {

    public string sceneToSwitchTo;

	public void ChangeTo()
    {
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToSwitchTo);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
