using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slider : MonoBehaviour, IPointerDownHandler,
    IPointerUpHandler
{

    public CanvasGroup slideropacity;
    private bool pressed = false;


    private void Awake()
    {
        slideropacity.GetComponent<CanvasGroup>();

    }

    public void Update()
    {

        Opacity();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    public void Opacity()
    {
        if (pressed)
        {
            slideropacity.alpha = 1;
        }
        else
        {

            slideropacity.alpha = 0.3f;
        }
    }



    /*
    public GameObject slidercomp;
    private RectTransform slider;
    private bool isOn = false;

    //public GameObject brightness;

   
        void Awake()
        {
            slider = slidercomp.GetComponent<RectTransform>();
        }


    public void ShowSlider()
        {
            if (isOn)
            {
                slider.gameObject.SetActive(true);
                isOn = false;
            }
            else
            {
                slider.gameObject.SetActive(false);
                isOn = true;
            }
        }
       */


}

