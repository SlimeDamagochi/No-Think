﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePooController : MonoBehaviour {

    public GameObject slimePoo;
    bool isMaked = false; // 
    public Slime mySlime;

	void Start()
    {
        Instantiate(slimePoo);
        isMaked = true;
        int randomX = Random.Range(-1, 0);
        int randomY = Random.Range(-3, -1);
        slimePoo.transform.position = new Vector2(randomX, randomY);
        slimePoo.SetActive(true);

    }

    void slimeIsPood()
    {
        slimePoo.SetActive(true);
        switch (mySlime.getFoodnum())
        {
            case 1:
                slimePoo.SetActive(true);
                isMaked = false;
                mySlime.setFoodNum();
                break;
            case 2:
                slimePoo.SetActive(true);
                isMaked = false;
                slimePoo.transform.localScale += new Vector3(1, 1);
                mySlime.setFoodNum();
                break;
            case 3:
                slimePoo.SetActive(true);
                isMaked = false;
                slimePoo.transform.localScale += new Vector3(2, 2);
                mySlime.setFoodNum();
                break;
            default:
                break;
         }
    }

	

}