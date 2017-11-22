using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //int m_HP = 50;
    //int m_attackPoint = 100;
    public int firstMoney = 1000;
    public int firstFood = 0;
    public int[] Foods = new int[4];
    public int playerMoney;
    public enum Food {BASIC = 0 ,MIDDLE, HIGHER, VERY};
    // BASIC = 0, MIDDLE = 1, HIGHER = 2, VERY = 3

    private void Awake()
    {
        initiate();
    }

    void initiate()
    {
        Foods[0] = PlayerPrefs.GetInt("basicfood", firstFood); // Basic Food
        Foods[1] = PlayerPrefs.GetInt("middlefood", firstFood); // Middle Food
        Foods[2] = PlayerPrefs.GetInt("higherfood", firstFood); // Higher Food
        Foods[3] = PlayerPrefs.GetInt("veryfood", firstFood); // Very Food
        playerMoney = PlayerPrefs.GetInt("playermoney", firstMoney);
    }

    public void SetMoney(int settingMoney) // Set했을 땐 Get을 써서 꼭 변수를 초기화해주자.
    {
        PlayerPrefs.SetInt("playermoney", settingMoney);
        PlayerPrefs.Save();
        playerMoney = PlayerPrefs.GetInt("playermoney", firstMoney);
    }

    public void SetFood(Food whatIsYourFood, int foodNumber)
    {
        switch (whatIsYourFood)
        {
            case Food.BASIC:
                PlayerPrefs.SetInt("basicfood", foodNumber);
                PlayerPrefs.Save();
                Foods[0] = PlayerPrefs.GetInt("basicfood", firstFood);
                break;

            case Food.MIDDLE:
                PlayerPrefs.SetInt("middlefood", foodNumber);
                PlayerPrefs.Save();
                Foods[1] = PlayerPrefs.GetInt("middlefood", firstFood);
                break;

            case Food.HIGHER:
                PlayerPrefs.SetInt("higherfood", foodNumber);
                PlayerPrefs.Save();
                Foods[2] = PlayerPrefs.GetInt("higherfood", firstFood);
                break;

            case Food.VERY:
                PlayerPrefs.SetInt("veryfood", foodNumber);
                PlayerPrefs.Save();
                Foods[3] = PlayerPrefs.GetInt("veryfood", firstFood);
                break;

            default:
                break;
        }
    }

}
