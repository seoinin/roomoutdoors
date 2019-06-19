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

    public void Home()
    {

        SceneManager.LoadScene("Home");
    }

    public void Carports()
    {

        SceneManager.LoadScene("Carports");
    }

    public void Awnings()
    {

        SceneManager.LoadScene("Awnings");
    }

    public void ROintro()
    {

        SceneManager.LoadScene("ROintro");
    }


    public void OpenURL()
    {
        Application.OpenURL("https://www.roomoutdoors.ie/");

    }

    public void OpenBrochure()
    {
        Application.OpenURL("https://view.publitas.com/datatrace/roomoutdoors/page/1");

    }


    public void QuitApp()
    {
        Debug.Log("Quit!");
        Application.Quit();


    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }

 
}
