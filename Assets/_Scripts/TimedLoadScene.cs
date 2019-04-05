using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedLoadScene : MonoBehaviour {



    public float delay = 5;
    public string SceneToLoad = "MainMenu";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneToLoad);
    }

 
	
	// Update is called once per frame
	void Update () {
		
	}
}
