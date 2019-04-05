using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Instruction ()
    {

        SceneManager.LoadScene("Instruction");
    }

    public void Sceen1()
    {

        SceneManager.LoadScene("Splash");
    }

    public void Sceen2()
    {

        SceneManager.LoadScene("RoomOutdoors");
    }

    public void MechBuild3()
    {

        SceneManager.LoadScene("MechBuild3");
    }
    public void MechBuild4()
    {

        SceneManager.LoadScene("MechBuild4");
    }
    public void MainMenuButton()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void About()
    {

        SceneManager.LoadScene("Splash");
    }


    public void Next()
    {

        Debug.Log("Next");
    }

    public void Previous()
    {

        Debug.Log("Previous");
    }


    public void QuitApp ()
    {
        Debug.Log("Quit!");
        Application.Quit();


    }



}
