using System.Collections;
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

    void slimePooIsInstance()
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
               
                break;
            case 2:
                
                slimePoo.transform.localScale += new Vector3(1, 1);
                
                break;
            case 3:
                
                slimePoo.transform.localScale += new Vector3(2, 2);
               
                break;
            default:
                break;
         }
        isMaked = false;
        mySlime.setFoodNum();
    }

	

}
