using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedLoadScene : MonoBehaviour {

    public Animator animator;
    public float delay;
    public string SceneToLoad = "Home";


    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Fadetoscene();
    }

 
	
	// Update is called once per frame
	void Update () {
   
    }


    public void Fadetoscene() {

        animator.SetTrigger("Fadeout");

    }

    public void Onfadecomplete() {

        SceneManager.LoadScene(SceneToLoad);
    }
}
