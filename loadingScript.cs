using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScript : MonoBehaviour {

	public GameObject loadingObj;
	public Slider slider;

	AsyncOperation async;

	public void LoadScreenExample(int lvl)
	{
		StartCoroutine(LoadingScreen(lvl));
	}

	IEnumerator LoadingScreen(int lvl)
	{
		loadingObj.SetActive(true);
		async = SceneManager.LoadSceneAsync(lvl);
		async.allowSceneActivation = false;

		while (async.isDone == false)
		{
			slider.value = async.progress;
			if(async.progress == 0.9f)
			{
				slider.value = 1f;
				async.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
