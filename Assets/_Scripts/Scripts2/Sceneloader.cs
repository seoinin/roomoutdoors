using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour {


    public GameObject loadingscreen;
    public Slider slider;
    //public Text progresstext;

    public void Loadlevel(string scene) {
        StartCoroutine(LoadAsynchronously(scene));
    }

    IEnumerator LoadAsynchronously(string scene) {

        AsyncOperation operation = SceneManager.LoadSceneAsync(scene);

        loadingscreen.SetActive(true);

        while (!operation.isDone) {

            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            //progresstext.text = Mathf.Round(progress * 100f) + "%";

            yield return null;
        }
    }
}
