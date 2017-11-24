using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sweep : MonoBehaviour {
    public bool duringSweep;
    public Image myImage;

    public void Start()
    {
        duringSweep = false;
        ChangeAlpha();
    }

    public void SwapSweepStatus()
    {
        duringSweep = !duringSweep;
        ChangeAlpha();
    }
    public void ChangeAlpha()
    {
        if (duringSweep == true)
        {
            myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, 1f);
        }
        else if (duringSweep == false)
        {
            myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, 0.5f);
        }
    }

}
