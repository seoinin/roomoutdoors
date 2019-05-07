using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void Products()
    {

        SceneManager.LoadScene("Products");
    }

    public void RoomOutdoors2()
    {

        SceneManager.LoadScene("RoomOutdoors2");
    }

    public void Verandas()
    {

        SceneManager.LoadScene("Verandas");
    }

    public void GardenRooms()
    {

        SceneManager.LoadScene("GardenRooms");
    }

    public void GardenCabins()
    {

        SceneManager.LoadScene("GardenCabins");
    }

    public void Furniture()
    {

        SceneManager.LoadScene("Furniture");
    }

    public void Favourites()
    {

        SceneManager.LoadScene("Favourites");
    }

    public void Carports()
    {

        SceneManager.LoadScene("Carports");
    }

    public void Awnings()
    {

        SceneManager.LoadScene("Awnings");
    }

    public void QuitApp()
    {
        Debug.Log("Quit!");
        Application.Quit();


    }
}
