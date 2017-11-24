using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {

    bool basicFood; bool middleFood; bool higherFood; bool potion;


    void Start()
    {
        basicFood = false; middleFood = false; higherFood = false; potion = false;
    }

    public void ChangeFood (int food){

        switch (food)
        {
            case 1:
                basicFood = true; middleFood = false; higherFood = false; potion = false;
                break;

            case 2:
                basicFood = false; middleFood = true; higherFood = false; potion = false;
                break;

            case 3:
                basicFood = false; middleFood = false; higherFood = true; potion = false;
                break;

            case 4:
                basicFood = false; middleFood = false; higherFood = false; potion = true;
                break;

            default:
                break;
        }

    }
    
    public void ChangeAlpha()
    {

    }
}
