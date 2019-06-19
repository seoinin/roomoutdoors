using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navscroll : MonoBehaviour {
    

    public Animator anim;

    public void DisableBoolAnimator() {

        anim.SetBool("IsDisplayed", false);
    }

    public void EnableBoolAnimator()
    {

        anim.SetBool("IsDisplayed", true);
    }

    

}
