using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationMarkersManager : MonoBehaviour {

    public GameObject Marker;
   
    public GameObject Rack;
    public GameObject RailRef;
    public ArrayList MarkersActive;

    public GameObject[] Markers;
    public int Size = 40;
    // Use this for initialization
    void Start () {


        RailRef = GameObject.FindGameObjectWithTag("RailRef");
        Vector3 position = RailRef.transform.position;

        Markers = new GameObject[Size];
        Rack = GameObject.FindGameObjectWithTag("Rack");
        Debug.Log("Creating Markers");
        for (var i = 0;i< Size; i++) {
            Debug.Log("Creating Marker " + i);

            //MarkersActive[i] = 1;

            position[1] = i; // the Z value
            GameObject markerObject = Instantiate(Marker, RailRef.transform) as GameObject;
            markerObject.transform.Translate(Vector3.up * i/56, Space.World);
            markerObject.transform.localScale = new Vector3(1,1,1);
            Markers[i] = markerObject;
            Markers[i].gameObject.SetActive(true);
            markerObject.transform.parent = RailRef.transform;

        }
	}
    public void SetHoleMarkerActive(int num)
    {
        Markers[num].gameObject.SetActive(true);

    }
    public void SetHoleMarkerUnActive(int num)
    {
        Markers[num].gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
       
                

        }
    }