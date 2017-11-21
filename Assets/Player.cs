using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //int m_HP = 50;
    //int m_attackPoint = 100;
    public int firstMoney = 1000;
    // int* food = new int[4];
    public int firstFood = 0;
    public int basicFood;
    public int middleFood;
    public int higherFood;
    public int veryFood;
    public int playerMoney;

    private void Awake()
    {
        initiate();
    }

    void initiate()
    { 
        basicFood = PlayerPrefs.GetInt("basicfood", 0); 
        middleFood = PlayerPrefs.GetInt("middlefood", 0);
        higherFood = PlayerPrefs.GetInt("higherfood", 0);
        veryFood = PlayerPrefs.GetInt("veryfood", 0);
        playerMoney = PlayerPrefs.GetInt("playermoney", 1000);
    }

}
