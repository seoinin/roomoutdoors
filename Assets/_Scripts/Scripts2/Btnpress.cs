using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Btnpress : MonoBehaviour, IPointerDownHandler,
    IPointerUpHandler
{

    public CanvasGroup button;
    private bool pressed = false;


    private void Awake()
    {
        button.GetComponent<CanvasGroup>();

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
            button.alpha = 0.3f;
        }
        else
        {

            button.alpha = 1f;
        }
    }
}
